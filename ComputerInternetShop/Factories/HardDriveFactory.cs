using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;
using ComputerInternetShop.Readers;

namespace ComputerInternetShop.Factories
{
    public class HardDriveFactory : IProductFactory
    {
        private readonly IParametersReader<HardDrive> _reader = new HardDriveReader();
        private IReadOnlyDictionary<string, string> _parameters;

        public Product CreateProduct()
        {
            _parameters = _reader.GetUserParameters();
            return new HardDrive(DataKey.ItemNumber, GetName(), GetPrice(), GetCapacity(), GetSpeed(), GetInterfaceOfConnect());
        }

        private string GetInterfaceOfConnect() =>
            _parameters.ContainsKey(DataKey.InterfaceOfConnectKey) ? _parameters[DataKey.InterfaceOfConnectKey] : string.Empty;

        private int GetSpeed() =>
            _parameters.ContainsKey(DataKey.SpeedKey) ? Convert.ToInt32(_parameters[DataKey.SpeedKey]) : 0;

        private int GetCapacity() =>
            _parameters.ContainsKey(DataKey.CapacityKey) ? Convert.ToInt32(_parameters[DataKey.CapacityKey]) : 0;

        private double GetPrice() => 
            _parameters.ContainsKey(DataKey.PriceKey) ? Convert.ToDouble(_parameters[DataKey.PriceKey]) : 0;

        private string GetName() => 
            _parameters.ContainsKey(DataKey.NameKey) ? _parameters[DataKey.NameKey] : string.Empty;
        
        private static class DataKey
        {
            internal const int ItemNumber = 2;
            internal const string NameKey = "Name";
            internal const string PriceKey = "Price";
            internal const string CapacityKey = "Capacity";
            internal const string SpeedKey = "Speed";
            internal const string InterfaceOfConnectKey = "InterfaceOfConnect";
        }
    }
}