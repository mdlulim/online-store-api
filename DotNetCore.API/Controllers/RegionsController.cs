using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Models.DTOs;
using DotNetCore.API.Repositories;
using DotNetCore.API.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly  OnlineStoreDbContext _dbContext;
        private readonly IUnitOfWork _unitOfWork;
        public RegionsController(OnlineStoreDbContext dbContext, IUnitOfWork unitOfWork) 
        { 
            _dbContext = dbContext;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regionsDomain = (List<Region>) await _unitOfWork.Region.GetAllAsync();

            var regionsDto = new List<RegionDTO>();
            foreach( var regionDomain in regionsDomain)
            {
                regionsDto.Add(new RegionDTO()
                {
                    Id = regionDomain.Id,
                    Name = regionDomain.Name,
                    Code = regionDomain.Code,
                    Description = regionDomain.Description,
                    CreatedDate = regionDomain.CreatedDate,
                    UpdatedDate = regionDomain.UpdatedDate,
                });
            }

            return Ok(regionsDto);
        }

        [HttpGet]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id) {
            var regionDomain = await _unitOfWork.Region.GetAsync(u => u.Id == Id);

            if(regionDomain == null)
            {
                return NotFound();
            }

            var regionDto = new RegionDTO
            {
                Id = regionDomain.Id,
                Name = regionDomain.Name,
                Code = regionDomain.Code,
                Description = regionDomain.Description,
                CreatedDate = regionDomain.CreatedDate,
                UpdatedDate = regionDomain.UpdatedDate,
            };

            return Ok(regionDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequest)
        {
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo saZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

            DateTime utcNow = DateTime.UtcNow;
            DateTime saNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, saZone);

            var regionDomain = new Region()
            {
                Name = addRegionRequest.Name,
                Code = addRegionRequest.Code,
                Description = addRegionRequest.Description,
                CreatedDate = saNow,
                UpdatedDate = saNow,
            };

           await _unitOfWork.Region.AddAsync(regionDomain);
           _unitOfWork.Save();

            var regionDto = new RegionDTO
            {
                Id = regionDomain.Id,
                Name = regionDomain.Name,
                Code = regionDomain.Code,
                Description = regionDomain.Description,
                CreatedDate = regionDomain.CreatedDate,
                UpdatedDate = regionDomain.UpdatedDate,
            };
            return CreatedAtAction(nameof(GetById), new {Id = regionDto.Id}, regionDto);
        }

        [HttpPut]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromBody] UpdateRegionRequestDto updateRegionRequest)
        {
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo saZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

            DateTime utcNow = DateTime.UtcNow;
            DateTime saNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, saZone);

            var regionDomain = await _unitOfWork.Region.GetAsync(u => u.Id == Id);
            if(regionDomain == null)
            {
                return NotFound();  
            }

            regionDomain.Name = updateRegionRequest.Name;
            regionDomain.Code = updateRegionRequest.Code;
            regionDomain.Description = updateRegionRequest.Description;
            regionDomain.UpdatedDate = saNow;

            _unitOfWork.Region.Update(regionDomain);
            _unitOfWork.Save();

            var regionDto = new RegionDTO
            {
                Id = regionDomain.Id,
                Name = regionDomain.Name,
                Code = regionDomain.Code,
                Description = regionDomain.Description,
                CreatedDate = regionDomain.CreatedDate,
                UpdatedDate = regionDomain.UpdatedDate,
            };
            return Ok(regionDto);
        }

        [HttpDelete]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            var regionDomain = await _unitOfWork.Region.GetAsync(u => u.Id == Id);
            if (regionDomain == null)
            {
                return NotFound();
            }

            await _unitOfWork.Region.RemoveAsync(regionDomain);
            _unitOfWork.Save();
            return Ok();
        }
    }
}
