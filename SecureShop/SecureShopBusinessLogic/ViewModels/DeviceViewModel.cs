using SecureShopBusinessLogic.Attributes;
using System.Runtime.Serialization;

namespace SecureShopBusinessLogic.ViewModels
{
    public class DeviceViewModel
    {
        [Column(title: "Номер", width: 50)]
        [DataMember]
        public int Id { get; set; }
        [Column(title: "Название", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string DeviceName { get; set; }
    }
}
