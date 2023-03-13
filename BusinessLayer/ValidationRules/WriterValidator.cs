using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.EmailAdress).NotEmpty().WithMessage("Email adress cannot be empty");
			RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty");
			RuleFor(x => x.Password).MinimumLength(8).WithMessage("Password must contains at least 8 character");
			 

		}
	}
}
