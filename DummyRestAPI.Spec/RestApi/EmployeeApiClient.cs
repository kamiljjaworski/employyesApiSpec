using Newtonsoft.Json.Linq;
using RestSharp;
using Newtonsoft.Json;
using Xunit;
using System.Net;

namespace RestAPI.Spec.Models
{
    public class EmployeeApiClient
    {
        public RestClient Client;

        public void SetBaseUrl(string url)
        {
            Client = new RestClient(url);
        }

        public ResponseGet Get()
        {
            var request = new RestRequest("employees", Method.GET);
            var response = Client.Execute(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseDeserialized = JsonConvert.DeserializeObject<ResponseGet>(response.Content);
            return responseDeserialized;
        }

        public ResponseAddGetUpdate Get(int id)
        {
            var request = new RestRequest($"employee/{id}", Method.GET);
            var response = Client.Execute(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseDeserialized = JsonConvert.DeserializeObject<ResponseAddGetUpdate>(response.Content);
            return responseDeserialized;
        }

        public ResponseGetInvalid GetInvalid()
        {
            var request = new RestRequest($"employee/nonexistingId", Method.GET);
            var response = Client.Execute(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseDeserialized = JsonConvert.DeserializeObject<ResponseGetInvalid>(response.Content);
            return responseDeserialized;
        }

        public ResponseAddGetUpdate Add(JObject body)
        {
            var request = new RestRequest("create", Method.POST);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            var response = Client.Execute(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseDeserialized = JsonConvert.DeserializeObject<ResponseAddGetUpdate>(response.Content);
            return responseDeserialized;
        }

        public ResponseAddGetUpdate Update(int id, JObject body)
        {
            var request = new RestRequest($"update/{id}", Method.PUT);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            var response = Client.Execute(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseDeserialized = JsonConvert.DeserializeObject<ResponseAddGetUpdate>(response.Content);
            return responseDeserialized;
        }

        public ResponseDelete Delete(int id)
        {
            var request = new RestRequest($"delete/{id}", Method.DELETE);
            var response = Client.Execute(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseDeserialized = JsonConvert.DeserializeObject<ResponseDelete>(response.Content);
            return responseDeserialized;
        }
    }
}

