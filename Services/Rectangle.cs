using System;

namespace Services 
{
    class Rectangle
    {
        double length;
        double width;

        public  Rectangle(){
            this.length = 4.5;
            this.width = 10;
        }

        public void PrintCalculatedArea(){
            Console.WriteLine("{0}" , this.length * this.width);
        }

    }
}