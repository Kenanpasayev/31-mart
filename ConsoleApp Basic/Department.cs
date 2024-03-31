using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp_Basic
{
    internal class Department
    {
        Employee[] Employees;
        public Department(Employee[]employees)
        {
            Employees = new Employee[0];
        }
        public void AddEmployee(Employee employee)
        {
           Employee[] employees=new Employee[Employees.Length+1];

            for (int i=0;i<Employees.Length;i++)
            {
                employees[i] =Employees[i];
            }
            employees[Employees.Length] = employee;
        }
        public void ShowEmployeeInfo()
        {
            foreach (var item in Employees) 
            {
                Console.WriteLine(item);
                Console.WriteLine("Employee information");
            }
        }
        public  void GetAllEmployees(string name) 
        {
           foreach(Employee employee in Employees) 
            {
                if (employee.Name == name)
                {
                    Console.WriteLine(employee.Name);
                }
            }
            
        }
  
    }

}