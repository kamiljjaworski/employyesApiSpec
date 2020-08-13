using RestAPI.Spec.Models;

namespace EmployeesApiSpec.Steps
{
    public class Context
    {
        public readonly EmployeeApiClient employeeApiClient = new EmployeeApiClient();

        public ResponseAddGetUpdate responseAddGetUpdate;
        public ResponseDelete responseDelete;
        public ResponseGet responseGet;
        public ResponseGetInvalid responseGetInvalid;
        public Employee employeeToBeModified;
        public Employee employeeModified;
        public Employee employee;
    }
}
