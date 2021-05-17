using SecureShopListImplement.Models;
using System.Collections.Generic;

namespace SecureShopListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<Device> Devices { get; set; }
        public List<Order> Orders { get; set; }
        public List<Equipment> Equipments { get; set; }
        public List<Client> Clients { get; set; }
        public List<Implementer> Implementers { get; set; }
        private DataListSingleton()
        {
            Devices = new List<Device>();
            Orders = new List<Order>();
            Equipments = new List<Equipment>();
            Clients = new List<Client>();
            Implementers = new List<Implementer>();
        }
        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}