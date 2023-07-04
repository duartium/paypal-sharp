namespace paypal_sharp.Core.Models.Response
{
    using fluxeen_api.Core.Models.Paymenth.Source;
    public class CreateOrderResponse
    {
        public string id { get; set; }
        public string status { get; set; }
        public PaymentSource payment_source { get; set; }
        public List<Link> links { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string rel { get; set; }
        public string method { get; set; }
    }

}

namespace fluxeen_api.Core.Models.Paymenth.Source
{
    public class PaymentSource
    {
        public object paypal { get; set; }
    }
}
