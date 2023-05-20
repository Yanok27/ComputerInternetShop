namespace ComputerInternetShop.Products
{
    public class Memory : Product
    {
        public int Capacity { get; }
        public string Type { get;  }
        public int Frequency { get;  }
        public int ModuleCount { get;  }
        
        public Memory(int itemNumber, string name, double price, int capacity, string type, int frequency, int moduleCount) : base(itemNumber, name, price)
        {
            Capacity = capacity;
            Type = type;
            Frequency = frequency;
            ModuleCount = moduleCount;
        }
        
        public override string GetInformation()
        {
            return $"Memory: " +
                   $"\n\tItem Number: {ItemNumber}" +
                   $"\n\tName: {Name}" +
                   $"\n\tPrice: {Price}" +
                   $"\n\tCapacity: {Capacity}" +
                   $"\n\tType: {Type}" +
                   $"\n\tFrequency: {Frequency}" +
                   $"\n\tModuleCount: {ModuleCount}";
        }
    }
}