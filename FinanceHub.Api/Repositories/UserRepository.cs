using FinanceHub.Api.Entities;

namespace FinanceHub.Api.Repositories;

public class UserRepository : IUserRepository
{
    public User Save(User user)
    {
        return user;
    }
}