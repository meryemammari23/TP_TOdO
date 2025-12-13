namespace TP_TODO.Services
{
    public interface ICookieManagerService
    {
        string? Get(string key);
        void Set(string key, string value);
    }
}
