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

    abstract class Shape
    {
        abstract public int GetArea(int area);
    }

    class Rectangle: Shape{
        public override int GetArea(int area){
            return area * 10;
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {

           var obj = new Rectangle();
           int sum = obj.GetArea(10);
           Console.WriteLine(sum);

            // var obj = new PrintData();
            // obj.print(10);
            // obj.print(10.2);
            // obj.print("10");
        }
    }
}