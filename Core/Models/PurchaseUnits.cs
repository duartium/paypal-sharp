namespace fluxeen_api.Core.Models
{
    public class PurchaseUnit
    {
        public string reference_id { get; set; }
        public string description { get; set; }
        public string custom_id { get; set; }
        public string invoice_id { get; set; }
        public string soft_descriptor { get; set; }
        public List<Item> items { get; set; }
        public Amount amount { get; set; }
        public Payee payee { get; set; }
        public PaymentInstruction payment_instruction { get; set; }
        public Shipping shipping { get; set; }
        public SupplementaryData supplementary_data { get; set; }

        public PurchaseUnit()
        {
            amount = new Amount { currency_code = "USD" };
        }
    }

    public class Address
    {
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string admin_area_2 { get; set; }
        public string admin_area_1 { get; set; }
        public string postal_code { get; set; }
        public string country_code { get; set; }
    }

    public class Amount
    {
        public string currency_code { get; set; }
        public string value { get; set; }
        public Breakdown breakdown { get; set; }
    }

    public class Breakdown
    {
        public ItemTotal item_total { get; set; }
        public Shipping shipping { get; set; }
        public Handling handling { get; set; }
        public TaxTotal tax_total { get; set; }
        public Insurance insurance { get; set; }
        public ShippingDiscount shipping_discount { get; set; }
        public Discount discount { get; set; }
    }

    public class Card
    {
        public Level2 level_2 { get; set; }
        public Level3 level_3 { get; set; }
    }

    public class Discount
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class DiscountAmount
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class DutyAmount
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class Handling
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class Insurance
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string quantity { get; set; }
        public string description { get; set; }
        public string sku { get; set; }
        public string category { get; set; }
        public UnitAmount unit_amount { get; set; }
        public Tax tax { get; set; }
    }

    public class ItemTotal
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class Level2
    {
        public string invoice_id { get; set; }
        public TaxTotal tax_total { get; set; }
    }

    public class Level3
    {
        public string ships_from_postal_code { get; set; }
        public List<LineItem> line_items { get; set; }
        public ShippingAmount shipping_amount { get; set; }
        public DutyAmount duty_amount { get; set; }
        public DiscountAmount discount_amount { get; set; }
        public ShippingAddress shipping_address { get; set; }
    }

    public class LineItem
    {
        public object name { get; set; }
        public object quantity { get; set; }
        public object description { get; set; }
        public object sku { get; set; }
        public object category { get; set; }
        public object unit_amount { get; set; }
        public object tax { get; set; }
        public object commodity_code { get; set; }
        public object unit_of_measure { get; set; }
        public object discount_amount { get; set; }
        public object total_amount { get; set; }
    }

    public class Name
    {
        public string given_name { get; set; }
        public string surname { get; set; }
    }

    public class Payee
    {
        public string email_address { get; set; }
        public string merchant_id { get; set; }
    }

    public class PaymentInstruction
    {
        public List<PlatformFee> platform_fees { get; set; }
        public string payee_pricing_tier_id { get; set; }
        public string payee_receivable_fx_rate_id { get; set; }
        public string disbursement_mode { get; set; }
    }

    public class PlatformFee
    {
        public Amount amount { get; set; }
        public Payee payee { get; set; }
    }

    

    

    public class Shipping
    {
        public string currency_code { get; set; }
        public string value { get; set; }
        public string type { get; set; }
        public Name name { get; set; }
        public Address address { get; set; }
    }

    public class ShippingAddress
    {
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string admin_area_2 { get; set; }
        public string admin_area_1 { get; set; }
        public string postal_code { get; set; }
        public string country_code { get; set; }
    }

    public class ShippingAmount
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class ShippingDiscount
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class SupplementaryData
    {
        public Card card { get; set; }
    }

    public class Tax
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class TaxTotal
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class UnitAmount
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

}
