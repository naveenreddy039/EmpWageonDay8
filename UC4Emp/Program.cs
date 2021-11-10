using System;

namespace UC4Emp
{
    public class Program
    {
        public const int IsFullTime = 1;
        public const int IsPartTime = 2;
        public const int EmpRatePerHr = 20;
        public static void Main(string[] args)
        {
            
            try
            {
                int empHrs = 0;
                int EmpWage = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch(empCheck)
                {
                    case IsPartTime:
                        empHrs = 8;
                        break;
                    case IsFullTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                EmpWage = empHrs * EmpRatePerHr;
                Console.WriteLine("employe wage" + EmpWage);
            }
            catch
            {
                Console.WriteLine("Employee is Parttime");
            }
        }
    }
}
