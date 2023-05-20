using System;
using System.Collections.Generic;
using ComputerInternetShop.Factories;
using ComputerInternetShop.Products;

namespace ComputerInternetShop
{
    public class Client
    {
        private readonly List<Product> _products = new List<Product>();
        private IProductFactory _productFactory;

        public void GetTypeOfProduct()
        {
            Console.Clear();
            Console.WriteLine("1) Материнські плати");
            Console.WriteLine("2) Процесори");
            Console.WriteLine("3) Жорсткі Диски");
            Console.WriteLine("4) Оперативна Пам'ять");
            Console.Write("Введіть який предмет ви шукаєте: ");
            int productChoice = Convert.ToInt32(Console.ReadLine());

            _productFactory = productChoice switch
            {
                1 => new MotherboardFactory(),
                2 => new ProcessorFactory(),
                3 => new HardDriveFactory(),
                4 => new MemoryFactory(),
                _ => throw new ArgumentException("Неможливий вибір!")
            };
            
            GetProduct();
        }

        private void GetProduct() => 
            _products.Add(_productFactory.CreateProduct());

        public void ShowProducts()
        {
            foreach (var product in _products)
                Console.WriteLine(product.GetInformation());
        }
    }
}