namespace FinanceHub.Api.Services;

public interface IHealthService
{
    string GetStatus();

    string GetVersion();
}