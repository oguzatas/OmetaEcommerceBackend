using FluentValidation;
using FluentValidation.AspNetCore;
using OmetaETicaretAPI.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaETicaretAPI.Application.Validations
{
	public class CreateProductValidator : AbstractValidator<VM_Create_Product>
	{
		 public CreateProductValidator() {

			RuleFor(p => p.ProductName).NotEmpty()
				.NotNull()
				.WithMessage("Ürün Adı boş olamaz")
				.MaximumLength(100)
				.MinimumLength(5)
				.WithMessage("Ürün adı 5 ila 100 karakter arasında olmalıdır");



			RuleFor(p => p.Stock).NotEmpty()
				.NotNull()
				.WithMessage("Lütfen Stok Bilgisi girin")
				.Must(s => s >= 0)
				.WithMessage("Stok Negatif olmamalı");

			RuleFor(p => p.Price).NotEmpty()
				.NotNull()
				.WithMessage("Lütfen Fiyat Bilgisi girin")
				.Must(s => s >= 0)
				.WithMessage("Fiyat Negatif olmamalı");
		}
	}
}
