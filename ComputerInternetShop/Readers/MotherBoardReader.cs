using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.Readers
{
    public class MotherBoardReader : IParametersReader<MotherBoard>
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
            Console.Write("Введіть чіпсет: ");
            _parameters.Add("Chipset", Console.ReadLine());
            Console.Write("Введіть кількість процессорів: ");
            _parameters.Add("ProcessorCount", Console.ReadLine());
            Console.Write("Введіть тип пам'яті: ");
            _parameters.Add("MemoryType", Console.ReadLine());
            Console.Write("Введіть частоту системної шини: ");
            _parameters.Add("BusSpeed", Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Продукт створено!");
        }
    }
}