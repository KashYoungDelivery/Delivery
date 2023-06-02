namespace Delivery.Backend.Service
{
    public interface IClientService
    {
        Task<HttpResponseMessage> GetAsync(string id);
        Task<HttpResponseMessage> GetAsync(int id);
        Task<HttpResponseMessage> GetAsync();
        
    }
}
