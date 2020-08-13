using Newtonsoft.Json;

namespace RestAPI.Spec.Models
{
    public class ResponseAddGetUpdate
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("data")]
        public Employee Employee;
    }
}