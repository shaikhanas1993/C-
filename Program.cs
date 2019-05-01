#define DEBUG
#define version1
// #undef DEBUG

using System;
using Services;
namespace c_
{
      class Program 
    {

        static void Main(string[] args) 
        {

            int a = 10;

            try
            {
                int j = a/0;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);                
            }
            finally
            {
                System.Console.WriteLine("hello world");
            
            }

            

            

        }
    }
}