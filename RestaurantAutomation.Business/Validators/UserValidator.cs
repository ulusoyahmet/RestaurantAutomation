using FluentValidation;
using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Business.Validators
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Username)
                .NotEmpty()
                .WithMessage("Username is required.")
                .Must(u => char.IsLetter(u[0]))
                .WithMessage("Username must start with a letter")
                .Length(5, 20)
                .WithMessage("Username must be between 5 and 20 characters");

            // password rules
            RuleFor(u => u.Password)
                .NotEmpty()
                .WithMessage("Password is required.")
                .Length(8, 20)
                .WithMessage("Password must be between 8 and 20 characters")
                // password must contain at least one uppercase letter, one lowercase letter, one number and one special character
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,15}$")
                .WithMessage("Password must contain at least one uppercase letter, one lowercase letter, one number and one special character");

        }
    }
}
