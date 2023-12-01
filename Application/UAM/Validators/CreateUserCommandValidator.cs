using Application.UAM.Commands;
using FluentValidation;

namespace Application.UAM.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Password).NotEmpty();
            
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
        }
    }
}
