using EComAPI.Application.Dtos.Products;
using FluentValidation;

namespace EComAPI.Application.Validations.Product;

public class CreateProductValidation : AbstractValidator<CreateProductDto>
{
    public CreateProductValidation()
    {
        RuleFor(p => p.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Ürün Adı Zorunlu bir alandır.")
            .MaximumLength(150)
            .MinimumLength(5)
            .WithMessage("Ürün adı 5 ile 150 karakter arasında olmalıdır");


        RuleFor(p => p.Stock)
            .NotEmpty()
            .NotNull()
            .WithMessage("Stok bilgisi zorunlu bir alandır")
            .Must(s => s >= 0)
            .WithMessage("geçersiz stok bilgisi");

        RuleFor(p => p.Price)
            .NotEmpty()
            .NotNull()
            .WithMessage("Fiyat bilgisi zorunlu bir alandır")
            .Must(s => s >= 0)
            .WithMessage("geçersiz fiyat bilgisi");
    }
}
