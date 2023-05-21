using System.Collections.Generic;

namespace ComputerInternetShop.Readers
{
    public interface IParametersReader
    {
        IReadOnlyCollection<IReadOnlyDictionary<string, string>> GetProductsParameters();
    }
}