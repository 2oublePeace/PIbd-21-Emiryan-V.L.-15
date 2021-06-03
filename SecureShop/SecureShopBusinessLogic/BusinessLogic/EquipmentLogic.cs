using System;
using System.Collections.Generic;
using System.Text;
using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.Interfaces;
using SecureShopBusinessLogic.ViewModels;

namespace SecureShopBusinessLogic.BusinessLogics
{
	public class EquipmentLogic
	{
        private readonly IEquipmentStorage _equipmentStorage;
        public EquipmentLogic(IEquipmentStorage equipmentStorage)
        {
            _equipmentStorage = equipmentStorage;
        }

        public List<EquipmentViewModel> Read(EquipmentBindingModel model)
        {
            if (model == null)
            {
                return _equipmentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<EquipmentViewModel> { _equipmentStorage.GetElement(model) };
            }
            return _equipmentStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(EquipmentBindingModel model)
        {
            var element = _equipmentStorage.GetElement(new EquipmentBindingModel { EquipmentName = model.EquipmentName});
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть комплект с таким названием");
            }
            if (model.Id.HasValue)
            {
                _equipmentStorage.Update(model);
            }
            else
            {
                _equipmentStorage.Insert(model);
            }
        }
        public void Delete(EquipmentBindingModel model)

        {
            var element = _equipmentStorage.GetElement(new EquipmentBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _equipmentStorage.Delete(model);
        }
    }
}
