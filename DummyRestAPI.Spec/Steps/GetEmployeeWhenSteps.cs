using EmployeesApiSpec.Steps;
using TechTalk.SpecFlow;

namespace RestAPI.Spec.Steps
{
    [Binding]
    public class GetEmployeeWhenSteps
    {
        private readonly Context context;
        public GetEmployeeWhenSteps(Context context)
        {
            this.context = context;
        }

        [When(@"GET endpoint is called")]
        public void WhenGetEndpointIsCalled()
        {
            context.responseGet = context.employeeApiClient.Get();
        }

        [When(@"GET endpoint is called with valid id(.*)")]
        public void WhenGetEndpointIsCalledWithValidId(int id)
        {
            context.responseAddGetUpdate = context.employeeApiClient.Get(id);
            context.responseGet = context.employeeApiClient.Get();
        }

        [When(@"GET endpoint is called with an invalid id")]
        public void WhenGetEndpointIsCalledWithAnInvalidId()
        {
            context.responseGetInvalid = context.employeeApiClient.GetInvalid();
        }
    }
}