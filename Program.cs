using System;
using Services;
namespace c_
{

    [AttributeUsage(AttributeTargets.All)]
    class HelpAttribute : System.Attribute
    {
        private readonly string url;
        public string topic {get;set;}

        public HelpAttribute(string url)
        {
            this.url = url;
        }
    }

    [HelpAttribute("This is Test")]
    class MyClass
    {
        
    }

    class Program 
    {

        static void Main(string[] args) 
        {
            System.Reflection.MemberInfo info =  typeof(MyClass);
            object[] listOfAttributes = info.GetCustomAttributes(true);
            foreach (var item in listOfAttributes)
            {
                Console.WriteLine(item);
            }
        }
    }
}