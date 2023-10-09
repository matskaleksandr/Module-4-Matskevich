using System;
using System.Collections.Generic;

namespace Solution_2
{
    internal class StoreManager
    {
        private List<IProduct> products = new List<IProduct>();
        //добавление товара в магазин
        public void AddProduct(IProduct product)
        {
            products.Add(product);//добавляем товар в список
        }
        //вывод информации о всех товарах в магазине
        public void DisplayProducts()
        {
            Console.WriteLine("Список товаров в магазине:");
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());//вывод информации о товаре
            }
        }
    }
}
