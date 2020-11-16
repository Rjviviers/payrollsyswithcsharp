using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procject1
{
    class Employee:Person
    {
        List<Employee> Emps = new List<Employee>();
        List<Employee> EmpsTime = new List<Employee>();
        public Employee(string JobcodeP, string nameP, double PayrateP)
            : base(JobcodeP, nameP, PayrateP)
        {

        }
        public Employee(string NameP, double HoursWorkedP) 
            :base(NameP , HoursWorkedP)
        {

        }
        public Employee(string JobcodeP, string nameP, double PayrateP, double HoursWorkedP)
            :base( JobcodeP,  nameP,  PayrateP,  HoursWorkedP)
        {

        }
        public Employee()
        {

        }
        
        public List<Employee> ReadEmployee()
        {
            FileHandler fa = new FileHandler();
            foreach (string item in fa.ReadData("EmployeeList.txt"))
            {
                string[] splitter = item.Split(',');
                string emptype = splitter[0];
                string empName = splitter[1];
                double empPayrate = Convert.ToDouble(splitter[2]);

                Emps.Add(new Employee(emptype, empName, empPayrate));
            }
            return Emps;
        }
        public List<Employee> ReadTimeSheet()
        {
            FileHandler fa = new FileHandler();
            foreach (var item in fa.ReadData("TimeSheet.txt"))
            {
                string[] splitter = item.Split(',');
                string empName = splitter[0];
                double empHours = Convert.ToDouble(splitter[1]);

                EmpsTime.Add(new Employee(empName, empHours));
            }
            return EmpsTime;

        }
        List<Employee> FullEmpList = new List<Employee>();

        public List<Employee> GetTimeandEmp()
        {
            Employee e = new Employee();
            List<Employee> read =new List<Employee>();
            List<Employee> t =new List<Employee>();
            read = e.ReadEmployee();
            t = e.ReadTimeSheet();
            foreach (var emp in read)
            {
                foreach (var time in    t )
                {
                    if (emp.name == time.name)
                    {
                        FullEmpList.Add(new Employee(emp.jobcode, emp.name,emp.payrate, time.hoursworked));
                    }
                }
            }
            return FullEmpList;
        }
        public  double CalculatePay()
        {
            throw new NotImplementedException();
        }
    }
}
