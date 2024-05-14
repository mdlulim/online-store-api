using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly  OnlineStoreDbContext _dbContext;
        public RegionsController(OnlineStoreDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        [HttpGet]
        public  IActionResult GetAll()
        {
            var regionsDomain = _dbContext.Regions.ToList();

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
        public IActionResult GetById([FromRoute] Guid Id) {
            var regionDomain = _dbContext.Regions.FirstOrDefault(u => u.Id == Id);

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
        public IActionResult Create([FromBody] AddRegionRequestDto addRegionRequest)
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

            _dbContext.Regions.Add(regionDomain);
            _dbContext.SaveChanges();

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
        public IActionResult Update([FromRoute] Guid Id, [FromBody] UpdateRegionRequestDto updateRegionRequest)
        {
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo saZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

            DateTime utcNow = DateTime.UtcNow;
            DateTime saNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, saZone);

            var regionDomain = _dbContext.Regions.FirstOrDefault(u => u.Id == Id);
            if(regionDomain == null)
            {
                return NotFound();  
            }

            regionDomain.Name = updateRegionRequest.Name;
            regionDomain.Code = updateRegionRequest.Code;
            regionDomain.Description = updateRegionRequest.Description;
            regionDomain.UpdatedDate = saNow;

            _dbContext.Regions.Update(regionDomain);
            _dbContext.SaveChanges();

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
        public IActionResult Delete([FromRoute] Guid Id)
        {
            var regionDomain = _dbContext.Regions.FirstOrDefault(u => u.Id == Id);
            if (regionDomain == null)
            {
                return NotFound();
            }

            _dbContext.Regions.Remove(regionDomain);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
