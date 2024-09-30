using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //Bu prensipte amaç kullanıcıyı arka planda hangi işlemlerin döndüğü ile uğraştırmak yerine sadece girdi ve çıktıları bilerek çalışmasını sağlamaktır. Bu örnekte, soyutlama sayesinde Product sınıfı, tüm ürünlerin sahip olması gereken ortak özellik ve davranışları belirtir (örneğin HasStock()), ancak her ürün bu davranışları kendi ihtiyaçlarına göre özelleştirir.
    public abstract class Product
    {
        public int stock = 5;
        public abstract void HasStock();
    }
    public class AcerComputer : Product
    {
        public override void HasStock()
        {
            Console.WriteLine("Stokta Yok");
        }
    }
    public class IPhone16Series : Product
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
