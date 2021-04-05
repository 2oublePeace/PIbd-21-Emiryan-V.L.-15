using System;
using System.Collections.Generic;
using System.Text;
using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.ViewModels;

namespace SecureShopBusinessLogic.Interfaces
{
	public interface IDeviceStorage
	{
		List<DeviceViewModel> GetFullList();
		List<DeviceViewModel> GetFilteredList(DeviceBindingModel model);
		DeviceViewModel GetElement(DeviceBindingModel model);
		void Insert(DeviceBindingModel model);
		void Update(DeviceBindingModel model);
		void Delete(DeviceBindingModel model);
	}
}
