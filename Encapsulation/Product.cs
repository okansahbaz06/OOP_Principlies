namespace Encapsulation
{
    //Bu örnekte stockCount field' ını StockCount, GetStockCount methodlarıyla kapsülleyerek dışarıya sadece bu methodlar üzerinden erişim sağlanabilmesini sağladık bu sayede Encapsulation prensibine uyduk.

    public class Program
    {
        //stockCount field ına direk değil method üzerinden erişim sağladık.
        static void Main(string[] args)
        {
            ProductStock pstock = new ProductStock();
            //birinci yöntem
            pstock.StockCountFirst();
            Console.WriteLine(pstock.GetStockCount());

            // ikinci yöntem
            Console.WriteLine(pstock.StockCountSecond);

        }
    }
    public class ProductStock
    {
        private int stockCount;
        #region First Method

        public void StockCountFirst()
        {
            stockCount = 5;
        }
        public int GetStockCount()
        {
            return stockCount;
        }
        #endregion

        #region Second Method

        public int StockCountSecond
        {
            get { return stockCount; }
            set { stockCount = 5; }
        }

        #endregion

    }





}
