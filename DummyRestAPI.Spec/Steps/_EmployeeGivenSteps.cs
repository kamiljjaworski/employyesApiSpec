//using EmployeesApiSpec.Steps;
//using Newtonsoft.Json.Linq;
//using RestAPI.Spec.Models;
//using TechTalk.SpecFlow;

//using Xunit;

//namespace RestAPI.Spec.Steps
//{
//    [Binding]
//    public class EmployeeGivenSteps
//    {
//        private readonly Context context;
//        public EmployeeGivenSteps(Context context)
//        {
//            this.context = context;
//        }

//        [Given(@"employee rest API")]
//        public void GivenEmployeeRestAPI()
//        {
//            context.employeeApiClient.SetBaseUrl(Settings.UrlProd);
//        }

//    }
//}