using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Result
    {
        public int[] Arr { get; set; }

        public Result(int[] arr)
        {
            Arr = arr;
        }
        public void Find(int[] Arr1)
        {

            int pcount=0,ncount=0,zcount=0;

            for(int i = 0; i < Arr1.Length; i++)
            {
                if (Arr1[i] == 0)
                {
                    zcount++;
                }
                else
                if (Arr1[i] > 0)
                {
                    pcount++;
                }
                else
                    ncount++;
            }
            Console.WriteLine($"Count of Positive digits:{pcount}\nCount of Negative digits:{ncount}\nCount of Zero:{zcount}"); 
        }
    }
}
