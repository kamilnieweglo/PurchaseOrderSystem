namespace AntiFraudSystem.Services
{
    public interface IAntifraudService
    {
        void LoadData(string json);

        void RunMonitor();
    }
}