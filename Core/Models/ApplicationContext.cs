using fluxeen_api.Core.Models.Paymenth;

namespace paypal_sharp.Core.Models
{
    public class ApplicationContext
    {
        public string brand_name { get; set; }
        public string landing_page { get; set; }
        public string shipping_preference { get; set; }
        public string user_action { get; set; }
        public string return_url { get; set; }
        public string cancel_url { get; set; }
        public string locale { get; set; }
        public PaymentMethod payment_method { get; set; }
        public StoredPaymentSource stored_payment_source { get; set; }
    }

    public class PaymentMethod
    {
        public string standard_entry_class_code { get; set; }
        public string payee_preferred { get; set; }
    }

    public class StoredPaymentSource
    {
        public string payment_initiator { get; set; }
        public string payment_type { get; set; }
        public string usage { get; set; }
        public PreviousNetworkTransactionReference previous_network_transaction_reference { get; set; }
    }
}
