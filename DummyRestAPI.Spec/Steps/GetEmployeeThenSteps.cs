using EmployeesApiSpec.Steps;
using TechTalk.SpecFlow;
using Xunit;

namespace RestAPI.Spec.Steps
{
    [Binding]
    public class GetEmployeeThenSteps
    {
        private readonly Context context;
        public GetEmployeeThenSteps(Context context)
        {
            this.context = context;
        }

        [Then(@"list of employees is returned")]
        public void ThenListOfEmployeesIsReturned()
        {
            Assert.Equal(24, context.responseGet.Employees.Count);
        }

        [Then(@"employee of id (.*) is returned")]
        public void ThenEmployeeOfIdIsReturned(int id)
        {
            var employeeFetched = context.responseAddGetUpdate.Employee;
            var employeeExpected = context.responseGet.Employees[id - 1];

            Assert.Equal(id, employeeFetched.Id);
            Assert.Equal(employeeExpected.Age, employeeFetched.Age);
            Assert.Equal(employeeExpected.Id, employeeFetched.Id);
            Assert.Equal(employeeExpected.Name, employeeFetched.Name);
            Assert.Equal(employeeExpected.Salary, employeeFetched.Salary);
        }

        [Then(@"null is returned")]
        public void ThenNullIsReturned()
        {
            Assert.Null(context.responseGetInvalid.Data);

        }
    }
}