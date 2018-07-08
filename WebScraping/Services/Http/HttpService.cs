using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebScraping.Services.Http
{
    public class HttpService : IHttpService
    {
        private HttpClient httpClient;

        public HttpService()
        {
            this.httpClient = new HttpClient();
            InitClient();
        }

        private void InitClient()
        {
            this.httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml");
            this.httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
            this.httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
            this.httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");
        }

        public async Task<string> GetResponse(string url)
        {
            var response = await this.httpClient.GetAsync(new Uri(url));

            response.EnsureSuccessStatusCode();
            using (var responseStream = await response.Content.ReadAsStreamAsync())
            using (var decompressedStream = new GZipStream(responseStream, CompressionMode.Decompress))
            using (var streamReader = new StreamReader(decompressedStream))
            {
                return await streamReader.ReadToEndAsync();
            }
        }
    }
}
