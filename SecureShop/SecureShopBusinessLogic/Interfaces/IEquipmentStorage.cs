using System;
using System.Collections.Generic;
using System.Text;
using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.ViewModels;

namespace SecureShopBusinessLogic.Interfaces
{
	public interface IEquipmentStorage
	{
		List<EquipmentViewModel> GetFullList();
		List<EquipmentViewModel> GetFilteredList(EquipmentBindingModel model);
		EquipmentViewModel GetElement(EquipmentBindingModel model);
		void Insert(EquipmentBindingModel model);
		void Update(EquipmentBindingModel model);
		void Delete(EquipmentBindingModel model);
	}
}
