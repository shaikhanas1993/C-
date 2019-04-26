using System;
namespace Services
{
    class PArray
    {
         public int GetSum(params int[] arr)
         {
            int sum = 0;
             foreach (var item in arr)
             {
                 sum  = sum  + item;
             }

             return sum;
         }   
    }
}