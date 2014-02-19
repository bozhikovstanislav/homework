using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        public Worker(string firstaname,string lastname,decimal weakSalary,decimal workHouersperDay)
            : base(firstaname,lastname)
        {
            this.workHoursPerDay = workHouersperDay;
            this.weekSalary = weakSalary;
        }
        public decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (weekSalary < 0)
                {
                    throw new ArgumentException("Give some money to worker");
                }
                weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return workHoursPerDay;
                
            }
            set
            {
                if (workHoursPerDay < 0)
                {
                    throw new ArgumentException("Worker is doing your job pleas set to him corect hour");
                }
                this.WorkHoursPerDay=value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal weackSalary =decimal.Parse(WeekSalary.ToString());
            decimal hoursalary=Math.Round((weackSalary/workHoursPerDay)/168,2);
            return hoursalary ;
        }
    }
}
