using System.Threading.Tasks;

namespace WebScraping.Services.Http
{
    public interface IHttpService
    {
        Task<string> GetResponse(string url);
    }
}
