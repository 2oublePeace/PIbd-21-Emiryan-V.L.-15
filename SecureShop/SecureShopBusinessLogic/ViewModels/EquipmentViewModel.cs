using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace SecureShopBusinessLogic.ViewModels
{
	public class EquipmentViewModel
	{
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("Название комплекта")]
        public string EquipmentName { get; set; }
        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> EquipmentDevices { get; set; }
    }
}
