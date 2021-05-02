using System;
using System.Collections.Generic;
using System.Text;

namespace SecureShopBusinessLogic.BindingModels
{
	public class CreateOrderBindingModel
	{
		public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public int Count { get; set; }
		public decimal Sum { get; set; }
	}
}
