using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageUC8
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;

        public static int computeEmpWage(string company, int empRatePerHour, int NumOfWorkingDays, int MaxHoursPerMonth)
        {
            int emphrs = 0;
            int totalEmphrs = 0;
            int totalWorkingDays = 0;

            while (totalEmphrs <= MaxHoursPerMonth && totalWorkingDays < NumOfWorkingDays)
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
            int totalEmpWage = totalEmphrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company " + company + "is : " +totalEmpWage);
            return totalEmpWage;
        }
    }
}
