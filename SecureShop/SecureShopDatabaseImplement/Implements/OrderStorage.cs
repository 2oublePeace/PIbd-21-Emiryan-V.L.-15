using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.Enums;
using SecureShopBusinessLogic.Interfaces;
using SecureShopBusinessLogic.ViewModels;
using SecureShopDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using SecureShopDatabaseImplement.Models;

namespace SecureShopDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using (var context = new SecureShopDatabase())
            {
                return context.Orders
                    .Include(rec => rec.Equipment)
                    .Include(rec => rec.Client)
                    .Include(rec => rec.Implementer)
                    .Select(CreateModel).ToList();
            }
        }
        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new SecureShopDatabase())
            {
                return context.Orders
                    .Include(rec => rec.Equipment)
                    .Include(rec => rec.Client)
                    .Include(rec => rec.Implementer)
                    .Where(rec => (!model.DateFrom.HasValue && !model.DateTo.HasValue &&
                    rec.DateCreate.Date == model.DateCreate.Date) ||
                     (model.DateFrom.HasValue && model.DateTo.HasValue &&
                    rec.DateCreate.Date >= model.DateFrom.Value.Date && rec.DateCreate.Date <=
                    model.DateTo.Value.Date) ||
                     (model.ClientId.HasValue && rec.ClientId == model.ClientId) ||
                    (model.FreeOrders.HasValue && model.FreeOrders.Value && rec.Status ==
                    OrderStatus.Принят) ||
                     (model.ImplementerId.HasValue && rec.ImplementerId ==
                    model.ImplementerId && rec.Status == OrderStatus.Выполняется))
                    .Select(CreateModel).ToList();
            }
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new SecureShopDatabase())
            {
                var order = context.Orders
                    .Include(rec => rec.Equipment)
                    .Include(rec => rec.Client)
                    .Include(rec => rec.Implementer)
                    .FirstOrDefault(rec => rec.Id == model.Id);

                return order != null ?
                    CreateModel(order) :
                    null;
            }
        }
        public void Insert(OrderBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                context.Orders.Add(CreateModel(model, new Order()));
                context.SaveChanges();
            }
        }
        public void Update(OrderBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                var order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);

                if (order == null)
                {
                    throw new Exception("Заказ не найден");
                }

                CreateModel(model, order);
                context.SaveChanges();
            }
        }
        public void Delete(OrderBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                var order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);

                if (order == null)
                {
                    throw new Exception("Заказ не найден");
                }

                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }
        private OrderViewModel CreateModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                EquipmentId = order.EquipmentId,
                ClientId = order.ClientId.Value,
                ImplementerId = order.ImplementerId,
                ClientFIO = order.Client.ClientFIO,
                EquipmentName = order.Equipment.EquipmentName,
                Count = order.Count,
                Sum = order.Sum,
                Status = order.Status,
                DateCreate = order.DateCreate,
                DateImplement = order?.DateImplement,
                ImplementerName = order.ImplementerId.HasValue ?
                    order.Implementer.Name : string.Empty
            };
        }

        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.EquipmentId = model.EquipmentId;
            order.ClientId = model.ClientId.Value;
            order.ImplementerId = model.ImplementerId;
            order.Count = model.Count;
            order.Status = model.Status;
            order.Sum = model.Sum;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }
    }
}