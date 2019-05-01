using System;
using Services;
namespace c_
{
    // public interface ITransaction
    // {

    //     void ShowTransaction();
    //     double GetAmount();
    // }

    // class Test : ITransaction
    // {

    //     public int a {get;set;}
    //     public int b {get;set;}

    //     public Test()
    //     {
    //     }

    //     public Test(int a, int b)
    //     {
    //         this.a = a;
    //         this.b = b;
    //     }
    //     public double GetAmount()
    //     {
    //         return a*b;
    //     }

    //     public void ShowTransaction()
    //     {
    //         System.Console.WriteLine("a == {0} , b == {1}",a,b);
    //     }
    // }


    namespace c1
    {
        class Add 
        {
            public int add(int a ,int b){
                return a + b; 
            }
        }
    }

     namespace c2
    {
        class Add 
        {
            public int add(int a ,int b){
                return a + b + b; 
            }
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            var obj1 = new c1.Add();
            var obj2 = new c2.Add();
            System.Console.WriteLine(obj1.add(5,6));

            System.Console.WriteLine(obj2.add(5,6));      
        }
    }
}