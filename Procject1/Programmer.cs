using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procject1
{
    class Programmer:Person
    {
        List<Programmer> prg = new List<Programmer>();
        double Weekpay = 0.0;
        private string PStatus;

        public string pStatus
        {
            get { return PStatus; }
            set { PStatus = value; }
        }
        public Programmer(string NameP, double PayRateP, double HoursWorkedP, string JobCodeP, string PStatusP)
            : base( NameP,  PayRateP,  HoursWorkedP,  JobCodeP)
        {
            this.PStatus = PStatusP;
        }
        public Programmer(string NameP, string PStatusP)
            : base(NameP)
        {
            this.PStatus = PStatusP;

        }
        public Programmer()
        {

        }
        public double CalculatePay(double hoursworked, double payrate, string pStatus)
        {
            if (pStatus.ToUpper() == "AHEAD")
            {
                Weekpay = payrate * hoursworked;
                Weekpay = Weekpay + 300;
               
            }
            else
            {
                Weekpay = payrate * hoursworked;
            }
            return Weekpay;

        }
       
        List<Programmer> Programer = new List<Programmer>();
        public List<Programmer> GetProgrammer()
        {
            FileHandler fa = new FileHandler();
            foreach (var item in fa.ReadData("TPogrammerList.txt"))
            {
                string[] splitter = item.Split(',');
                Programer.Add(new Programmer(splitter[0], Convert.ToDouble(splitter[1]), Convert.ToDouble(splitter[2]), splitter[3], splitter[4]));
            }

            return Programer;
         }
        
    }
}
