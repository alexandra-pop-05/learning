﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Domain
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        { 
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
