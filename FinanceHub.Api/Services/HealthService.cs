namespace FinanceHub.Api.Services;

public class HealthService : IHealthService
{
    public string GetStatus()
    {
        return "API funcionando!";
    }

    public string GetVersion()
    {
        return "1.0.0";
    }
}