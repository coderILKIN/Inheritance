using System;
using System.Collections.Generic;
using System.Text;

namespace TASK
{
    class NewsPaper : Product
    {
        public string Advertisement;
        public string Article;




        public NewsPaper(string price, string releasedate, int count, string advertisement, string article) : base(price, releasedate, count)
        {
            Advertisement = advertisement;
            Article = article;

        }

        public string Info1()
        {
            return $"Advertisement:{Advertisement}, Article:{Article},";
        }

        public string Info2()
        {
            return $"Price:{Price}, ReleaseDate:{ReleaseDate}, Count:{Count}";
        }


        public string Info3()
        {
            return $"Advertisement:{Advertisement}, Article:{Article}, Price:{Price}, ReleaseDate:{ReleaseDate}, Count:{Count}";

        }

        public void sell()
        {


            do
            {

                int count = 7;
                count = count - 1;

                Console.WriteLine(count);

                break;

                if (count == 0)
                {

                    Console.WriteLine("sati heyata kecmedi");

                }

            } while (Count!=0);
                


                

            
            
              
                




            
            
            
            



        }


       
    }
}
