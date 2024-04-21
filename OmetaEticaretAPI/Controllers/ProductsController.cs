using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OmetaETicaretAPI.Application.Abstractions;
using OmetaETicaretAPI.Application.Repositories;
using OmetaETicaretAPI.Application.Repositories.Customer;
using OmetaETicaretAPI.Application.ViewModels.Products;
using OmetaETicaretAPI.Domain.Entities;
using System.Net;

namespace OmetaEticaretAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;

		private readonly IProductReadRepository _productReadRepository;
		private readonly IProductWriteRepository _productWriteRepository;
		private readonly IWebHostEnvironment _webhostingEnvironment;
		public ProductsController(IProductService productService, IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IWebHostEnvironment webhostingEnvironment)
		{
			_productService = productService;
			_productReadRepository = productReadRepository;
			_productWriteRepository = productWriteRepository;
			_webhostingEnvironment = webhostingEnvironment;
		}

		[HttpGet]
		public IActionResult Get()
		{

			return Ok(_productReadRepository.GetAll(false).Select(p => new
			{
				p.Id,
				p.Name,
				p.Stock,
				p.Price,
				p.CreateDate,
				p.ChangeDate
			}));
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(string id)
		{

			return Ok(await _productReadRepository.GetByIdAsync(id, false));
		}
		[HttpPost]
		public async Task<IActionResult> Post(VM_Create_Product model)
		{
			if(ModelState.IsValid)
			{

			}

			await _productWriteRepository.AddAsync(new()
			{
				Name = model.ProductName,
				Price = model.Price,
				Stock = model.Stock
			});
			await _productWriteRepository.SaveAsync();
			return StatusCode((int)HttpStatusCode.Created);
		}
		[HttpPut]

		public async Task<IActionResult> Put(VM_Update_Product model)
		{
			Product product = await _productReadRepository.GetByIdAsync(model.Id);
			product.Stock = model.Stock;
			product.Price = model.Price;
			product.Name = model.Name;
			await _productWriteRepository.SaveAsync();
			return Ok();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(string id)
		{
			await _productWriteRepository.RemoveAsync(id);
			await _productWriteRepository.SaveAsync();
			return Ok();
		}

		[HttpPost("Action")]

		public async Task<IActionResult> Upload()
		{
			Random r = new();
			string uploadPath = Path.Combine(_webhostingEnvironment.WebRootPath,"resource/product-images");
			
			if(Directory.Exists(uploadPath) == false)
			{
                Directory.CreateDirectory(uploadPath);
            }
			
			foreach (IFormFile file in Request.Form.Files)
			{
                string fullPath = Path.Combine(uploadPath, $"{r.Next()}{Path.GetExtension(file.FileName)}");

				using FileStream fileStream = new(fullPath, FileMode.Create, FileAccess.Write,FileShare.None, 1024*1024, useAsync: false);
				await file.CopyToAsync(fileStream);
				await fileStream.FlushAsync();


            }
			return Ok();
		}
	}
}
