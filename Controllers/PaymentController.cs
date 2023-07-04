using fluxeen_api.Core.Models.Request;
using Microsoft.AspNetCore.Mvc;
using paypal_sharp.Core.Models;
using paypal_sharp.Core.Models.Response;
using paypal_sharp.Core.Services.Http;
using System.Text.Json;
using PurchaseUnit = fluxeen_api.Core.Models.PurchaseUnit;

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


        [HttpPost("create-order")]
        public async Task<IActionResult> CreateOrder([FromBody] PaymentOrderRequest paymentBody)
        {
            string token = "";

            Object responseContent = new Object();
            string credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes("YOUR_CLIENT_ID:YOUR_SECRET_KEY"));
            var authorizathion = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
            
            var request = new CheckoutOrderRequest
            {
                intent = "CAPTURE",
                purchase_units = new List<PurchaseUnit>
                {
                    new PurchaseUnit
                    {
                        reference_id = paymentBody.reference_id,
                        invoice_id= paymentBody.invoice_id,
                        amount = new fluxeen_api.Core.Models.Amount{
                            value = paymentBody.amount.value,
                            currency_code=paymentBody.amount.currency_code
                        },
                        description = paymentBody.description
                    }
                },
                application_context = new ApplicationContext
                {
                    brand_name = "YOUR_BRAND",
                    locale = "en-EN",
                    landing_page = "NO_PREFERENCE",
                    return_url = "https://localhost:44320/api/paypal-payment/capture-order",
                    cancel_url = "https://localhost:44320/api/paypal-payment/cancel-order",
                    user_action = "PAY_NOW",
                }
            };

            var httpContent = JsonContent.Create(request);
            var response = await RequestHandler.Post("https://api-m.sandbox.paypal.com/v2/checkout/orders", httpContent, null, authorizathion);
            string contentResponse = await response.Content.ReadAsStringAsync();
            var statusCode = (int)response.StatusCode;

            if (string.IsNullOrWhiteSpace(contentResponse))
                return new ObjectResult(responseContent) { StatusCode = statusCode };

            responseContent = contentResponse;
            if (statusCode == 201)
            {
                responseContent = JsonSerializer.Deserialize<CreatedResponse>(contentResponse);
            }

            return new ObjectResult(JsonSerializer.Serialize(responseContent)) { StatusCode = statusCode };
        }
    }
}
