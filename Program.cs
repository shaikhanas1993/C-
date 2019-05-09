using System;
using System.Collections.Generic;
using Services;
namespace c_
{
    /// <summary>
    /// Event Publisher Class
    /// </summary>
    class PrintHelper
    {
        public delegate void BeforePrint();
        public event BeforePrint beforePrintEvent;

        public PrintHelper(){}

        public void PrintNumber()
        {
            if(beforePrintEvent != null)
            {
                beforePrintEvent();
            }

            Console.WriteLine("Printing Number");
        }

        public void PrintMoney()
        {
            if(beforePrintEvent != null)
            {
               
                //Event publisher or raiser
                beforePrintEvent.Invoke();
            }

            Console.WriteLine("printing Money");
        }

        public void PrintCode()
        {
            if(beforePrintEvent != null)
            {
                beforePrintEvent.Invoke();
            }

            Console.WriteLine("Printing Code");
        }
   }
    
    

    /// <summary>
    ///    Event Subscriber 
    /// </summary>
   class Number
   {
       private PrintHelper _printHelper;
       private int _value;

       public Number(int value)
       {
           _value = value;
           _printHelper =  new PrintHelper();
          
          
           _printHelper.beforePrintEvent += beforePrintEventHandler;
       } 

       /**
        *    Event Handler
        */ 
       public void beforePrintEventHandler()
       {
           Console.WriteLine("i am event handler");
       }


        public int Value
        {
            get { return _value; } 
            set { _value = value;} 
        } 

        public void PrintMoney()
        {
            _printHelper.PrintMoney();
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber();
        }

   }



    class Program 
    {

        static void Main(string[] args) 
        {
            Number number = new Number(5);
            number.PrintMoney();
            number.PrintNumber();
        }

    }

}