using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageUC7
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 2;
        public const int Max_Hrs_In_Month = 10;
        public static int computeEmpWage()
        {
            int emphrs = 0;
            int totalEmphrs = 0;
            int totalWorkingDays = 0;

            while(totalEmphrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();   
                int empcheck = random.Next(2);
                switch(empcheck)
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
                Console.WriteLine("Days#:" +totalWorkingDays + "Emp Hrs :" +emphrs);
            }
            int totalEmpWage = totalEmphrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
