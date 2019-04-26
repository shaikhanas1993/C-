using System;
namespace Services
{
    class AF
    {
        private int[] list = {1,2,3,4,5};
        private int[] temp = {4,5,63,6};

        public int[] SortFunc(){
            Array.Sort(list);
            return list;
        }

        public int? FindFunc(int value){
           return Array.Find(temp,elem => elem == value);
        }
    }
}