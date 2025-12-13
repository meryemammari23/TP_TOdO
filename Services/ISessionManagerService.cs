namespace TP_TODO.Services
{
    public interface ISessionManagerService
    {
        string? Get(string key);
        void Set(string key, string value);
    }
}
