using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.Readers
{
    public class HardDriveReader : IParametersReader<HardDrive>
    {
        private readonly Dictionary<string, string> _parameters = new ();

        public IReadOnlyDictionary<string, string> GetUserParameters()
        {
            InitializeParameters();
            return _parameters;
        }

        private void InitializeParameters()
        {
            Console.Clear();
            Console.Write("Введіть Ім'я: ");
            _parameters.Add("Name", Console.ReadLine());
            Console.Write("Введіть ціну: ");
            _parameters.Add("Price", Console.ReadLine());
            Console.Write("Введіть об'єм: ");
            _parameters.Add("Capacity", Console.ReadLine());
            Console.Write("Введіть швидкість: ");
            _parameters.Add("Speed", Console.ReadLine());
            Console.Write("Введіть інтерфейс підключення: ");
            _parameters.Add("InterfaceOfConnect", Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Продукт створено!");
        }
    }
}