using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Lütfen bir isim belirtiniz");
            RuleFor(u => u.PasswordHash.ToString()).NotEmpty().MinimumLength(8);
            //RuleFor(u => u.Email).Must(Count>0)
        }

        //private bool Count(string arg)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
