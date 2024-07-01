using AutoMapper;
using DotNetCore.API.CustomActionFilters;
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
    [Route("v1/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RegionsController(IUnitOfWork unitOfWork, IMapper mapper) 
        { 
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regionsDomain = (List<Region>) await _unitOfWork.Region.GetAllAsync();
            var regionsDto = _mapper.Map<List<RegionDTO>>(regionsDomain);
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

            var regionDto = _mapper.Map<RegionDTO>(regionDomain);
            return Ok(regionDto);
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequest)
        {
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo saZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

            DateTime utcNow = DateTime.UtcNow;
            DateTime saNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, saZone);

            var regionDomain = _mapper.Map<Region>(addRegionRequest);
            regionDomain.CreatedDate = saNow;
            regionDomain.UpdatedDate = saNow;
            await _unitOfWork.Region.AddAsync(regionDomain);
             _unitOfWork.Save();

            var regionDto = _mapper.Map<RegionDTO>(regionDomain);
            return CreatedAtAction(nameof(GetById), new {Id = regionDto.Id}, regionDto);
        }

        [HttpPut]
        [Route("{Id:Guid}")]
        [ValidateModel]
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

            regionDomain = _mapper.Map<Region>(updateRegionRequest);
            regionDomain.Id = Id;
            regionDomain.UpdatedDate = saNow;
            _unitOfWork.Region.Update(regionDomain);
            _unitOfWork.Save();

            var regionDto = _mapper.Map<RegionDTO>(regionDomain);
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
