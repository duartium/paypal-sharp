namespace fluxeen_api.Core.Models.Request
{
    public class Amount
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class PaymentOrderRequest
    {
        public string reference_id { get; set; }
        public string invoice_id { get; set; }
        public Amount amount { get; set; }
        public string description { get; set; }
    }

}
