using System;
using System.Collections.Generic;
using Services;
namespace c_
{
    public delegate void Print();

    class Test
    {
        public void printNumber()
        {
            Console.WriteLine("i am printing number");
        }

        public void printZero()
        {
            Console.WriteLine("i am printing zero");
        }
    }

    class Program 
    {

        static void Main(string[] args) 
        {
            Test test = new Test();
            Print obj = test.printNumber;
                  obj += test.printZero;  
          
            obj();
        }

    }

}