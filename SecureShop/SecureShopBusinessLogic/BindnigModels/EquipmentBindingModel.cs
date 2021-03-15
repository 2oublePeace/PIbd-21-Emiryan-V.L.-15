using System;
using System.Collections.Generic;
using System.Text;

namespace SecureShopBusinessLogic.BindingModels
{
	public class EquipmentBindingModel
	{
		public int? Id { get; set; }
		public string EquipmentName { get; set; }
		public decimal Price { get; set; }
		public Dictionary<int, (string, int)> EquipmentComponents { get; set; }
	}
}
