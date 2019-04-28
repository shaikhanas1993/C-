using System;
using Services;
namespace c_
{
    public interface ITransaction
    {

        void ShowTransaction();
        double GetAmount();
    }

    class Test : ITransaction
    {

        public int a {get;set;}
        public int b {get;set;}

        public Test()
        {
        }

        public Test(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public double GetAmount()
        {
            return a*b;
        }

        public void ShowTransaction()
        {
            System.Console.WriteLine("a == {0} , b == {1}",a,b);
        }
    }


    class Program 
    {
        static void Main(string[] args) 
        {
            ITransaction obj = new Test(5,5);
            Test t = (Test) obj;
            System.Console.WriteLine(obj.GetAmount());
            obj.ShowTransaction();
        }
    }
}