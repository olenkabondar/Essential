using System;

namespace _4Task
{
    internal class Store
    {
        private Article[] articles;
        public Store(Article[] articles)
        {
            this.articles = articles;
        }

        // реалізація доступу за індексом
        public Article this[int index]
        {
            get
            {
                if (index < 0 || index >= articles.Length)
                    Console.WriteLine("Індекс виходить за межі масиву або < 0."); ;
                return articles[index];
            }
        }

        // пошук за назвою товару
        public Article[] FindArticleForNameProduct(string nameProduct)
        {
            
            int countFind = 0;
            //визначаємо кількість співпадінь
            foreach (Article article in articles)
            {
                if (article.NameProduct.Equals(nameProduct, StringComparison.OrdinalIgnoreCase))
                {
                    countFind++;
                }
            }

            //записуємо співпадіння в новий масив 
            Article[] results = new Article[countFind];
            int index = 0;
            if (countFind != 0 )
            {
                foreach (Article article in articles)
                {
                    if (article.NameProduct.Equals(nameProduct, StringComparison.OrdinalIgnoreCase))
                    {
                        results[index] = article;
                        index++;
                    }
                }
                return results;
            }
            else
            {
                Console.WriteLine($"Товар з назвою {nameProduct} не знайдено.");
                return results;
            }          
        }
    }
}
