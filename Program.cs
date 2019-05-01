#define DEBUG
#define version1
// #undef DEBUG

using System;
using Services;
namespace c_
{

    class Swap
    {
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

    /// <summary>
    /// hello world class
    /// </summary>
    class Program 
    {

        /// <summary>
        ///  entry point 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {

            #region Input
            int a = 10;
            int b = 20;

            Swap obj = new Swap();
            obj.swap(ref a, ref b);

            System.Console.WriteLine(" a == {0}, b == {1}",a,b);

            


                #if(DEBUG && !version1)
                    System.Console.WriteLine("debug mode");
                #elif(DEBUG && version1)
                    Console.WriteLine("this is version 1 debugging in action!");
                #else
                    System.Console.WriteLine("relaese mode");    
                #endif


                
            
            
            #endregion
            

            

        }
    }
}