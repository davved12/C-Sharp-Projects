using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    class Employee
    {
        private int employeeNumb;
        private string name;
        private string address;
        private double wage;
        private double hours;
        private string filename;

       
        public Employee(int employeeN,string nam, string add, double hourly, double hour)
        {
            employeeNumb = employeeN;
            name = nam;
            address = add;
            wage = hourly;
            hours = hour;   
        }

        public int GetEmployeeNumber()
        {
            return employeeNumb;
        }
        public void SetEmployeeNumber(int employee)
        {
            employeeNumb = employee;
        }
        public string GetName()
        {
            return name;
        }
        public void SetEmpolyeeName(string n)
        {
            name = n;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string a)
        {
            address = a;
        }
        public double GetWage()
        {
            return wage;
        }
        public void SetWage(double w)
        {
            wage = w; 
        }
        public double GetHoursWorked()
        {
            return hours;
        }
        public void SetHoursWorked(double h)
        {
            hours = h;
        }
        public string GetFileName()
        {
            
            return filename;
        }
        public void SetFileName(string f)
        {
            filename = f;
        }
      
        public double CalcPay(double hour, double wage)
        {
            double netPay;
            double state = .075;
            double federal = .2;
            double totalState = 0;
            double totalFed = 0;
            double timeHalf = GetWage() *1.5;
            double overtime = ((GetHoursWorked() - 40) * timeHalf);

            totalState = (GetHoursWorked() * GetWage()) * state;
            totalFed = (GetHoursWorked() * GetWage()) * federal;
            double totaldeducation = totalState + totalFed;

            if(GetHoursWorked() > 40)
            {
                netPay = (overtime + (40 * GetWage())) - totaldeducation;
                return netPay;
            }
            netPay = (GetHoursWorked() * GetWage()) - totalFed - totalState;
            return netPay;
        }

    }
}
