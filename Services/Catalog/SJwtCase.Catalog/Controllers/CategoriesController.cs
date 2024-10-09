using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SJwtCase.Catalog.Dtos.CategoryDto;
using SJwtCase.Catalog.Entities;
using SJwtCase.Catalog.Services.CategoryServices;

namespace SJwtCase.Catalog.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;  //Dtolar ile çalışacağım içiin buhnu geçtim

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var value = await _categoryService.GetAllAsync(); //liste türünde kategori geldi
            var categories = _mapper.Map<List<ResultCategoryDto>>(value); //value dan gelen değeri resultcategorydto ya maple
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var value = await _categoryService.GetByIdAsync(id);
            var categories = _mapper.Map<GetCategoryByIdDto>(value); //valuedan gelen değeri mapledik
            return Ok(categories);

        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);// createCategoryDto yu Category türüne dönüştürüyor, böylece veritabanına ekleriz.
            await _categoryService.CreateAsync(value);
            return Ok("Kategori başarılı bir şekilde eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);//mapleme
            await _categoryService.UpdateAsync(value);
            return Ok("Kategori başarılı bir şekilde güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteAsync(id);
            return Ok("Kategori başarılı bir şekilde silindi");
        }

    }
}
