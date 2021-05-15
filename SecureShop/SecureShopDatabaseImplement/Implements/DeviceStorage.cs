using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.Interfaces;
using SecureShopBusinessLogic.ViewModels;
using SecureShopDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecureShopDatabaseImplement.Implements
{
    public class DeviceStorage : IDeviceStorage
    {
        public List<DeviceViewModel> GetFullList()
        {
            using (var context = new SecureShopDatabase())
            {
                return context.Devices
                .Select(rec => new DeviceViewModel
                {
                    Id = rec.Id,
                    DeviceName = rec.DeviceName
                })
               .ToList();
            }
        }
        public List<DeviceViewModel> GetFilteredList(DeviceBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new SecureShopDatabase())
            {
                return context.Devices
                .Where(rec => rec.DeviceName.Contains(model.DeviceName))
               .Select(rec => new DeviceViewModel
               {
                   Id = rec.Id,
                   DeviceName = rec.DeviceName
               })
                .ToList();
            }
        }
        public DeviceViewModel GetElement(DeviceBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new SecureShopDatabase())
            {
                var component = context.Devices
                .FirstOrDefault(rec => rec.DeviceName == model.DeviceName ||
               rec.Id == model.Id);
                return component != null ?
                new DeviceViewModel
                {
                    Id = component.Id,
                    DeviceName = component.DeviceName
                } :
               null;
            }
        }
        public void Insert(DeviceBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                context.Devices.Add(CreateModel(model, new Device()));
                context.SaveChanges();
            }
        }
        public void Update(DeviceBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                var element = context.Devices.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element == null)
            {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }
        public void Delete(DeviceBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                Device element = context.Devices.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Devices.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        private Device CreateModel(DeviceBindingModel model, Device device)
        {
            device.DeviceName = model.DeviceName;
            return device;
        }
    }
}