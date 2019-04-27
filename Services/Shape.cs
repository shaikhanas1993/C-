using System;
namespace Services
{
    class Shape
    {
        protected int height;
        protected int width;

        public Shape(int height,int width){
            this.height = height;
            this.width = width;
        }
        public int getArea(){
            return height * width;
        }
    }
}