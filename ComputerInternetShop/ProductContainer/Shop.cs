using System.Collections.Generic;
using ComputerInternetShop.Factories;
using ComputerInternetShop.Products;
using ComputerInternetShop.Readers;

namespace ComputerInternetShop.ProductContainer
{
    public class Shop : IProductContainer
    {
        private readonly Dictionary<IParametersReader, IProductFactory> _productsParameter;
        private readonly List<Product> _products;

        public IEnumerable<Product> Products => _products;

        public Shop()
        {
            _productsParameter = new Dictionary<IParametersReader, IProductFactory>()
            {
                {
                    new MemoryReader(), new MemoryFactory()
                },
                {
                    new HardDriveReader(), new HardDriveFactory()
                },
                {
                    new MotherBoardReader(), new MotherboardFactory()
                },
                {
                    new ProcessorReader(), new ProcessorFactory()
                }
            };
            
            _products = new List<Product>();
            InitializeProducts();
        }

        private void InitializeProducts()
        {
            foreach (var (reader, value) in _productsParameter)
            {
                var parameters = reader.GetProductsParameters();
                foreach (var dictionary in parameters)
                {
                    _products.Add(value.CreateProduct(dictionary));
                }
            }
        }
    }
}