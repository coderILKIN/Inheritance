using System;
using System.Collections.Generic;
using System.Text;

namespace TASK
{
    class Product
    {
        public string Price;
        public string ReleaseDate;
        public int Count;

        public void Information()
        {
            Console.WriteLine($" Price:{ Price}, ReleaseDate: {ReleaseDate}, Count:{Count}");
        }

        public Product(string price, string releasedate, int count)
        {
            Price = price;
            ReleaseDate = releasedate;
            Count = count;

        }

        
    }
}
