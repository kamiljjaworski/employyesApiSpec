using EmployeesApiSpec.Steps;
using Newtonsoft.Json.Linq;
using RestAPI.Spec.Models;
using TechTalk.SpecFlow;

namespace RestAPI.Spec.Steps
{
    [Binding]
    public class AddEmployeeWhenSteps
    {
        private readonly Context context;
        public AddEmployeeWhenSteps(Context context)
        {
            this.context = context;
        }

        [When(@"ADD endpoint is called")]
        public void WhenAddEndpointIsCalled()
        {
            context.employee = new Employee("Kamil", 33, 25000);

            var body = new JObject();
            body.Add("employee_name", context.employee.Name);
            body.Add("age", context.employee.Age);
            body.Add("salary", context.employee.Salary);

            context.responseAddGetUpdate = context.employeeApiClient.Add(body);
        }

        [When(@"ADD endpoint is called without body")]
        public void WhenAddEndpointIsCalledWithoutBody()
        {
            var body = new JObject();
            context.responseAddGetUpdate = context.employeeApiClient.Add(body);
        }
    }
}