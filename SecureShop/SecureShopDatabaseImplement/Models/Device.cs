using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecureShopDatabaseImplement.Models
{
	/// <summary>
	/// Компонент, требуемый для изготовления изделия
	/// </summary>
	public class Device
	{
		public int Id { get; set; }

		[Required]
		public string DeviceName { get; set; }

		[ForeignKey("DeviceId")]
		public virtual List<EquipmentDevice> EquipmentDevices { get; set; }
	}
}