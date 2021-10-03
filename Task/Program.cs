using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Include count of array elements:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Array elements:");
            int[] Myarr =new int[n];        
            for(int i = 0; i < n; i++)
            {
                Myarr[i]=int.Parse(Console.ReadLine());
            }
            Result r1 = new Result(Myarr);
            r1.Find(Myarr);
        }
    }
}
