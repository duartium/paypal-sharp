using System.Net.Http.Headers;

namespace paypal_sharp.Core.Services.Http
{
    public class AppRequest
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
                        //client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                    }

                    //Agrego los headers
                    if (headers != null)
                        headers.ToList().ForEach(header => client.DefaultRequestHeaders.Add(header.Key, header.Value));

                    // Realizar la petición POST
                    response = await client.PostAsync(url, data);
                    var responseString = await response.Content.ReadAsStringAsync();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al realizar la petición: " + ex.Message);
                }
                return response;
            }
        }


        public static async Task<HttpResponseMessage> DatafastPost(string url, HttpContent data, Dictionary<string, string> headers = null, AuthenticationHeaderValue authentication = null)
        {
            HttpResponseMessage? response = null;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    if (authentication != null)
                    {
                        client.DefaultRequestHeaders.Authorization = authentication;
                        client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                    }

                    //Agrego los headers
                    if (headers != null)
                        headers.ToList().ForEach(header => client.DefaultRequestHeaders.Add(header.Key, header.Value));

                    // Realizar la petición POST
                    response = await client.PostAsync(url, data);
                    var responseString = await response.Content.ReadAsStringAsync();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al realizar la petición: " + ex.Message);
                }
                return response;
            }
        }
    }
}
