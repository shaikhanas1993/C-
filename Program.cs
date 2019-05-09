using System;
using System.Collections.Generic;
namespace c_
{
    
    class Program 
    {
        
        static void Main(string[] args) 
        {
            Nullable<int> i = null ;

            if(i.HasValue)
            {
                Console.WriteLine("has value : {0}",i);
            }
            else
            {
                Console.WriteLine("does not have value {0}",i.GetValueOrDefault());
            }

        }

    }

}