using System;
namespace findPrime
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Starting Number: ");
            int startNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Ending Number : ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between {startNumber} and {endNumber} are : ");

            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;

                for (int k = 2; k <= i / 2; k++)
                {
                    if (i % k == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}