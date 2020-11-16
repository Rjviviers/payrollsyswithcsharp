using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procject1
{
   public class MarketingEmp : Person
    {
        List<MarketingEmp> mkt = new List<MarketingEmp>();

        double Weekpay;
        //private double Overtime;
        private int Sales;
        public int sales
        {
            get { return Sales; }
            set { Sales = value; }
        }
        public MarketingEmp(string NameP, double PayRateP, double HoursWorkedP, string JobCodeP, int SalesP)
            : base( NameP,  PayRateP,  HoursWorkedP,  JobCodeP)
        {
           // this.Overtime = OvertimeP;
            this.Sales = SalesP;

        }
        public MarketingEmp(string NameP, int SalesP):base(NameP)
        {
            this.Sales = SalesP;

        }
        public MarketingEmp()
        {

        }
        
        
        //public double overtime
        //{
        //    get { return Overtime; }
        //    set { Overtime = value; }
        //}

        public  double CalculatePay(double hoursworked,double payrate)
        {
            if (hoursworked > 40)
            {
                Weekpay = hoursworked * 40;
                double temp = hoursworked - 40;
                Weekpay = Weekpay * ((temp * payrate) * 1.5);
            }
            else
            {
                Weekpay = hoursworked * payrate;

            }

            if (Sales >= 2)
            {
                Weekpay = Weekpay + 250;

            }
            else
            {
                Weekpay = Weekpay + 100;
            }

            return Weekpay;
            
        }
        
        List<MarketingEmp> MarketList = new List<MarketingEmp>();
        public List<MarketingEmp> GetSalesStaff()       
        {
            FileHandler fa = new FileHandler();
            foreach (var item in fa.ReadData("TMarketList.txt"))
	        {
                string[] spliter = item.Split(',');
                MarketList.Add(new MarketingEmp(spliter[0], Convert.ToDouble(spliter[1]), Convert.ToDouble(spliter[2]), spliter[3], Convert.ToInt32(spliter[4])));
	        }
            return MarketList;
        }
        List<MarketingEmp> selectedlist = new List<MarketingEmp>();
        public List<MarketingEmp> selectthis(string selected )
        {
            //string PrepareForTrouble =""; 
            //Convert.ToDouble(PrepareForTrouble);
            foreach (var item in GetSalesStaff())
            {
                if (item.name == selected)
                {
                    selectedlist.Add(new MarketingEmp(item.name, item.hoursworked, item.payrate, item.jobcode, item.sales));

                }
               

            }


            return selectedlist;
        }
        
    }
}
