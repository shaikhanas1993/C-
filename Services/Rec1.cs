using System;
namespace Services
{
    class Rec1
    {
        protected double width;
        protected double height;

        public Rec1(double width,double height){
            this.width = width;
            this.height = height;
        }

        public double getArea(){
            return width * height;
        }

   }
}