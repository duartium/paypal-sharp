namespace fluxeen_api.Core.Models.Paymenth
{
    public class Payer
    {
        public string email_address { get; set; }
        public Name name { get; set; }
        public Phone phone { get; set; }
        public string birth_date { get; set; }
        public TaxInfo tax_info { get; set; }
        public Address address { get; set; }
    }

    public class Phone
    {
        public string phone_type { get; set; }
        public PhoneNumber phone_number { get; set; }
    }

    public class PhoneNumber
    {
        public string national_number { get; set; }
    }

    

    public class TaxInfo
    {
        public string tax_id { get; set; }
        public string tax_id_type { get; set; }
    }


}
