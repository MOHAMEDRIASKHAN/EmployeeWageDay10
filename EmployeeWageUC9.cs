using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageUC9
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int TotalEmpWage;

        public EmployeeWageUC9(string company, int empRatePerHour, int NumOfWorkingDays, int MaxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
             public void computeEmpWage()
            {
            int emphrs = 0;
            int totalEmphrs = 0;
            int totalWorkingDays = 0;

            while (totalEmphrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(2);
                switch (empcheck)
                {
                    case is_part_time:
                        emphrs = 4;
                        break;
                    case is_full_time:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                totalEmphrs += emphrs;
                Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs :" + emphrs);
            }
            TotalEmpWage = totalEmphrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company : " + company + "is :" + TotalEmpWage);
        }
        public string tostring()
        {
            return "Total Emp Wage for Company : " + this.company + "is : " + this.TotalEmpWage;
        }
        }
    }

