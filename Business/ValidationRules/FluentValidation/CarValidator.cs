using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {//kurallar constracter içinde yazılır dto lar içinde burada yazılır 
        public CarValidator()
        {
            RuleFor(c => c.BrandName).MinimumLength(2);
            RuleFor(c => c.BrandName).NotEmpty();//brandname boş olamaz 
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            //RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(150).When(c => c.BrandId == 19);
            //RuleFor(c => c.BrandName).Must(StarWhithA).WithMessage("");




        }

        private bool StarWhithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
