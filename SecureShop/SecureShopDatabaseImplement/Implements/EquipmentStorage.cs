using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.Interfaces;
using SecureShopBusinessLogic.ViewModels;
using SecureShopDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureShopDatabaseImplement.Implements
{
    public class EquipmentStorage : IEquipmentStorage
    {
        public List<EquipmentViewModel> GetFullList()
        {
            using (var context = new SecureShopDatabase())
            {
                return context.Equipments
                    .Include(rec => rec.EquipmentDevice)
                    .ThenInclude(rec => rec.Device)
                    .ToList()
                    .Select(rec => new EquipmentViewModel
                    {
                        Id = rec.Id,
                        EquipmentName = rec.EquipmentName,
                        Price = rec.Price,
                        EquipmentDevices = rec.EquipmentDevice
                            .ToDictionary(recEquipmentDevices => recEquipmentDevices.DeviceId,
                            recEquipmentDevices => (recEquipmentDevices.Device?.DeviceName,
                            recEquipmentDevices.Count))
                    })
                    .ToList();
            }
        }
        public List<EquipmentViewModel> GetFilteredList(EquipmentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new SecureShopDatabase())
            {
                return context.Equipments
                    .Include(rec => rec.EquipmentDevice)
                    .ThenInclude(rec => rec.Device)
                    .Where(rec => rec.EquipmentName.Contains(model.EquipmentName))
                    .ToList()
                    .Select(rec => new EquipmentViewModel
                    {
                        Id = rec.Id,
                        EquipmentName = rec.EquipmentName,
                        Price = rec.Price,
                        EquipmentDevices = rec.EquipmentDevice
                            .ToDictionary(recEquipmentDevices => recEquipmentDevices.DeviceId,
                            recEquipmentDevices => (recEquipmentDevices.Device?.DeviceName,
                            recEquipmentDevices.Count))
                    })
                    .ToList();
            }
        }
        public EquipmentViewModel GetElement(EquipmentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new SecureShopDatabase())
            {
                var equipment = context.Equipments
                    .Include(rec => rec.EquipmentDevice)
                    .ThenInclude(rec => rec.Device)
                    .FirstOrDefault(rec => rec.EquipmentName == model.EquipmentName ||
                    rec.Id == model.Id);

                return equipment != null ?
                    new EquipmentViewModel
                    {
                        Id = equipment.Id,
                        EquipmentName = equipment.EquipmentName,
                        Price = equipment.Price,
                        EquipmentDevices = equipment.EquipmentDevice
                            .ToDictionary(recEquipmentDevice => recEquipmentDevice.DeviceId,
                            recEquipmentDevice => (recEquipmentDevice.Device?.DeviceName,
                            recEquipmentDevice.Count))
                    } :
                    null;
            }
        }
        public void Insert(EquipmentBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        CreateModel(model, new Equipment(), context);
                        context.SaveChanges();

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Update(EquipmentBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var equipment = context.Equipments.FirstOrDefault(rec => rec.Id == model.Id);

                        if (equipment == null)
                        {
                            throw new Exception("Подарок не найден");
                        }

                        CreateModel(model, equipment, context);
                        context.SaveChanges();

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(EquipmentBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                var Device = context.Equipments.FirstOrDefault(rec => rec.Id == model.Id);

                if (Device == null)
                {
                    throw new Exception("Материал не найден");
                }

                context.Equipments.Remove(Device);
                context.SaveChanges();
            }
        }
        private Equipment CreateModel(EquipmentBindingModel model, Equipment equipment, SecureShopDatabase context)
        {
            equipment.EquipmentName = model.EquipmentName;
            equipment.Price = model.Price;
            if (equipment.Id == 0)
            {
                context.Equipments.Add(equipment);
                context.SaveChanges();
            }

            if (model.Id.HasValue)
            {
                var equipmentDevice = context.EquipmentDevices
                    .Where(rec => rec.EquipmentId == model.Id.Value)
                    .ToList();

                context.EquipmentDevices.RemoveRange(equipmentDevice
                    .Where(rec => !model.EquipmentDevices.ContainsKey(rec.EquipmentId))
                    .ToList());
                context.SaveChanges();

                foreach (var updateDevice in equipmentDevice)
                {
                    updateDevice.Count = model.EquipmentDevices[updateDevice.DeviceId].Item2;
                    model.EquipmentDevices.Remove(updateDevice.EquipmentId);
                }
                context.SaveChanges();
            }
            foreach (var equipmentDevice in model.EquipmentDevices)
            {
                context.EquipmentDevices.Add(new EquipmentDevice
                {
                    EquipmentId = equipment.Id,
                    DeviceId = equipmentDevice.Key,
                    Count = equipmentDevice.Value.Item2
                });
                context.SaveChanges();
            }
            return equipment;
        }
    }
}