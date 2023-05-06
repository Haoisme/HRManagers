using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    internal class TemporaryEmp : Employees
    {
        private double workDay;

        public TemporaryEmp(int empId, string empName, DateTime dob, string department, int numWork, double WorkDay)
        {
            this.empID = empId;
            this.empName = empName;
            this.dob = dob;
            this.department = department;
            this.numWork = numWork;
            this.workDay = workDay;
               
        }

        public override double CalculateSalary()
        {
            if (workDay <= 25)
            {
                return workDay * 50000;
            }
            else if(workDay >= 25)
            {
                return 25 * 50000+(workDay-25)*50000*2;
            }
            else
            {
                return CalculateSalary();
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Enter number of work days: ");
            workDay = int.Parse(Console.ReadLine()); 
        }
        public override void DisplayDetail()
        {
            base.DisplayDetail(); 
            Console.WriteLine("Number of work days: " + workDay); 
        }
    }
}
