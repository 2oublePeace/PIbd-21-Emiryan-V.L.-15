using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace SecureShopBusinessLogic.Interfaces
{
    public interface IMessageInfoStorage
    {
        List<MessageInfoViewModel> GetFullList();
        List<MessageInfoViewModel> GetFilteredList(MessageInfoBindingModel model);
        void Insert(MessageInfoBindingModel model);
    }
}
