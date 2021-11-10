using System;

namespace EmpWageOnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int IsFullTime = 1;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if(empCheck==IsFullTime)
                {
                    Console.WriteLine("Employee is Present");
                }
                else
                {
                    Console.WriteLine("Employee is absent");
                }
            }
            catch
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
