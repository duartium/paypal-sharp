namespace paypal_sharp.Core.Models.Response
{
    public class ErrorResponse
    {
        public string name { get; set; }
        public string message { get; set; }
        public string debug_id { get; set; }
        public List<Detail> details { get; set; }
        public List<Link> links { get; set; }
    }

    public class Detail
    {
        public string field { get; set; }
        public string value { get; set; }
        public string location { get; set; }
        public string issue { get; set; }
        public string description { get; set; }
    }
}
