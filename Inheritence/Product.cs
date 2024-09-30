using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    //Here, it is seen that the Phone class applies the principle of Inheritance by inheriting methods belonging to the superclass Product. By creating a new object from the Phone class, we were also able to use the Color method from the Product class.
    public class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();

            phone.Name = "Iphone16";
            phone.Color();
            phone.UseAI();
        }
    }
    public class Product
    {
        public string? Name { get; set; }
        public void Color ()
        {
            Console.WriteLine($"{Name} is Black");
        }
    }
    public class Phone : Product
    {
        public void UseAI()
        {
            Console.WriteLine($"{Name} use AI");
        }
    }
}
