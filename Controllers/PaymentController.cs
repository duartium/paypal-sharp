using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace paypal_sharp.Controllers
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentController : BaseApiController<PaymentController>
    {
        public PaymentController()
        {

        }


    }
}
