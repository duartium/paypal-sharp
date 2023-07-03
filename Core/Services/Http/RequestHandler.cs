using System.Net.Http.Headers;

namespace paypal_sharp.Core.Services.Http
{
    public class RequestHandler
    {
        public static async Task<HttpResponseMessage> Post(string url, HttpContent data, Dictionary<string, string> headers = null, AuthenticationHeaderValue authentication = null)
        {
            HttpResponseMessage response = null;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    if (authentication != null)
                    {
                        client.DefaultRequestHeaders.Authorization = authentication;
                    }

                    if (headers != null)
                        headers.ToList().ForEach(header => client.DefaultRequestHeaders.Add(header.Key, header.Value));

                    response = await client.PostAsync(url, data);
                    var responseString = await response.Content.ReadAsStringAsync();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al realizar la petición POST: " + ex.Message);
                }
                return response;
            }
        }
    }
}
