using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SJwtCase.Catalog.Dtos.FeatureDto;
using SJwtCase.Catalog.Entities;
using SJwtCase.Catalog.Services.FeatureServices;

namespace SJwtCase.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;
        public FeaturesController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFeature()
        {
            var value = await _featureService.GetAllAsync();
            var feature = _mapper.Map<List<ResultFeatureDto>>(value);
            return Ok(feature);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureById(int id)
        {
            var value = await _featureService.GetByIdAsync(id);
            var feature = _mapper.Map<GetFeatureByIdDto>(value);
            return Ok(feature);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var value = _mapper.Map<Feature>(createFeatureDto);
            await _featureService.CreateAsync(value);
            return Ok("Öne çıkan özellik başarıyla oluşturuldu");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _featureService.DeleteAsync(id);
            return Ok("Öne çıkan özellik başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var value = _mapper.Map<Feature>(updateFeatureDto);
            await _featureService.UpdateAsync(value);
            return Ok("Öne çıkan güncellendi");
        }
    }
}
