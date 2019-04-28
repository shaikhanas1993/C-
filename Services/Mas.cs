using System;
namespace Services
{
    class Mas : Rec1
    {
        public Mas(double width,double height) : base(width,height){

        }

        public double getCost() => base.getArea() * 70;


    }
}