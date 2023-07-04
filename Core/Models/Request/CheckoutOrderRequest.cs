using fluxeen_api.Core.Models.Paymenth;
using paypal_sharp.Core.Models;

namespace fluxeen_api.Core.Models.Request
{
    public class CheckoutOrderRequest
    {
        public List<PurchaseUnit> purchase_units { get; set; }
        public string intent { get; set; }
        public Payer payer { get; set; }
        public ApplicationContext application_context { get; set; }
    }
}
