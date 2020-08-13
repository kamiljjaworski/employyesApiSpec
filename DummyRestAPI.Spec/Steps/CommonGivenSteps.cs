using EmployeesApiSpec.Steps;
using RestAPI.Spec.Models;
using TechTalk.SpecFlow;

namespace RestAPI.Spec.Steps
{
    [Binding]
    public class CommonGivenSteps
    {
        private readonly Context context;
        public CommonGivenSteps(Context context)
        {
            this.context = context;
        }

        [Given(@"employee rest API")]
        public void GivenEmployeeRestAPI()
        {
            context.employeeApiClient.SetBaseUrl(Settings.UrlProd);
        }
    }
}