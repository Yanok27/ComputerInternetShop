using ComputerInternetShop.Products;

namespace ComputerInternetShop.Factories
{
    public interface IProductFactory
    {
        Product CreateProduct();
    }
}