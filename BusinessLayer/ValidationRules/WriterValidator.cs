using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName)
                .NotEmpty()
                .WithMessage("Yazar adı soyadı boş bırakılamaz.")
                .Length(2, 50)
                .WithMessage("Lütfen en az 2 en fazla 50 karakter giriniz.");

            RuleFor(x => x.WriterMail)
                .NotEmpty()
                .WithMessage("Mail adres boş bırakılamaz.")
                .EmailAddress()
                .WithMessage("Geçerli bir mail adresi giriniz.");

            RuleFor(x => x.WriterPassword)
                .NotEmpty()
                .WithMessage("Şifre boş bırakılamaz.")
                .MinimumLength(6)
                .WithMessage("Şifreniz en az 6 karakter içermeli.")
                .Matches(@"[A-Z]+")
                .WithMessage("Şifreniz en az bir büyük harf içermelidir.")
                .Matches(@"[a-z]+")
                .WithMessage("Şifreniz en az bir küçük harf içermelidir.")
                .Matches(@"[0-9]+")
                .WithMessage("Şifreniz en az bir rakam içermelidir.")
                .Matches(@"[\!\?\*\.]+")
                .WithMessage("Şifren (!? *.) karakterlerden birini içermelidir.");

            RuleFor(x => x.WriterConfirmPassword)
                .NotEmpty()
                .WithMessage("Lütfen şifreyi tekrar giriniz.")
                .Equal(x => x.WriterPassword)
                .WithMessage("Şifreler uyuşmuyor.");
        }
    }
}
