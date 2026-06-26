using FinanceHub.Api.Entities;

namespace FinanceHub.Api.Repositories;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = [];

    public User Save(User user)
    {
        _users.Add(user);

        return user;
    }

    public User? GetByEmail(string email)
    {
        return _users.FirstOrDefault(
            x => x.Email.Equals(
                email,
                StringComparison.OrdinalIgnoreCase));
    }
}