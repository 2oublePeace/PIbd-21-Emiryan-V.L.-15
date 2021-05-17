using System;
using System.Collections.Generic;
using System.Text;

namespace SecureShopBusinessLogic.ViewModels
{
	public class ReportEquipmentDeviceViewModel
	{
		public string EquipmentName { get; set; }
		public int TotalCount { get; set; }
		public List<Tuple<string, int>> Devices { get; set; }
	}
}

