using System;

namespace UC5
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int WorkingDayPerMonth = 20;
        static void Main(string[] args)
        {

            try
            {
                int empHrs = 0;
                int empWagePerMonth = 0;
                Random random = new Random();
                int empCheck = random.Next(1, 2);
                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 8;
                        break;
                    case isFullTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWagePerMonth = empHrs * WorkingDayPerMonth;
                Console.WriteLine(empWagePerMonth);
            }
            catch
            {
                Console.WriteLine("inValid wage");
            }
        }
    }
}
