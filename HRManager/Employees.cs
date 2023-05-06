using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    public abstract class Employees
    {
        public int empID { get; set; }
        public string empName { get; set; }
        public DateTime dob { get; set; }
        public string department { get; set; }
        public int numWork { get; set; }

        public Employees() { }
        public Employees(int empID, string empName, DateTime dob, string department, int numWork)
        {
            this.empID = empID;
            this.empName = empName;
            this.dob = dob;
            this.department = department;
            this.numWork = numWork;
        }
        public void Input()
        {
            Console.WriteLine("Enter employee ID: ");
            empID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee name: ");
            empName = Console.ReadLine();

            Console.WriteLine("Enter date of birth (dd/MM/yyyy): ");
            dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter department: ");
            department = Console.ReadLine();

            Console.WriteLine("Enter number of years worked: ");
            numWork = int.Parse(Console.ReadLine());
        }
        public void DisplayDetail()
        {
            Console.WriteLine("Employee ID: " + empID);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Date of Birth: " + dob.ToString("dd/MM/yyyy"));
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Number of years worked: " + numWork);
        } 
            public abstract double CalculateSalary();
       }
}
