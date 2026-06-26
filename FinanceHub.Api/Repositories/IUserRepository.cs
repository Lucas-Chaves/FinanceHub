using FinanceHub.Api.Entities;

namespace FinanceHub.Api.Repositories;

public interface IUserRepository
{
    User Save(User user);

    User? GetByEmail(string email);
}