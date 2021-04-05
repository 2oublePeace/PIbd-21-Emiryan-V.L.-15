using System;
using System.Collections.Generic;
using System.Text;
using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.Interfaces;
using SecureShopBusinessLogic.ViewModels;

namespace SecureShopBusinessLogic.BusinessLogics
{
	public class DeviceLogic
	{
		private readonly IDeviceStorage _deviceStorage;
		public DeviceLogic(IDeviceStorage deviceStorage)
		{
			_deviceStorage = deviceStorage;
		}
		public List<DeviceViewModel> Read(DeviceBindingModel model)
		{
			if (model == null)
			{
				return _deviceStorage.GetFullList();
			}
			if (model.Id.HasValue)
			{
				return new List<DeviceViewModel> { _deviceStorage.GetElement(model)};
			}
			return _deviceStorage.GetFilteredList(model);
		}
		public void CreateOrUpdate(DeviceBindingModel model)
		{
			var element = _deviceStorage.GetElement(new DeviceBindingModel
			{
				DeviceName = model.DeviceName
			});
			if (element != null && element.Id != model.Id)
			{
				throw new Exception("Уже есть компонент с таким названием");
			}
			if (model.Id.HasValue)
			{
				_deviceStorage.Update(model);
			}
			else
			{
				_deviceStorage.Insert(model);
			}
		}
		public void Delete(DeviceBindingModel model)
		{
			var element = _deviceStorage.GetElement(new DeviceBindingModel { Id = model.Id });
			if (element == null)
			{
			throw new Exception("Элемент не найден");
			}
			_deviceStorage.Delete(model);
		}
	}
}
