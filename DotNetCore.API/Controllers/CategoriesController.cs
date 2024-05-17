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
        public CategoriesController(IUnitOfWork unitOfWork)
        {
             _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categoeriesDomain = (List<Category>)await _unitOfWork.Category.GetAllAsync();

            var categoeriesDto = new List<CategoryDTO>();
            foreach (var categoryDomain in categoeriesDomain)
            {
                categoeriesDto.Add(new CategoryDTO()
                {
                    Id = categoryDomain.Id,
                    Name = categoryDomain.Name,
                    Description = categoryDomain.Description,
                    CreatedDate = categoryDomain.CreatedDate,
                    UpdatedDate = categoryDomain.UpdatedDate,
                });
            }

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

            var categoryDto = new CategoryDTO
            {
                Id = categoryDomain.Id,
                Name = categoryDomain.Name,
                Description = categoryDomain.Description,
                CreatedDate = categoryDomain.CreatedDate,
                UpdatedDate = categoryDomain.UpdatedDate,
            };

            return Ok(categoryDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddCategoryRequestDto addCategoryRequest)
        {
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo saZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

            DateTime utcNow = DateTime.UtcNow;
            DateTime saNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, saZone);

            var categoryDomain = new Category()
            {
                Name = addCategoryRequest.Name,
                Description = addCategoryRequest.Description,
                CreatedDate = saNow,
                UpdatedDate = saNow,
            };

            await _unitOfWork.Category.AddAsync(categoryDomain);
            _unitOfWork.Save();

            var categoryDto = new CategoryDTO
            {
                Id = categoryDomain.Id,
                Name = categoryDomain.Name,
                Description = categoryDomain.Description,
                CreatedDate = categoryDomain.CreatedDate,
                UpdatedDate = categoryDomain.UpdatedDate,
            };
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

            var categoryDomain = await _unitOfWork.Category.GetAsync(u => u.Id == Id);
            if (categoryDomain == null)
            {
                return NotFound();
            }

            categoryDomain.Name = updateCategoryRequest.Name;
            categoryDomain.Description = updateCategoryRequest.Description;
            categoryDomain.UpdatedDate = saNow;

            _unitOfWork.Category.Update(categoryDomain);
            _unitOfWork.Save();

            var categoryDto = new CategoryDTO
            {
                Id = categoryDomain.Id,
                Name = categoryDomain.Name,
                Description = categoryDomain.Description,
                CreatedDate = categoryDomain.CreatedDate,
                UpdatedDate = categoryDomain.UpdatedDate,
            };
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
