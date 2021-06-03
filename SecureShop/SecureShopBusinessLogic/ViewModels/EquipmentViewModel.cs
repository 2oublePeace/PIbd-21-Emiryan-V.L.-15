using SecureShopBusinessLogic.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SecureShopBusinessLogic.ViewModels
{
    public class EquipmentViewModel
    {
        [Column(title: "Номер", width: 50)]
        [DataMember]
        public int Id { get; set; }
        [Column(title: "Название", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string EquipmentName { get; set; }
        [Column(title: "Цена", width: 100)]
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> EquipmentDevices { get; set; }
    }
}
