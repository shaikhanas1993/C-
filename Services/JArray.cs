using System;
namespace Services
{
    class JArray
    {
        private int[][][] m = new int[][][]{
            new int[][]{
                new int[]{1}
            },
            new int[][]{
                new int[]{3,4}
            },
            new int[][]{
                new int[]{3,4}
            },
            new int[][]{
                new int[]{4,6}
            }
        };

        public void printArray(){
            foreach (var item in m)
            {
                foreach (var item1 in item)
                {
                    foreach (var item2 in item1)
                    {
                        System.Console.WriteLine(item2);
                    }

                }
            }
        }


    }
}