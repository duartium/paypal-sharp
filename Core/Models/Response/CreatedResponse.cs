namespace paypal_sharp.Core.Models.Response
{
    public class CreatedResponse
    {
        public string id { get; set; }
        public string status { get; set; }
        public List<Link> links { get; set; }
    }
}
