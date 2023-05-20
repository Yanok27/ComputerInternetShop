using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.Readers
{
    public class ProcessorReader : IParametersReader<Processor>
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
            Console.Write("Введіть тип сокету: ");
            _parameters.Add("SocketType", Console.ReadLine());
            Console.Write("Введіть кількість ядер: ");
            _parameters.Add("CoreCount", Console.ReadLine());
            Console.Write("Введіть тактову частоту: ");
            _parameters.Add("ClockSpeed", Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Продукт створено!");
        }
    }
}