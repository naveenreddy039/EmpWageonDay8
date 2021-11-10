using System;

namespace UC7Emp
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int maxHrsInMonth = 100;
        public const int maxDaysInMonth = 20;
        public const int maxRatePerDay = 20;
        

        public static int empWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays <= maxDaysInMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(1, 2);
                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalWorkingDays = empHrs + totalEmpHrs;
                Console.WriteLine("Days" + totalWorkingDays + " Emp Hrs " + empHrs);
                
            }
            int totalEmpWage = totalWorkingDays * maxRatePerDay;
            Console.WriteLine(" Total Emp Wage:"+totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            empWage();
        }
    }
}
