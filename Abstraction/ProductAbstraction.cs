using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //The goal of this principle is to ensure that the user does not have to deal with the underlying operations and can work only with the inputs and outputs. In this example, through abstraction, the Product class specifies common properties and behaviors that all products should have (such as HasStock()), but each product customizes these behaviors according to its specific needs.
    public abstract class ProductAbstraction
    {
        public int stock = 5;
        public abstract void HasStock();
    }
    public class AcerComputer : ProductAbstraction
    {
        public override void HasStock()
        {
            Console.WriteLine("Stokta Yok");
        }
    }
    public class IPhone16Series : ProductAbstraction
    {
        public override void HasStock()
        {
            Console.WriteLine("Stokta Var");
            Console.WriteLine("Iphone 16 satın alındı");
            stock--;
            Console.WriteLine($"Kalan stok sayısı {stock}");

        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            IPhone16Series phone16Series = new IPhone16Series();

            phone16Series.HasStock();
        }
    }

}
