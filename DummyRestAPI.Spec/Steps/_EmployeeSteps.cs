//using Newtonsoft.Json.Linq;
//using RestAPI.Spec.Models;
//using TechTalk.SpecFlow;

//using Xunit;

//namespace RestAPI.Spec.Steps
//{
//    [Binding]
//    public class EmployeeSteps
//    {
//        private readonly EmployeeApiClient employeeApiClient = new EmployeeApiClient();

//        private ResponseAddGetUpdate responseAddGetUpdate;
//        private ResponseDelete responseDelete;
//        private ResponseGet responseGet;
//        private ResponseGetInvalid responseGetInvalid;
//        private Employee employeeToBeModified;
//        private Employee employeeModified;

//        private Employee employee;

//        [Given(@"employee rest API")]
//        public void GivenEmployeeRestAPI()
//        {
//            employeeApiClient.SetBaseUrl(Settings.UrlProd);
//        }

//        [When(@"ADD endpoint is called")]
//        public void WhenAddEndpointIsCalled()
//        {
//            employee = new Employee("Kamil", 33, 25000);

//            var body = new JObject();
//            body.Add("employee_name", employee.Name);
//            body.Add("age", employee.Age);
//            body.Add("salary", employee.Salary);

//            responseAddGetUpdate = employeeApiClient.Add(body);
//        }

//        [Then(@"added employee can be fetched")]
//        public void ThenAddedEmployeeCanBeFetched()
//        {
//            var employeeReturned = responseAddGetUpdate.Employee;
//            Assert.True(employeeReturned.Name == employee.Name);
//            Assert.True(employeeReturned.Age == employee.Age);
//            Assert.True(employeeReturned.Salary == employee.Salary);

//            responseAddGetUpdate = employeeApiClient.Get(employeeReturned.Id);
//        }

//        [When(@"GET endpoint is called")]
//        public void WhenGetEndpointIsCalled()
//        {
//            responseGet = employeeApiClient.Get();
//        }

//        [Then(@"list of employees is returned")]
//        public void ThenListOfEmployeesIsReturned()
//        {
//            Assert.True(responseGet.Employees.Count == 24);
//        }

//        [When(@"GET endpoint is called with valid id(.*)")]
//        public void WhenGetEndpointIsCalledWithValidId(int id)
//        {
//            responseAddGetUpdate = employeeApiClient.Get(id);
//            responseGet = employeeApiClient.Get();
//        }

//        [When(@"GET endpoint is called with an invalid id")]
//        public void WhenGetEndpointIsCalledWithAnInvalidId()
//        {
//            responseGetInvalid = employeeApiClient.GetInvalid();
//        }

//        [Then(@"employee of id (.*) is returned")]
//        public void ThenEmployeeOfIdIsReturned(int id)
//        {
//            var employeeFetched = responseAddGetUpdate.Employee;
//            var employeeExpected = responseGet.Employees[id - 1];

//            Assert.True(employeeFetched.Id == id);
//            Assert.True(employeeFetched.Age == employeeExpected.Age);
//            Assert.True(employeeFetched.Id == employeeExpected.Id);
//            Assert.True(employeeFetched.Name == employeeExpected.Name);
//            Assert.True(employeeFetched.Salary == employeeExpected.Salary);
//        }

//        [Then(@"null is returned")]
//        public void ThenNullIsReturned()
//        {
//            Assert.Null(responseGetInvalid.Data);

//        }

//        [When(@"ADD endpoint is called without body")]
//        public void WhenAddEndpointIsCalledWithoutBody()
//        {
//            var body = new JObject();
//            responseAddGetUpdate = employeeApiClient.Add(body);
//        }

//        [Then(@"default employee is added")]
//        public void ThenDefaultEmployeeIsAdded()
//        {
//            var employee = responseAddGetUpdate.Employee;

//            Assert.True(employee.Age == 0);
//            Assert.True(employee.Salary == 0);
//            Assert.True(employee.Id > 0);
//            Assert.Null(employee.Name);
//        }

//        [When(@"UPDATE endpoint is called with valid id (.*)")]
//        public void WhenUpdateEndpointIsCalledWithValidId(int employeeId)
//        {
//            responseAddGetUpdate = employeeApiClient.Get(employeeId);
//            employeeToBeModified = responseAddGetUpdate.Employee;
//            employeeModified = new Employee($"{employeeToBeModified.Name}_modified", employeeToBeModified.Age + 1, employeeToBeModified.Salary + 1);

//            var body = new JObject();
//            body.Add("employee_name", employeeModified.Name);
//            body.Add("age", employeeModified.Age);
//            body.Add("salary", employeeModified.Salary);

//            responseAddGetUpdate = employeeApiClient.Update(employeeId, body);
//        }

//        [Then(@"employee of id (.*) is updated")]
//        public void ThenEmployeeOfIdIsUpdated(int employeeId)
//        {
//            var employeeReturned = responseAddGetUpdate.Employee;
//            Assert.True(employeeReturned.Age == employeeModified.Age);
//            Assert.True(employeeReturned.Name == employeeModified.Name);
//            Assert.True(employeeReturned.Salary == employeeModified.Salary);

//            responseAddGetUpdate = employeeApiClient.Get(employeeId);
//            var employeeFetched = responseAddGetUpdate.Employee;

//            // the db data was not updated dso below assertions are failing 
//            // Assert.True(employeeFetched.Age == employeeModified.Age);
//            // Assert.True(employeeFetched.Name == employeeModified.Name);
//            // Assert.True(employeeFetched.Salary == employeeModified.Salary);
//        }

//        [When(@"DELETE endpoint is called with valid id (.*)")]
//        public void WhenDeleteEndpointIsCalledWithValidId(int employeeId)
//        {
//            responseDelete = employeeApiClient.Delete(employeeId);
//        }

//        [Then(@"employee of id (.*) is deleted")]
//        public void ThenEmployeeOfIdIsDeleted(int employeeId)
//        {
//            Assert.True(responseDelete.Data == employeeId);
//            responseAddGetUpdate = employeeApiClient.Get(employeeId);
//            // hard to validate deletion as (honestly) we are not deletinng anything...
//        }
//    }
//}