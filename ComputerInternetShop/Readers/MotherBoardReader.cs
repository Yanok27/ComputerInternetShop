using System;
using System.Collections.Generic;
using System.IO;
using ComputerInternetShop.Products;

namespace ComputerInternetShop.Readers
{
    public class MotherBoardReader : IParametersReader
    {
        private const string PathToFile = "D:/.net/ComputerInternetShop/ComputerInternetShop/Resources/MotherBoard.txt";
        private readonly List<Dictionary<string, string>> _parameters = new ();

        private void InitializeParameters()
        {
            using StreamReader sr = new StreamReader(PathToFile);
            string line;
            Dictionary<string, string> itemData = new Dictionary<string, string>();

            while ((line = sr.ReadLine()) != null)
            {
                string[] products = line.Split("\n\n");

                for (int i = 0; i < products.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(products[i]))
                    {
                        _parameters.Add(itemData);
                        itemData = new Dictionary<string, string>();
                    }
                    else
                    {
                        string[] parts = products[i].Split(':');

                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();

                            itemData.Add(key, value);
                        }
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