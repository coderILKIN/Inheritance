using System;
using System.Collections.Generic;
using System.Text;

namespace TASK
{
    class Book:Product
    {
        public string Author;
        public string Genre;
        

        

        public Book(string price,string releasedate,int count, string author, string genre):base(price,releasedate,count)
        {
            Author = author;
            Genre = genre;

        }


        public string infomain1()
        {
            return $" Author:{Author}, Genre:{Genre}";

        }

        public string Infomain2()
        {
            return $"Price:{Price}, ReleaseDate:{ReleaseDate}, Count:{Count}";
        }

        public string Infomain3()
        {
            return $" Author:{Author}, Genre:{Genre},Price: { Price}, ReleaseDate: { ReleaseDate}, Count: { Count}";
        }











    }
}
