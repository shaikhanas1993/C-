using System;
using Services;
namespace c_
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Rec obj = new Rec(10,10);
            // // double area = obj.getArea();
            // // System.Console.WriteLine(area);
            // Mas obj = new Mas(10,10);
            // Console.WriteLine(obj.getCost());

            TestP obj = new TestP();
            obj.setWidth(10);
            obj.setHeight(10);
            int sum = obj.GetCost(10);
            Console.WriteLine(sum);

        }
    }
}