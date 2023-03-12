using Capstone.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.BusinessLayer.ValidationRules
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("You cannot leave the staff name blank!");
            RuleFor(x => x.EmployeeSurName).NotEmpty().WithMessage("You cannot leave the staff surname blank!");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("Please enter at least 2 characters!");
            RuleFor(x => x.EmployeeName).MaximumLength(20).WithMessage("Please enter up to 20 characters!");   
            RuleFor(x => x.EmployeeMail).NotEmpty().WithMessage("You cannot leave the mail address blank!");   
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("Please enter a Category Number");   
        }
    }
}
