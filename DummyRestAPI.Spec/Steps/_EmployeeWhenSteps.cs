//using EmployeesApiSpec.Steps;
//using Newtonsoft.Json.Linq;
//using RestAPI.Spec.Models;
//using TechTalk.SpecFlow;

//namespace RestAPI.Spec.Steps
//{
//    [Binding]
//    public class EmployeeWhenSteps
//    {
//        private readonly Context context;
//        public EmployeeWhenSteps(Context context)
//        {
//            this.context = context;
//        }

//        [When(@"ADD endpoint is called")]
//        public void WhenAddEndpointIsCalled()
//        {
//            context.employee = new Employee("Kamil", 33, 25000);

//            var body = new JObject();
//            body.Add("employee_name", context.employee.Name);
//            body.Add("age", context.employee.Age);
//            body.Add("salary", context.employee.Salary);

//            context.responseAddGetUpdate = context.employeeApiClient.Add(body);
//        }

//        [When(@"GET endpoint is called")]
//        public void WhenGetEndpointIsCalled()
//        {
//            context.responseGet = context.employeeApiClient.Get();
//        }

//        [When(@"GET endpoint is called with valid id(.*)")]
//        public void WhenGetEndpointIsCalledWithValidId(int id)
//        {
//            context.responseAddGetUpdate = context.employeeApiClient.Get(id);
//            context.responseGet = context.employeeApiClient.Get();
//        }

//        [When(@"GET endpoint is called with an invalid id")]
//        public void WhenGetEndpointIsCalledWithAnInvalidId()
//        {
//            context.responseGetInvalid = context.employeeApiClient.GetInvalid();
//        }

//        [When(@"ADD endpoint is called without body")]
//        public void WhenAddEndpointIsCalledWithoutBody()
//        {
//            var body = new JObject();
//            context.responseAddGetUpdate = context.employeeApiClient.Add(body);
//        }

//        [When(@"UPDATE endpoint is called with valid id (.*)")]
//        public void WhenUpdateEndpointIsCalledWithValidId(int employeeId)
//        {
//            var responseAddGetUpdate = context.employeeApiClient.Get(employeeId);
//            var employeeToBeModified = responseAddGetUpdate.Employee;
//            var employeeModified = new Employee($"{employeeToBeModified.Name}_modified", employeeToBeModified.Age + 1, employeeToBeModified.Salary + 1);

//            var body = new JObject();
//            body.Add("employee_name", employeeModified.Name);
//            body.Add("age", employeeModified.Age);
//            body.Add("salary", employeeModified.Salary);


//            context.responseAddGetUpdate = context.employeeApiClient.Update(employeeId, body);
//            context.employeeToBeModified = employeeToBeModified;
//            context.employeeModified = employeeModified;

//        }

//        [When(@"DELETE endpoint is called with valid id (.*)")]
//        public void WhenDeleteEndpointIsCalledWithValidId(int employeeId)
//        {
//            context.responseDelete = context.employeeApiClient.Delete(employeeId);
//        }


//    }
//}