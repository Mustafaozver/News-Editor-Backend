using Entities.Concrete;
using FluentValidation;


namespace Business.ValidationRules.FluentValidation
{
    public class NewsValidator:AbstractValidator<News>
    {
        public NewsValidator()
        {

            RuleFor(n=>n.UserId).NotEmpty().WithMessage("User bilgisi boş olamaz.");
            RuleFor(n=>n.Headline).NotEmpty().WithMessage("Haber başlık bilgisi boş olamaz.");
            RuleFor(p => p.Headline).Must(StartWhitA).WithMessage("Başlık A harfi ile başlamalı.");
            RuleFor(p => p.Body).Must(StartWhitA).WithMessage("Gövde A harfi ile başlamalı.");
            RuleFor(n=>n.Body).NotEmpty().WithMessage("Haber gövde bilgisi boş olamaz.");
        }

        private bool StartWhitA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
