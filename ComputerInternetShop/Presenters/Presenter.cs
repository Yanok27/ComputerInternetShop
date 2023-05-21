using System;
using System.Collections.Generic;
using ComputerInternetShop.Products;
using ComputerInternetShop.View;

namespace ComputerInternetShop.Presenters
{
    public class Presenter : IPresenter
    {
        private readonly IMenuView _menuView;
        private readonly IProductSearcher _productSearcher;

        public Presenter(IMenuView menuView, IProductSearcher productSearcher)
        {
            _menuView = menuView;
            _productSearcher = productSearcher;
        }
        
        public void Enable() => _menuView.ActionChoice += OnActionChoice;

        public void Disable() => _menuView.ActionChoice -= OnActionChoice;

        private void OnActionChoice(ActionType actionType)
        {
            IEnumerable<Product> result;
            
            switch (actionType)
            {
                case ActionType.None:
                    Console.WriteLine("Невірний тип!");
                    Disable();
                    return;
                case ActionType.FindByActionNumber:
                    result = _productSearcher.FindProductByItemNumber(_menuView.GetItemNumber());
                    break;
                case ActionType.FindByName:
                    result = _productSearcher.FindProductByName(_menuView.GetName());
                    break;
                case ActionType.FindByPrice:
                    result = _productSearcher.FindProductByPrice(_menuView.GetPrice());
                    break;
                case ActionType.FindBySocketType:
                    result = _productSearcher.FindProductBySocketType(_menuView.GetSocketType());
                    break;
                case ActionType.FindProductByChipset:
                    result = _productSearcher.FindProductByChipset(_menuView.GetChipset());
                    break;
                case ActionType.FindProductByMemoryType:
                    result = _productSearcher.FindProductByMemoryType(_menuView.GetMemoryType());
                    break;
                case ActionType.FindProductByBusSpeed:
                    result = _productSearcher.FindProductByBusSpeed(_menuView.GetBusSpeed());
                    break;
                case ActionType.FindProductByCoreCount:
                    result = _productSearcher.FindProductByCoreCount(_menuView.GetCoreCount());
                    break;
                case ActionType.FindProductByClockSpeed:
                    result = _productSearcher.FindProductByClockSpeed(_menuView.GetClockSpeed());
                    break;
                case ActionType.FindProductByCapacity:
                    result = _productSearcher.FindProductByCapacity(_menuView.GetCapacity());
                    break;
                case ActionType.FindProductByFrequency:
                    result = _productSearcher.FindProductByFrequency(_menuView.GetFrequency());
                    break;
                case ActionType.FindProductByModuleCount:
                    result = _productSearcher.FindProductByModuleCount(_menuView.GetModuleCount());
                    break;
                case ActionType.FindProductBySpeed:
                    result = _productSearcher.FindProductBySpeed(_menuView.GetBusSpeed());
                    break;
                case ActionType.FindProductByInterfaceOfConnect:
                    result = _productSearcher.FindProductByInterfaceOfConnect(_menuView.GetInterfaceOfConnect());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(actionType), actionType, null);
            }
            
            _menuView.ShowResult(result);
            Disable();
        }
    }
}