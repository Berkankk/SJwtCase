using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SJwtCase.Catalog.Dtos.ProductDto;
using SJwtCase.Catalog.Entities;
using SJwtCase.Catalog.Services.ProductServices;
using System.Runtime.CompilerServices;

namespace SJwtCase.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Product service ctor geçip metotları çağıracağımm böylelikle kod tekrarını minimumda tutacağım 
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GettAllProduct() //Tüm ürün
        {
            var value = await _productService.GetAllAsync();
            var product = _mapper.Map<List<ResultProductDto>>(value); //valuedan gelen değeri resultproductdto ya mapledik
            return Ok(product);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByProductId(int id) //idye göre getirme
        {
            var value = await _productService.GetByIdAsync(id);
            var product = _mapper.Map<GetProductByIdDto>(value);
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto) //Yeni ürün ekleme
        {
            var value = _mapper.Map<Product>(createProductDto);
            await _productService.CreateAsync(value);
            return Ok("Ürün başarıyla kaydedildi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id) //ürün silme
        {
            await _productService.DeleteAsync(id);
            return Ok("Ürün başarılı bir şekilde silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto) //ürün güncelleme 
        {
            var value = _mapper.Map<Product>(updateProductDto);
            await _productService.UpdateAsync(value);
            return Ok("Ürün başarılı bir şekilde güncellendi");
        }

        [HttpGet("GetProductsByCategory/{categoryName}")] //İstek atarken ?categoryname demek yerine bunu yazdım
        public async Task<IActionResult> GetProductsByCategory(string categoryName) //Kategoriye göre ürünleri getir
        {
            var values = await _productService.GetFilteredListAsync(x => x.Category.Name == categoryName);
            return Ok(values);
        }
    }
}
