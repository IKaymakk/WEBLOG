using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar Adı Boş Bırakılamaz")
                .MaximumLength(70).WithMessage("Maksimum 70 Karakter Girin")
                .MinimumLength(3).WithMessage("Minimum 3 Karakter Girin");

            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Yazar Mail Adresi Boş Bırakılamaz")
                .MinimumLength(10).WithMessage("Minimum 10 Karakter Girin")
                .MaximumLength(100).WithMessage("Maksimum 100 Karakter Girin");

            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez")
                .Matches(@"[@,.,+,-,%,#,*]+").WithMessage("Şifre @,.,+,-,%,#,* özel karakterlerden en az birini içermelidir.")
                .MinimumLength(8).WithMessage("Şifre 8 karakterden küçük olamaz.")
                .MaximumLength(16).WithMessage("Şifre 16 karakterden büyük olamaz.")
                .Matches(@"[A-Z]+").WithMessage("Şifrede en az bir büyük harf olmalıdır.")
                .Matches(@"[a-z]+").WithMessage("Şifrede en az bir küçük harf olmalıdır.")
                .Matches(@"[0-9]+").WithMessage("Şifrede en az bir rakam olmalıdır");



        }
    }
}
