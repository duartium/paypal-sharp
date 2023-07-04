namespace fluxeen_api.Core.Models.Paymenth
{
    public class Attributes
    {
        public Customer customer { get; set; }
        public Vault vault { get; set; }
    }

    public class Bancontact
    {
        public string name { get; set; }
        public string country_code { get; set; }
        public ExperienceContext experience_context { get; set; }
    }

    public class BillingAddress
    {
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string admin_area_2 { get; set; }
        public string admin_area_1 { get; set; }
        public string postal_code { get; set; }
        public string country_code { get; set; }
    }

    public class Blik
    {
        public string name { get; set; }
        public string country_code { get; set; }
        public string email { get; set; }
        public ExperienceContext experience_context { get; set; }
    }

    public class Customer
    {
        public string id { get; set; }
        public string email_address { get; set; }
        public Phone phone { get; set; }
    }

    public class Eps
    {
        public string name { get; set; }
        public string country_code { get; set; }
        public ExperienceContext experience_context { get; set; }
    }

    public class ExperienceContext
    {
        public string brand_name { get; set; }
        public string shipping_preference { get; set; }
        public string landing_page { get; set; }
        public string user_action { get; set; }
        public string payment_method_preference { get; set; }
        public string locale { get; set; }
        public string return_url { get; set; }
        public string cancel_url { get; set; }
        public string payment_method_selected { get; set; }
    }

    public class Giropay
    {
        public string name { get; set; }
        public string country_code { get; set; }
        public ExperienceContext experience_context { get; set; }
    }

    public class Ideal
    {
        public string name { get; set; }
        public string country_code { get; set; }
        public string bic { get; set; }
        public ExperienceContext experience_context { get; set; }
    }

    public class Mybank
    {
        public string name { get; set; }
        public string country_code { get; set; }
        public ExperienceContext experience_context { get; set; }
    }

    public class P24
    {
        public string name { get; set; }
        public string email { get; set; }
        public string country_code { get; set; }
        public ExperienceContext experience_context { get; set; }
    }

    public class PaymentSource
    {
        public Card card { get; set; }
        public Token token { get; set; }
        public Paypal paypal { get; set; }
        public Bancontact bancontact { get; set; }
        public Blik blik { get; set; }
        public Eps eps { get; set; }
        public Giropay giropay { get; set; }
        public Ideal ideal { get; set; }
        public Mybank mybank { get; set; }
        public P24 p24 { get; set; }
        public Sofort sofort { get; set; }
        public Trustly trustly { get; set; }
        public Venmo venmo { get; set; }
    }

    public class Paypal
    {
        public ExperienceContext experience_context { get; set; }
        public string billing_agreement_id { get; set; }
        public string vault_id { get; set; }
        public string email_address { get; set; }
        public Name name { get; set; }
        public Phone phone { get; set; }
        public string birth_date { get; set; }
        public TaxInfo tax_info { get; set; }
        public Address address { get; set; }
        public Attributes attributes { get; set; }
    }

    public class PreviousNetworkTransactionReference
    {
        public string id { get; set; }
        public string date { get; set; }
        public string network { get; set; }
    }

    public class Root
    {
        public PaymentSource payment_source { get; set; }
    }

    public class Sofort
    {
        public string name { get; set; }
        public string country_code { get; set; }
        public ExperienceContext experience_context { get; set; }
    }

    public class StoredCredential
    {
        public string payment_initiator { get; set; }
        public string payment_type { get; set; }
        public string usage { get; set; }
        public PreviousNetworkTransactionReference previous_network_transaction_reference { get; set; }
    }

    public class Token
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Trustly
    {
        public string name { get; set; }
        public string country_code { get; set; }
        public ExperienceContext experience_context { get; set; }
    }

    public class Vault
    {
        public string store_in_vault { get; set; }
        public string description { get; set; }
        public string usage_pattern { get; set; }
        public string usage_type { get; set; }
        public string customer_type { get; set; }
        public bool permit_multiple_payment_tokens { get; set; }
    }

    public class Venmo
    {
        public ExperienceContext experience_context { get; set; }
        public string vault_id { get; set; }
        public string email_address { get; set; }
        public Attributes attributes { get; set; }
    }
}
