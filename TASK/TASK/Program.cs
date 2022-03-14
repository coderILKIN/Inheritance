using System;

namespace TASK
{
    class Program
    {
        static void Main(string[] args)
        {

            NewsPaper newspaper = new NewsPaper("20 AZN","10.03.2019",55,"Reklam","Meqale");

            Console.WriteLine(newspaper.Info1());

            Console.WriteLine(newspaper.Info2());

            Console.WriteLine(newspaper.Info3());

            newspaper.sell();



            //Book book = new Book("30 Azn","27.04.2020",90,"ILKIN","Janr");

            //Console.WriteLine(book.infomain1());

            //Console.WriteLine(book.Infomain2());

            //Console.WriteLine(book.Infomain3());

            




          


            


            

        }
    }
}
