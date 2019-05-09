using System;
using System.Collections.Generic;
using Services;
namespace c_
{
    
    // /// <summary>
    // ///     Publisher Class
    // /// </summary>
    // class Publisher
    // {
    //     public delegate void beforePrint(string message);
    //     public event beforePrint beforePrintEvent;

    //     public Publisher(){}

    //     public void printNumber()
    //     {
    //         if(beforePrintEvent != null)
    //         {
    //             beforePrintEvent.Invoke("Print Number");
    //         }
    //     }

    // }

    // class Subscriber
    // {
    //    private Publisher _publisher;

    //    public Subscriber()
    //    {
    //       _publisher = new Publisher();
    //       _publisher.beforePrintEvent += myEventHandler;
    //       _publisher.beforePrintEvent += myEventHandler1; 
    //    } 

    //    public void myEventHandler(string message)
    //    {
    //        Console.WriteLine(message);
    //    }

    //    public void myEventHandler1(string message)
    //    {
    //        Console.WriteLine(message);
    //    }

    //    public void PrintNumber()
    //    {
    //        _publisher.printNumber();
    //    } 
       

    // }


    public delegate void Print(int value);


    class Program 
    {
        // public delegate void Print();

        // public delegate void PrintNumber(int number);

        // public delegate void PrintLoop();
        // const int  size = 10;

        static void PrintHelperMethod(Print print,int value)
        {
            value = value + 10;
            print(value);
        }

        static void Main(string[] args) 
        {
            PrintHelperMethod(delegate(int value){ Console.WriteLine("value == {0}",value);},10);
            
        //     Print p = delegate(){
        //         Console.WriteLine("hello world");
        //     };

        //     PrintNumber printNumber = delegate(int number){
        //         Console.WriteLine("number :: {0}",number);
        //     };

        //     PrintLoop printLoop = delegate()
        //     {
        //         for(int i = 0; i< size ; i++){
        //             Console.WriteLine(i);
        //         }
        //     };

        //    printLoop();
        }

    }

}