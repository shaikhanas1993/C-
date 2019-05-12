using System;
using System.Collections;
using System.Collections.Generic;
namespace c_
{
   
   
    class Program 
    {
        static void Test()
        {
            ArrayList arrayList = new ArrayList();
            string str = "hello world";
            int x = 10;
            double y = 1.232;

            arrayList.Add(str);
            arrayList.Add(x);
            arrayList.Add(y);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

        }

        static void Test1()
        {
            Hashtable table = new Hashtable();
            table.Add("k1","v1");
            table.Add("k2","v2");
            table.Add("k3","v3");

            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine("key == {0} ,  value == {1}", item.Key, item.Value);
            }

        }

        static void Test3()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("k1","v1");
            sortedList.Add("k2","v2");
            sortedList.Add("k3","v3");

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("key == {0} ,  value == {1}", item.Key, item.Value);
            }

        }

        #region stack Example
        static void Test2()
        {
            Stack statck = new Stack();
            statck.Push(1);
            statck.Push(2);
            statck.Push(3);

            Console.WriteLine("Before Popping");
            foreach (var item in statck)
            {
                Console.WriteLine("item == {0}" , item);
            }

            statck.Pop();
            Console.WriteLine("After Popping");
            foreach (var item in statck)
            {
                Console.WriteLine("item == {0}" , item);
            }

            Console.WriteLine("top element of the stack : {0}" ,statck.Peek());

        }
       #endregion

       #region Queue 
       static void Test4()
       {
           Queue queue = new Queue();
           queue.Enqueue(1);
           queue.Enqueue(2);
           queue.Enqueue(3);

            Console.WriteLine("Before Popping");
            foreach (var item in queue)
            {
                Console.WriteLine("item == {0}" , item);
            }

            queue.Dequeue();

            Console.WriteLine("After Popping");
            foreach (var item in queue)
            {
                Console.WriteLine("item == {0}" , item);
            }

            
            Console.WriteLine("top element of the stack : {0}" ,queue.Peek());

       }
       #endregion 


       #region  genericList
       static void GenericTest1()
       {
           List<int> list = new List<int>();
           list.Add(1);
           list.Add(2);
           list.Add(3);

           foreach (var item in list)
           {
                Console.WriteLine("item == {0}", item);
           }
       } 

       #endregion

       #region generic dictionary 
       static void GenericDictionary()
       {
           Dictionary<int,string> dictionary = new Dictionary<int, string>();
           dictionary.Add(0,"anas");
           dictionary.Add(1,"jarrar"); 

           foreach (var item in dictionary)
           {
               Console.WriteLine("item == {0} , value == {1}",item.Key,item.Value);
           } 

       } 

       #endregion

        #region  generic sorted llist
        static void GenericSortedList()
        {
            SortedList<string,string> sortedList = new SortedList<string, string>();
            sortedList.Add("j","j");
            sortedList.Add("b","b");

            foreach (var item in sortedList)
            {
                    Console.WriteLine("item == {0} , value == {1}",item.Key,item.Value);
            }

        }

        #endregion

        #region  generic stack
        static void GenericStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("popped element == {0}",stack.Pop());

        }

        #endregion


        #region generic queue

        static void GenericQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Popped Element == {0}",queue.Dequeue());

        }

        #endregion


        static void Main(string[] args) 
        {
            GenericQueue();
        }

    }

}