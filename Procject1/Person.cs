using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procject1
{
   public abstract class Person
    {
        #region Fields
        List<Programmer> prg = new List<Programmer>();
        List<GeneralEmp> gen = new List<GeneralEmp>();
        List<MarketingEmp> mrk = new List<MarketingEmp>();

        private string Name;
        private double PayRate;
        private double HoursWorked;
        private string JobCode;
        #endregion
        #region Constructors
        public Person(string NameP, double PayRateP, double HoursWorkedP, string JobCodeP)
        {
            this.Name = NameP;
            this.PayRate = PayRateP;
            this.HoursWorked = HoursWorkedP;
            this.JobCode = JobCodeP;
        }
        public Person(string JobcodeP, string nameP, double PayrateP,double HoursWorkedP)
        {
            this.JobCode = JobcodeP;
            this.Name = nameP;
            this.PayRate = PayrateP;
            this.HoursWorked = HoursWorkedP;

        }
        public Person(string JobcodeP,string nameP,double PayrateP)
        {
            this.JobCode = JobcodeP;
            this.Name = nameP;
            this.PayRate = PayrateP;

        }
        public Person(string NameP, double HoursWorkedP)
        {
            this.Name = NameP;
            this.HoursWorked = HoursWorkedP;
        }
        public Person(string nameP)
        {
            this.Name = nameP;
        }
        public Person()
        {

        }
        #endregion
        #region Properties
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public double payrate
        {
            get { return PayRate; }
            set { PayRate = value; }
        }
        public double hoursworked
        {
            get { return HoursWorked; }
            set { HoursWorked = value; }
        }
        
        public string jobcode
        {
            get { return JobCode; }
            set { JobCode = value; }
        }
        
       
       
        
       
        #endregion

        #region methods 
        //public abstract double CalculatePay();

        public void GetLists()
        {
            FileHandler fa = new FileHandler();
            
            foreach (var item in mrk)
            {
                
            }
        }
      
        
        #endregion
    }
}
