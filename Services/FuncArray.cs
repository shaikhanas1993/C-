using System;
namespace Services
{
    class FuncArray
    {
        public void printArray(int[] arr){
            foreach (var item in arr)
            {
                Console.WriteLine(item);                
            }
        }
    }
}