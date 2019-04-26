using System;
using Services;
namespace c_{
    class Program {
        const double pi = 3.14159;   
        static void Main(string[] args) {
                
                int[][][] arr = new int[2][][]{
                    new int[2][] {
                        new int[]{1,2},
                        new int[]{1,2},
                    },
                    new int[2][] {
                        new int[]{1,2},
                        new int[]{1,2},
                    },
                };

                foreach (var item in arr)
                {
                        foreach (var elem in item)
                        {
                            System.Console.WriteLine(elem);
                            foreach (var elem1 in elem){
                                System.Console.WriteLine(elem1);
                            }
                        }
                }



        }
    }
}   