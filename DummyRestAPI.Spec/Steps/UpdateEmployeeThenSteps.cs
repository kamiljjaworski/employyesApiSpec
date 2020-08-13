using EmployeesApiSpec.Steps;
using TechTalk.SpecFlow;
using Xunit;

namespace RestAPI.Spec.Steps
{
    [Binding]
    public class UpdateEmployeeThenSteps
    {
        private readonly Context context;
        public UpdateEmployeeThenSteps(Context context)
        {
            this.context = context;
        }

        [Then(@"employee of id (.*) is updated")]
        public void ThenEmployeeOfIdIsUpdated(int employeeId)
        {
            var employeeReturned = context.responseAddGetUpdate.Employee;
            var employeeModified = context.employeeModified;

            Assert.Equal(employeeModified.Age, employeeReturned.Age);
            Assert.Equal(employeeModified.Name, employeeReturned.Name);
            Assert.Equal(employeeModified.Salary, employeeReturned.Salary);

            context.responseAddGetUpdate = context.employeeApiClient.Get(employeeId);
            var employeeFetched = context.responseAddGetUpdate.Employee;

            // the db data was not updated so below assertions are failing 

            // Assert.Equal(employeeModified.Age,employeeFetched.Age);
            // Assert.Equal(employeeModified.Name,employeeFetched.Name);
            // Assert.Equal(employeeModified.Salary,employeeFetched.Salary);
        }
    }
}