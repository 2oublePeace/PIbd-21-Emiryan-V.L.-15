using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecureShopDatabaseImplement.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        [Required]
        public string EquipmentName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("EquipmentId")]
        public virtual List<EquipmentDevice> EquipmentDevice { get; set; }
        [ForeignKey("EquipmentId")]
        public virtual List<Order> Orders { get; set; }
    }
}

