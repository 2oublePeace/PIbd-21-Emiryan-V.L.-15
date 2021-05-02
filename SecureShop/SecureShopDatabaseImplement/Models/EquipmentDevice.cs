using System.ComponentModel.DataAnnotations;

namespace SecureShopDatabaseImplement.Models
{
	/// <summary>
	/// Сколько компонентов, требуется при изготовлении изделия
	/// </summary>
	public class EquipmentDevice
	{
		public int Id { get; set; }

		public int EquipmentId { get; set; }
		public int DeviceId { get; set; }
		[Required]
		public int Count { get; set; }
		public virtual Device Device { get; set; }
		public virtual Equipment Equipment { get; set; }
	}
}