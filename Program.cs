using System;
using System.Collections.Generic;
using Services;
namespace c_
{

    // [AttributeUsage(AttributeTargets.All)]
    // class HelpAttribute : System.Attribute
    // {
    //     private readonly string url;
    //     public string topic {get;set;}

    //     public HelpAttribute(string url)
    //     {
    //         this.url = url;
    //     }
    // }

    // [HelpAttribute("This is Test")]
    // class MyClass
    // {
        
    // }

    // [AttributeUsage(AttributeTargets.All,AllowMultiple = true)]
    // class DebugInfo : System.Attribute
    // {
    //     private int bugNo;
    //     private string developer;
    //     private string lastReview;

    //     public string messsage {get;set;}

    //     public DebugInfo(int bugNo,string developer,string lastReview)
    //     {
    //         this.bugNo = bugNo;
    //         this.developer = developer;
    //         this.lastReview = lastReview;
    //     }

    //     public int BugNo
    //     {
    //         get
    //         {
    //             return this.bugNo;
    //         }
    //     }

    //     public string Developer 
    //     {
    //         get 
    //         {
    //              return this.developer; 
    //         }
    //     }
    //     public string LastReview 
    //     {
    //         get
    //         {
    //             return this.lastReview;
    //         }
    //     }

    // }

    // [DebugInfo(1,"ab","1")]
    // [DebugInfo(1,"cd","4")]
    // class Test
    // {
    //     private int a,b;

    //     public Test(int a, int b)
    //     {
    //         this.a = a;
    //         this.b = b;
    //     }

    //      [DebugInfo(1,"eff","5",messsage = "testing")]
    //     public int add()
    //     {
    //         return a + b;
    //     }

    // }

/// <summary>
///     Cookie Class to set and get dictionary
/// </summary>
    public class Cookie
    {
        private readonly Dictionary<string,string> _dictionary;
        public DateTime expiry { get; set; }    
        public Cookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        /// <summary>
        ///   indexer for cookie class
        /// </summary>
        /// <value></value>
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

        static void Main(string[] args) 
        {

            Cookie cookie = new Cookie();
            cookie["name"] = "anas";
            Console.WriteLine("name of cookie :: {0}" , cookie["name"]);

            // Type type = typeof(Test);
            //  var listOfCustomAttributes = type.GetCustomAttributes(false);
            //  foreach (var item in listOfCustomAttributes)
            //  {
            //      var dbi = item as DebugInfo;
            //      if(dbi != null)
            //      {
            //          Console.WriteLine("BugNo :: {0}", dbi.BugNo);
            //          Console.WriteLine("");
            //      }
            //  }


            // System.Reflection.MemberInfo info =  typeof(MyClass);
            // object[] listOfAttributes = info.GetCustomAttributes(true);
            // foreach (var item in listOfAttributes)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }
}