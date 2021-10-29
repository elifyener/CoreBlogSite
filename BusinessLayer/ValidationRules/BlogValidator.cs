using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle)
                .NotEmpty()
                .WithMessage("Blog başlığı boş bırakılamaz.")
                .MaximumLength(150)
                .WithMessage("Lütfen 150 karakterden daha az veri girişi yapınız.")
                .MinimumLength(5)
                .WithMessage("Lütfen 4 karakterden daha fazla veri girişi yapınız.");

            RuleFor(x => x.BlogContent)
                .NotEmpty()
                .WithMessage("Blog içeriği boş bırakılamaz.");

            RuleFor(x => x.BlogImage)
                .NotEmpty()
                .WithMessage("Blog görseli boş bırakılamaz.");
        }
    }
}
