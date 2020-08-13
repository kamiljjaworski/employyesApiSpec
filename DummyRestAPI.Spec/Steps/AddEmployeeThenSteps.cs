using EmployeesApiSpec.Steps;
using TechTalk.SpecFlow;
using Xunit;

namespace RestAPI.Spec.Steps
{
    [Binding]
    public class AddEmployeeThenSteps
    {
        private readonly Context context;
        public AddEmployeeThenSteps(Context context)
        {
            this.context = context;
        }

        [Then(@"added employee can be fetched")]
        public void ThenAddedEmployeeCanBeFetched()
        {
            var employeeReturned = context.responseAddGetUpdate.Employee;
            Assert.Equal(context.employee.Name,employeeReturned.Name);
            Assert.Equal(context.employee.Age, employeeReturned.Age);
            Assert.Equal(context.employee.Salary, employeeReturned.Salary);

            context.responseAddGetUpdate = context.employeeApiClient.Get(employeeReturned.Id);
        }

        [Then(@"default employee is added")]
        public void ThenDefaultEmployeeIsAdded()
        {
            var employee = context.responseAddGetUpdate.Employee;

            Assert.Equal(0, employee.Age);
            Assert.Equal(0, employee.Salary);
            Assert.True(employee.Id > 0);
            Assert.Null(employee.Name);
        }
    }
}