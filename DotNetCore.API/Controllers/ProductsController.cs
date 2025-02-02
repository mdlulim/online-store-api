﻿using AutoMapper;
using DotNetCore.API.CustomActionFilters;
using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Models.DTOs;
using DotNetCore.API.Repositories.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.API.Controllers
{
    [Route("v1/admin/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Customer")]
        //Get Products
        // GET: /api/products?filterOn=Name&filterQuery=Phone&sortBy=Name&isAscending=true&pageNumber=1&pageSize=10
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn = null, [FromQuery] string? filterQuery = null, 
            [FromQuery] string? sortBy = null, [FromQuery] bool? isAscending = null, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize=1000)
        {
            try
            {
                var includeProperties = "Supplier,Category";
                var productsDomain = await _unitOfWork.Product.GetAllAsync(includeProperties: includeProperties, filterOn: filterOn, filterQuery: filterQuery, 
                    sortBy: sortBy, isAscending: isAscending ?? true, pageNumber: pageNumber, pageSize: pageSize);
                var productsDto = _mapper.Map<List<ProductDTO>>(productsDomain);
                return Ok(productsDto);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpGet]
        [Route("{Id:Guid}")]
        [Authorize(Roles = "Admin, Customer")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id)
        {
            var productDomain = await _unitOfWork.Product.GetAsync(u => u.Id == Id, includeProperties: "Supplier,Category");
            if (productDomain == null)
            {
                return NotFound();
            }

            var productDto = _mapper.Map<ProductDTO>(productDomain);
            return Ok(productDto);
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin, Customer")]
        public async Task<IActionResult> Create([FromBody] AddProductRequestDto addProductRequest)
        {
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo saZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

            DateTime utcNow = DateTime.UtcNow;
            DateTime saNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, saZone);
            
            var productDomain = _mapper.Map<Product>(addProductRequest);
            productDomain.CreatedDate = saNow;
            productDomain.UpdatedDate = saNow;
            await _unitOfWork.Product.AddAsync(productDomain);
            _unitOfWork.Save();

            var productDto = _mapper.Map<ProductDTO>(productDomain);
            return CreatedAtAction(nameof(GetById), new { Id = productDto.Id }, productDto);
        }

        [HttpPut]
        [Route("{Id:Guid}")]
        [ValidateModel]
        [Authorize(Roles = "Admin, Customer")]
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromBody] UpdateProductRequestDto updateProductRequest)
        {
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo saZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

            DateTime utcNow = DateTime.UtcNow;
            DateTime saNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, saZone);

            var productDomain = await _unitOfWork.Product.GetAsync(u => u.Id == Id, includeProperties:"");
            if (productDomain == null)
            {
                return NotFound();
            }

            productDomain = _mapper.Map<Product>(updateProductRequest);
            productDomain.Id = Id;
            productDomain.UpdatedDate = saNow;
            _unitOfWork.Product.Update(productDomain);
            _unitOfWork.Save();

            var productDto = _mapper.Map<ProductDTO>(productDomain);
            return Ok(productDto);
        }

        [HttpDelete]
        [Route("{Id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            var productDomain = await _unitOfWork.Product.GetAsync(u => u.Id == Id);
            if (productDomain == null)
            {
                return NotFound();
            }
            await _unitOfWork.Product.RemoveAsync(productDomain);
            _unitOfWork.Save();
            return Ok();
        }
    }
}
