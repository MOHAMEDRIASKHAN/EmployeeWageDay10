using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageUC10
    {

        

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int TotalEmpWage;

        public EmployeeWageUC10(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.TotalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage fot Company : " + this.company + "is : " + this.TotalEmpWage;
        }
        public class EmpwageBuilderArray
        {
            public const int is_part_time = 1;
            public const int is_full_time = 2;

            private int numOfCompany = 0;
            private EmployeeWageUC10[] companyEmpWageArray;

            public EmpwageBuilderArray()
            {
                this.companyEmpWageArray = new EmployeeWageUC10[5];
            }

            public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                companyEmpWageArray[this.numOfCompany] = new EmployeeWageUC10(company, empRatePerHour, numOfCompany, maxHoursPerMonth);
                numOfCompany++;
            }

            public void computeEmpWage()
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].toString());
                }
            }
            private int computeEmpWage(EmployeeWageUC10 companyEmpWage)
            {
                int emphrs = 0;
                int totalEmphrs = 0;
                int totalWorkingDays = 0;

                while (totalEmphrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                return totalEmphrs * companyEmpWage.empRatePerHour;

            }
           
          
        }
    }
    }
