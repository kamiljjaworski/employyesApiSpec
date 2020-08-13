using EmployeesApiSpec.Steps;
using Newtonsoft.Json.Linq;
using RestAPI.Spec.Models;
using TechTalk.SpecFlow;

namespace RestAPI.Spec.Steps
{
    [Binding]
    public class UpdateEmployeeWhenSteps
    {
        private readonly Context context;
        public UpdateEmployeeWhenSteps(Context context)
        {
            this.context = context;
        }

        [When(@"UPDATE endpoint is called with valid id (.*)")]
        public void WhenUpdateEndpointIsCalledWithValidId(int employeeId)
        {
            var employeeToBeModified = context.employeeApiClient.Get(employeeId).Employee;
            var employeeModified = new Employee($"{employeeToBeModified.Name}_modified", employeeToBeModified.Age + 1, employeeToBeModified.Salary + 1);

            var body = new JObject();
            body.Add("employee_name", employeeModified.Name);
            body.Add("age", employeeModified.Age);
            body.Add("salary", employeeModified.Salary);

            context.responseAddGetUpdate = context.employeeApiClient.Update(employeeId, body);
            context.employeeToBeModified = employeeToBeModified;
            context.employeeModified = employeeModified;
        }
    }
}