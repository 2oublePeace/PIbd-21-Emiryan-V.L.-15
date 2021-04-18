using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecureShopBusinessLogic.ViewModels
{
	public class EquipmentViewModel
	{
		public int Id { get; set; }
		[DisplayName("Название изделия")]
		public string EquipmentName { get; set; }
		[DisplayName("Цена")]
		public decimal Price { get; set; }
		[DisplayName("Источник")]
		public Dictionary<int, (string, int)> EquipmentDevices { get; set; }
	}
}
