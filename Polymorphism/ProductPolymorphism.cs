using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //In the Main method of the program, the objects phone and fridge, which are of type Product, call their class-specific Color() method when executed. The phone.Color() call executes the version in the Phone class, while the fridge.Color() call executes the version in the Fridge class. This demonstrates that the same method (Color()) exhibits different behaviors in different classes, which explains polymorphism.
    public class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();

            phone.Name = "Iphone16";
            phone.Color();
            phone.UseAI();

            Fridge fridge = new Fridge();
            fridge.Name = "Samsung";
            fridge.Color();
            fridge.Freeze();
        }
    }
    public class ProductPolymorphism
    {
        public string? Name { get; set; }

        //Virtual and override keywords: The Color method in the Product class is defined as virtual, meaning this method can be overridden in subclasses. In the Phone and Fridge classes, we used override to redefine this method, allowing each class to have its own specific Color behavior.
        public virtual void Color()
        {

        }
    }
    public class Phone : ProductPolymorphism
    {
        public override void Color()
        {
            Console.WriteLine($"{Name} is Silver");
        }
        public void UseAI()
        {
            Console.WriteLine($"{Name} use AI");
        }
    }
    public class Fridge : ProductPolymorphism
    {
        public override void Color()
        {
            Console.WriteLine($"{Name} fridge is White");
        }

        public void Freeze()
        {
            Console.WriteLine($"{Name} fridge is freezing");
        }
    }
}
