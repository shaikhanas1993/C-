using System;
namespace Services
{
    class MArray
    {
        private int[,,,] m = new int[1,2,2,2]{
            {
                {
                    {
                        1,2
                    },
                    {
                        3,4
                    }
                },
                {
                    {
                        5,6
                    },
                    {
                        7,8
                    }
                }
            },
            
        };

        public void PrintArray()
        {
            foreach (var item in m)
            {
                System.Console.WriteLine(item);
            }
        }

    }
}