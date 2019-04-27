using System;
using Services;
namespace c_
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Rec obj = new Rec(10,10);
            double area = obj.getArea();
            System.Console.WriteLine(area);
        }
    }
}