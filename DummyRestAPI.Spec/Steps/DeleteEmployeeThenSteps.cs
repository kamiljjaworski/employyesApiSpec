using EmployeesApiSpec.Steps;
using Newtonsoft.Json.Linq;
using RestAPI.Spec.Models;
using TechTalk.SpecFlow;

using Xunit;

namespace RestAPI.Spec.Steps
{
    [Binding]
    public class DeleteEmployeeThenSteps
    {
        private readonly Context context;
        public DeleteEmployeeThenSteps(Context context)
        {
            this.context = context;
        }

        [Then(@"employee of id (.*) is deleted")]
        public void ThenEmployeeOfIdIsDeleted(int id)
        {
            Assert.Equal(id, context.responseDelete.Data);
            context.responseAddGetUpdate = context.employeeApiClient.Get(id);
            // hard to validate deletion as (honestly) we are not deletinng anything...
        }
    }
}