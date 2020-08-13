using Newtonsoft.Json;

namespace RestAPI.Spec.Models
{
    public class Employee
    {
        [JsonProperty("id")]
        public int Id;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("age")]
        public int Age;
        [JsonProperty("salary")]
        public int Salary;
        [JsonProperty("profile_image")]
        public string ProfileImage;

        [JsonProperty("employee_name")]
        public string NameLong { set { Name = value; } }
        [JsonProperty("employee_age")]
        public int AgeLong { set { Age = value; } }
        [JsonProperty("employee_salary")]
        public int SalaryLong { set { Salary = value; } }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
