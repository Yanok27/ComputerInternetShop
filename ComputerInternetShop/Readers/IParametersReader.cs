using System.Collections.Generic;

namespace ComputerInternetShop.Readers
{
    public interface IParametersReader<T>
    {
        IReadOnlyDictionary<string, string> GetUserParameters();
    }
}