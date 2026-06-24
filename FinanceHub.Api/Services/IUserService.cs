using FinanceHub.Api.Entities;

namespace FinanceHub.Api.Services;

public interface IUserService
{
    User Create(string name, string email);
}