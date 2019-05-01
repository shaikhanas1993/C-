


using System;
using Services;
namespace c_
{

    class TestException:Exception
    {
        public TestException(string message):base(message){}
        
    }

    class Test
    {
        #pragma warning disable 169, 414
        int a = 0;
                public void ShowTemperature()
        {
           
            if(a == 0)
            {
                try
                {
                    throw(new TestException("test excepion"));
                }
                 
                catch (System.Exception e)
                {
                    
                    System.Console.WriteLine(e.Message);
                }
            }
        }
    }

    class Program 
    {

        static void Main(string[] args) 
        {
            var obj = new Test();
            obj.ShowTemperature();
        }
    }
}