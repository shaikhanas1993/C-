using System;
namespace Services
{
     struct Books
     {
         private string title;
         private string author;

         public Books(string title,string author){
             this.title = title;
             this.author = author;
         }

         public void Display(){
             System.Console.WriteLine("title ==" + title);
             System.Console.WriteLine("author ==" + author);
         }   

     }   
}