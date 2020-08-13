using EmployeesApiSpec.Steps;
using TechTalk.SpecFlow;

namespace RestAPI.Spec.Steps
{
    [Binding]
    public class DeleteEmployeeWhenSteps
    {
        private readonly Context context;
        public DeleteEmployeeWhenSteps(Context context)
        {
            this.context = context;
        }

        [When(@"DELETE endpoint is called with valid id (.*)")]
        public void WhenDeleteEndpointIsCalledWithValidId(int employeeId)
        {
            context.responseDelete = context.employeeApiClient.Delete(employeeId);
        }
    }
}