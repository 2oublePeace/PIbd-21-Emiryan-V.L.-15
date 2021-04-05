using System;
using System.Collections.Generic;
using System.Text;

namespace SecureShopBusinessLogic.BindingModels
{
	/// <summary>
	/// Компонент, требуемый для изготовления комплектации
	/// </summary>
	public class DeviceBindingModel
	{
		public int? Id { get; set; }
		public string DeviceName { get; set; }
	}
}
