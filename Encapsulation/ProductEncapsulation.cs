namespace Encapsulation
{
    //In this example, we encapsulated the stockCount field by using the StockCount property and the GetStockCount method, allowing external access only through these methods. This ensures compliance with the Encapsulation principle.

    public class Program
    {
        //We accessed the stockCount field not directly, but through the method.
        static void Main(string[] args)
        {
            ProductEncapsulation pstock = new ProductEncapsulation();
            //first method
            pstock.StockCountFirst();
            Console.WriteLine(pstock.GetStockCount());

            // second method
            Console.WriteLine(pstock.StockCountSecond);

        }
    }
    public class ProductEncapsulation
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

        public int StockCountSecond { get { return stockCount; } set { stockCount = 5; } }

        #endregion

    }





}
