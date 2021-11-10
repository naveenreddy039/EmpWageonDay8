using System;

namespace UC2Emp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int IsFullTime = 1;
                int EmpRatePerHr = 20;
                int empHrs = 0;
                int EmpWage = 0;
                Random random = new Random();
                int empCheck = random.Next(1, 2);
                if (empCheck == IsFullTime)
                {
                    empHrs = 8;
                }
                else
                {
                    empHrs = 0;
                }
                EmpWage = empHrs * EmpRatePerHr;
                Console.WriteLine(EmpWage);
            }
            catch
            {
                Console.WriteLine("Absent");
            }
        }
    }
}
