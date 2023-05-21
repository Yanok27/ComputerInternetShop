using System;
using System.Collections.Generic;
using System.IO;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.Readers
{
    public class ProcessorReader : IParametersReader
    {
        private const string PathToFile = "/Users/denys/RiderProjects/ComputerInternetShop/ComputerInternetShop/Resources/Processors.txt";
        private readonly List<Dictionary<string, string>> _parameters = new ();

        private void InitializeParameters()
        {
            using StreamReader sr = new StreamReader(PathToFile);
            string line;
            Dictionary<string, string> itemData = new Dictionary<string, string>();

            while ((line = sr.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    _parameters.Add(itemData);
                    itemData = new Dictionary<string, string>();
                }
                else
                {
                    string[] parts = line.Split(':');

                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        itemData.Add(key, value);
                    }
                }
            }
            _parameters.Add(itemData);
        }

        public IReadOnlyCollection<IReadOnlyDictionary<string, string>> GetProductsParameters()
        {
            InitializeParameters();
            return _parameters;
        }
    }
}