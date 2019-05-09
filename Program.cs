using System;
using System.Collections.Generic;
using Services;
namespace c_
{
    
    /// <summary>
    ///     Publisher Class
    /// </summary>
    class Publisher
    {
        public delegate void beforePrint(string message);
        public event beforePrint beforePrintEvent;

        public Publisher(){}

        public void printNumber()
        {
            if(beforePrintEvent != null)
            {
                beforePrintEvent.Invoke("Print Number");
            }
        }

    }

    class Subscriber
    {
       private Publisher _publisher;

       public Subscriber()
       {
          _publisher = new Publisher();
          _publisher.beforePrintEvent += myEventHandler;
          _publisher.beforePrintEvent += myEventHandler1; 
       } 

       public void myEventHandler(string message)
       {
           Console.WriteLine(message);
       }

       public void myEventHandler1(string message)
       {
           Console.WriteLine(message);
       }

       public void PrintNumber()
       {
           _publisher.printNumber();
       } 
       

    }


    class Program 
    {

        static void Main(string[] args) 
        {
           var obj = new Subscriber();
           obj.PrintNumber();
        }

    }

}