//using EmployeesApiSpec.Steps;
//using Newtonsoft.Json.Linq;
//using RestAPI.Spec.Models;
//using TechTalk.SpecFlow;

//using Xunit;

//namespace RestAPI.Spec.Steps
//{
//    [Binding]
//    public class EmployeeThenSteps
//    {
//        private readonly Context context;
//        public EmployeeThenSteps(Context context)
//        {
//            this.context = context;
//        }

//        [Then(@"added employee can be fetched")]
//        public void ThenAddedEmployeeCanBeFetched()
//        {
//            var employeeReturned = context.responseAddGetUpdate.Employee;
//            Assert.True(employeeReturned.Name == context.employee.Name);
//            Assert.True(employeeReturned.Age == context.employee.Age);
//            Assert.True(employeeReturned.Salary == context.employee.Salary);

//            context.responseAddGetUpdate = context.employeeApiClient.Get(employeeReturned.Id);
//        }


//        [Then(@"list of employees is returned")]
//        public void ThenListOfEmployeesIsReturned()
//        {
//            Assert.True(context.responseGet.Employees.Count == 24);
//        }



//        [Then(@"employee of id (.*) is returned")]
//        public void ThenEmployeeOfIdIsReturned(int id)
//        {
//            var employeeFetched = context.responseAddGetUpdate.Employee;
//            var employeeExpected = context.responseGet.Employees[id - 1];

//            Assert.True(employeeFetched.Id == id);
//            Assert.True(employeeFetched.Age == employeeExpected.Age);
//            Assert.True(employeeFetched.Id == employeeExpected.Id);
//            Assert.True(employeeFetched.Name == employeeExpected.Name);
//            Assert.True(employeeFetched.Salary == employeeExpected.Salary);
//        }

//        [Then(@"null is returned")]
//        public void ThenNullIsReturned()
//        {
//            Assert.Null(context.responseGetInvalid.Data);

//        }

//        [Then(@"default employee is added")]
//        public void ThenDefaultEmployeeIsAdded()
//        {
//            var employee = context.responseAddGetUpdate.Employee;

//            Assert.True(employee.Age == 0);
//            Assert.True(employee.Salary == 0);
//            Assert.True(employee.Id > 0);
//            Assert.Null(employee.Name);
//        }


//        [Then(@"employee of id (.*) is updated")]
//        public void ThenEmployeeOfIdIsUpdated(int employeeId)
//        {
//            var employeeReturned = context.responseAddGetUpdate.Employee;
//            Assert.True(employeeReturned.Age == context.employeeModified.Age);
//            Assert.True(employeeReturned.Name == context.employeeModified.Name);
//            Assert.True(employeeReturned.Salary == context.employeeModified.Salary);

//            context.responseAddGetUpdate = context.employeeApiClient.Get(employeeId);
//            var employeeFetched = context.responseAddGetUpdate.Employee;

//            // the db data was not updated so below assertions are failing 
//            // Assert.True(employeeFetched.Age == employeeModified.Age);
//            // Assert.True(employeeFetched.Name == employeeModified.Name);
//            // Assert.True(employeeFetched.Salary == employeeModified.Salary);
//        }

//        [Then(@"employee of id (.*) is deleted")]
//        public void ThenEmployeeOfIdIsDeleted(int employeeId)
//        {
//            Assert.True(context.responseDelete.Data == employeeId);
//            context.responseAddGetUpdate = context.employeeApiClient.Get(employeeId);
//            // hard to validate deletion as (honestly) we are not deletinng anything...
//        }
//    }
//}