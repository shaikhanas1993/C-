using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace c_
{
   
   
    class Program 
    {
        // static async Task<int> HandleFuncAsync(){
        //         return await Task.Run(() => 5) ;
        // }

        // static void Main(String[] args){
        //     Task<int> t =   HandleFuncAsync();
        //     Console.WriteLine(t.Result);
        // }

        static int Allocate(){
             int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
            }
            return size;
        }

        static async void Example()
        {
            int t = await Task.Run(() => Allocate());
             Console.WriteLine("Compute: " + t);
        }

        static void Main()
        {
            while(true)
            {
                 Example();
                // Handle user input.
                string result = Console.ReadLine();
                Console.WriteLine("You typed: " + result);
            }
        }


    }

}