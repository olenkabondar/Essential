using System.Diagnostics;
using System.Xml.Linq;

namespace _4Task
{
    internal class Article
    {
        private string nameProduct;
        private string nameShop;
        private decimal priceProduct;
        public Article(string nameProduct, string nameShop, decimal priceProduct)
        {
            this.nameProduct = nameProduct;
            this.nameShop = nameShop;
            this.priceProduct = priceProduct;
        }
        public string NameProduct
        {
            get { return nameProduct; }
        }
        public string NameShop
        {
            get { return nameShop; }
        }
        public decimal PriceProduct
        {
            get { return priceProduct; }
        }

        public void PrintArticleInfo()
        {
            Console.WriteLine($"Товар: {nameProduct}, Магазин: {nameShop}, Ціна: {priceProduct} грн");
        }
    }
}
