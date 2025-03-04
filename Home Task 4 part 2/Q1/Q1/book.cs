using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class book
    {
        public string title;
        public string name;
        public string ISBN;
        public double price;

        public void display()
        {
            Console.WriteLine("The name of the book is : {0}", title);
            Console.WriteLine("The Authur of the book is : {0}", name);
            Console.WriteLine("The ISbn of the book is : {0}",ISBN);
            Console.WriteLine("The Price of the book is : {0}", price);
        }

        public void discount()
        {
            double dprice = price*0.2 ;
            double afterprice = price - dprice;

            Console.WriteLine("The price of book after 20% discount is : {0}",afterprice);

        }


    }
}
