using AutoMapper;
using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Models.DTOs;
using DotNetCore.API.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoriesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
             _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categoeriesDomain = (List<Category>)await _unitOfWork.Category.GetAllAsync();
            var categoeriesDto = _mapper.Map<List<CategoryDTO>>(categoeriesDomain);
            return Ok(categoeriesDto);
        }

        [HttpGet]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id)
        {
            var categoryDomain = await _unitOfWork.Category.GetAsync(u => u.Id == Id);
            if (categoryDomain == null)
            {
                return NotFound();
            }

            var categoryDto = _mapper.Map<CategoryDTO>(categoryDomain);
            return Ok(categoryDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddCategoryRequestDto addCategoryRequest)
        {
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo saZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

            DateTime utcNow = DateTime.UtcNow;
            DateTime saNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, saZone);
            addCategoryRequest.UpdatedDate = saNow;

            var categoryDomain = _mapper.Map<Category>(addCategoryRequest);

            await _unitOfWork.Category.AddAsync(categoryDomain);
            _unitOfWork.Save();

            var categoryDto = _mapper.Map<CategoryDTO>(categoryDomain);
            return CreatedAtAction(nameof(GetById), new { Id = categoryDto.Id }, categoryDto);
        }

        [HttpPut]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromBody] UpdateCategoryRequestDto updateCategoryRequest)
        {
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo saZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

            DateTime utcNow = DateTime.UtcNow;
            DateTime saNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, saZone);
            updateCategoryRequest.UpdatedDate = saNow;

            var categoryDomain = await _unitOfWork.Category.GetAsync(u => u.Id == Id);
            if (categoryDomain == null)
            {
                return NotFound();
            }

            categoryDomain = _mapper.Map<Category>(updateCategoryRequest);

            _unitOfWork.Category.Update(categoryDomain);
            _unitOfWork.Save();

            var categoryDto = _mapper.Map<CategoryDTO>(categoryDomain);
            return Ok(categoryDto);
        }

        [HttpDelete]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            var categoryDomain = await _unitOfWork.Category.GetAsync(u => u.Id == Id);
            if (categoryDomain == null)
            {
                return NotFound();
            }

            await _unitOfWork.Category.RemoveAsync(categoryDomain);
            _unitOfWork.Save();
            return Ok();
        }
    }
}
