using FinanceHub.Api.Entities;
using FinanceHub.Api.Repositories;

namespace FinanceHub.Api.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User Create(string name, string email)
    {
        var existingUser =
            _userRepository.GetByEmail(email);

        if (existingUser != null)
        {
            throw new Exception(
                "Email já cadastrado.");
        }

        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = name,
            Email = email,
            CreatedAt = DateTime.UtcNow
        };

        return _userRepository.Save(user);
    }
}