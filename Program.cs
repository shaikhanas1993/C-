using System;
using System.Collections.Generic;
using Services;
namespace c_
{

    class Cookie
    {
        private readonly Dictionary<string,string> _dictionary;

        public Cookie()
        {
            _dictionary = new Dictionary<string, string>(); 
        }

        public string this[string key]
        {
             get
             {
                 return _dictionary[key];
             }

             set
             {
                 _dictionary[key] = value;
             }
        }
    }

    class Program 
    {

        static List<int> myList = new List<int>();

        static Program()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
        }

        static void Main(string[] args) 
        {
            // foreach (var item in RunningTotal())
            // {
            //     Console.WriteLine(item);
            // }

            // var obj = RunningTotal();

                foreach (var item in RunningTotal())
                {
                   
                    Console.WriteLine(item);
                }
        }

        static IEnumerable<int> RunningTotal()
        {
            int sum = 0;
            
            foreach (var item in myList)
            {
                sum += item;
                yield return sum;
            }
        }

    }
}