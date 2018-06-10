using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialaizerTask
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public string Email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 54,
                Name = "Ferahim",
                Age = 27,
                Email = "farahimas@code.edu.az"
            };
            Home<Employee> home = new Home<Employee>();
            home.Serialize(employee);
            Console.WriteLine("SerialaizerTask");
        }
    }
}
