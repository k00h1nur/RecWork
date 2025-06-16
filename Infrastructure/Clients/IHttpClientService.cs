namespace Infrastructure.Clients;

public interface IHttpClientService
{
    Task<T?> GetAsync<T>(string url);
    Task<T?> GetAsync<T>(string url, Dictionary<string, string> headers);
    Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest data);
    Task<TResponse?> PutAsync<TRequest, TResponse>(string url, TRequest data);
    Task<bool> DeleteAsync(string url);
}