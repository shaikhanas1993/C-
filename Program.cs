using System;
using Services;
namespace c_
{

    class PrintData 
    {
        public void print(int a){
            System.Console.WriteLine(a);
        }

        public void print(float a){
            System.Console.WriteLine(a);
        }

        public void print(double a){
            System.Console.WriteLine(a);
        }

        public void print(string a){
            System.Console.WriteLine(a);
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            
            var obj = new PrintData();
            obj.print(10);
            obj.print(10.2);
            obj.print("10");
        }
    }
}