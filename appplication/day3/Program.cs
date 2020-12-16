using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Location { get; set; }
        public Employee getemployeedeatils(int id,string name,string desig,string loc)
        {
            Employee emp = new Employee();
            emp.Id = id;
            emp.Name = name;
            emp.Designation = desig;
            emp.Location = loc;
            return emp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee emp1 = employee.getemployeedeatils(1, "peter", "mech engn", "pune");
            Console.WriteLine("employee details\n----------");
            Console.WriteLine($"id={ emp1.Id} \n name = {emp1.Name}\n designation = {emp1.Designation}\n Location ={emp1.Location}");
            Console.ReadLine();
        }
    }
}
