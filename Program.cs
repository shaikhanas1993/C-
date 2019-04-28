using System;
using Services;
namespace c_
{

    // class PrintData 
    // {
    //     public void print(int a){
    //         System.Console.WriteLine(a);
    //     }

    //     public void print(float a){
    //         System.Console.WriteLine(a);
    //     }

    //     public void print(double a){
    //         System.Console.WriteLine(a);
    //     }

    //     public void print(string a){
    //         System.Console.WriteLine(a);
    //     }
    // }

    // abstract class Shape
    // {
    //     public abstract  int GetArea(int area);
    // }

    // class Rectangle: Shape{
    //     public override int GetArea(int area){
    //         return area * 10;
    //     }
    // }


    // class Subject
    // {
    //     virtual 
    // }

    class Shape
    {
        protected int width,height;

        public Shape(int width,int height){
            this.width = width;
            this.height = height;
        }

        public virtual int getArea(){
            return 0;
        }
    
    
    }

    class Rectangle : Shape
    {
        public Rectangle(int width,int height):base(width,height){}
        public override int getArea(){
            return width * height;
        }
    }

    class Triangle : Shape
    {
        public Triangle(int width,int height):base(width,height){}
        public override int getArea(){
            return (width * height)/2;
        }
    }

    class Caller
    {
        public void CallArea(Shape obj)
        {
            System.Console.WriteLine(obj.getArea())  ;
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {

            Caller obj = new Caller();
            Rectangle rec = new Rectangle(10,10);
            Triangle tri = new Triangle(10,10);

            obj.CallArea(rec);
            obj.CallArea(tri);

        //    var obj = new Rectangle();
        //    int sum = obj.GetArea(10);
        //    Console.WriteLine(sum);

            // var obj = new PrintData();
            // obj.print(10);
            // obj.print(10.2);
            // obj.print("10");
        }
    }
}