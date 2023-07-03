using AutoMapper.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paypal_sharp.Core.Models.Response;
using paypal_sharp.Core.Services.Http;
using System.Text.Json;

namespace paypal_sharp.Controllers
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentController : BaseApiController<PaymentController>
    {
        public PaymentController()
        {

        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate()
        {
            AuthResponse responseContent = new AuthResponse();
            string credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(""));
            var authorizathion = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            });

            var response = await RequestHandler.Post("https://api-m.sandbox.paypal.com/v1/oauth2/token", content, null, authorizathion);
            string contentResponse = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrWhiteSpace(contentResponse))
                responseContent = JsonSerializer.Deserialize<AuthResponse>(contentResponse);


            var statusCode = (int)response.StatusCode;
            return new ObjectResult(JsonSerializer.Serialize(responseContent)) { StatusCode = statusCode };
        }

    }
}
