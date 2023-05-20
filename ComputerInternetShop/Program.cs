using System;

namespace ComputerInternetShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            bool isFoundProduct = true;

            while (isFoundProduct)
            {
                Console.WriteLine("1) Шукати товар за параметрами:" );
                Console.WriteLine("2) Закінчити");
                Console.Write("Оберіть дію: ");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch(userChoice)
                {
                    case 1:
                        client.GetTypeOfProduct();
                        break;
                    case 2:
                        isFoundProduct = false;
                        client.ShowProducts();
                        break;
                }
            }
        
        }
    }
}