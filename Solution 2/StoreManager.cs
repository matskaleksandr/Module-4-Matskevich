using System;
using System.Collections.Generic;

namespace Solution_2
{
    internal class StoreManager
    {
        private List<IProduct> products = new List<IProduct>();

        // Добавление товара в магазин
        public void AddProduct(IProduct product)
        {
            products.Add(product); // Добавляем товар в список
        }

        // Вывод информации о всех товарах в магазине
        public void DisplayProducts()
        {
            Console.WriteLine("Список товаров в магазине:");
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString()); // Вывод информации о товаре
            }
        }
    }
}
