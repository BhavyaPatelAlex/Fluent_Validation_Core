using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace FulentValidation
{
    public class UserManager : IUserManager
    {
        private readonly IValidator<User> _validator;
        public UserManager(IValidator<User> validator)
        {
            _validator = validator;
        }

        public async Task Manage(User user)
        {
            await _validator.ValidateAsync(user);
        }
    }
}
