using System;
using System.Collections.Generic;
using System.Text;
using SecureShopBusinessLogic.ViewModels;

namespace SecureShopBusinessLogic.HelperModels
{
	class WordInfo
	{
		public string FileName { get; set; }
		public string Title { get; set; }
		public List<EquipmentViewModel> Equipments { get; set; }
	}
}
