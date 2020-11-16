using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procject1
{
    class GeneralEmp :Person
    {
        List<GeneralEmp> GeneralEmplist = new List<GeneralEmp>();
        
        double WeekPay;
       // private int Overtime;

        public GeneralEmp(string NameP, double PayRateP, double HoursWorkedP, string JobCodeP)
            :base( NameP,  PayRateP,  HoursWorkedP,  JobCodeP)
        {
           // this.Overtime = OvertimeP;
        }
        public GeneralEmp()
        {

        }

        //public int overtime
        //{
        //    get { return Overtime; }
        //    set { Overtime = value; }
        //}

        public double CalculatePay(double hoursworked, double payrate)
        {
            if (hoursworked > 40)
            {
                WeekPay = hoursworked * 40 ;
                double temp = hoursworked - 40;
                WeekPay = WeekPay * ((temp * payrate) * 1.5);
            }
            else
            {
                WeekPay = hoursworked * payrate;

            }
            return WeekPay;

        }
        

        public List<GeneralEmp> GetGeneral()
        {
            FileHandler fa = new FileHandler();
            foreach (var item in fa.ReadData("TGeneral.txt"))
            {
                string[] spliter = item.Split(',');
                GeneralEmplist.Add(new GeneralEmp(spliter[0],Convert.ToDouble(spliter[1]),Convert.ToDouble(spliter[2]),spliter[3]));
            }
            return GeneralEmplist;
        }
    }
}
