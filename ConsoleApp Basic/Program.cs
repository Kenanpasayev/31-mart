using ConsoleApp_Basic;
using System.ComponentModel;
using System.Threading.Channels;
namespace ConsoleApp_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool exit =false;
            do
            {
                Console.WriteLine("Hello");
                Console.WriteLine("Please choose if you don't mind");
                Console.WriteLine("1.Add employee");
                Console.WriteLine("2.Show all employee");
                Console.WriteLine("0.End the program");
                string input = Console.ReadLine();
                Employee employee= new Employee();  
                Employee[] employees = new Employee[0];
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Employee information:");
                        Employee.employee = CreateEmployee();
                        string name = Console.ReadLine();
                        break;
                    case "2": Department department=new Department(employees);
                        department.ShowEmployeeInfo();
                        break;
                    case "0": exit = true;
                        break;
                        default:
                        Console.WriteLine("Choose the correct");
                        break;
                }
            } while (exit!=true);
        }
      
        public static Employee CreateEmployee()  
        {
            Employee employee = new Employee();
            Console.WriteLine("employee's name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("employee's surname");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("employee's age");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("employee's salary");
            employee.Salary= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("department name");
            employee.DeparmentName = Console.ReadLine();

            return employee;
        }
       
    }
}
