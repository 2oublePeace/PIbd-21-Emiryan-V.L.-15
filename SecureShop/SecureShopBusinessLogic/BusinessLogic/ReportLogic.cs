using System;
using System.Collections.Generic;
using System.Text;
using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.HelperModels;
using SecureShopBusinessLogic.Interfaces;
using SecureShopBusinessLogic.ViewModels;
using System.Linq;
using SecureShopBusinessLogic.BusinessLogics;

namespace SecureShopBusinessLogic.BusinessLogics
{
	public class ReportLogic
	{
		private readonly IDeviceStorage _deviceStorage; private readonly IEquipmentStorage _equipmentStorage; private readonly IOrderStorage _orderStorage;
		public ReportLogic(IEquipmentStorage equipmentStorage, IDeviceStorage deviceStorage, IOrderStorage orderStorage)
		{
			_equipmentStorage = equipmentStorage;
			_deviceStorage = deviceStorage;
			_orderStorage = orderStorage;
		}
		/// <summary>
		/// Получение списка компонент с указанием, в каких изделиях используются
		/// </summary>
		/// <returns></returns>
		public List<ReportEquipmentDeviceViewModel> GetEquipmentDevice()
		{
			var devices = _deviceStorage.GetFullList(); var equipments = _equipmentStorage.GetFullList();
			var list = new List<ReportEquipmentDeviceViewModel>();

			foreach (var device in devices)
			{
				var record = new ReportEquipmentDeviceViewModel
				{
					DeviceName = device.DeviceName,
					Equipments = new List<Tuple<string, int>>(),
					TotalCount = 0
				};
				foreach (var equipment in equipments)
				{
					if (equipment.EquipmentDevices.ContainsKey(device.Id))
					{
						record.Equipments.Add(new Tuple<string, int>(equipment.EquipmentName, equipment.EquipmentDevices[device.Id].Item2));
						record.TotalCount += equipment.EquipmentDevices[device.Id].Item2;
					}
				}

				list.Add(record);
			}

			return list;
		}
		/// <summary>
		/// Получение списка заказов за определенный период
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
		{
			return _orderStorage.GetFilteredList(new OrderBindingModel { DateFrom = model.DateFrom, DateTo = model.DateTo })
			.Select(x => new ReportOrdersViewModel
			{
				DateCreate = x.DateCreate,
				EquipmentName = x.EquipmentName,
				Count = x.Count,
				Sum = x.Sum,
				Status = x.Status
			})
			.ToList();
		}
		/// <summary>
		/// Сохранение компонент в файл-Word
		/// </summary>
		/// <param name="model"></param>
		public void SaveMaterialsToWordFile(ReportBindingModel model)
		{
			SaveToWord.CreateDoc(new WordInfo
			{
				FileName = model.FileName,
				Title = "Список подарков",
				Devices = _deviceStorage.GetFullList()
			});
		}
		/// <summary>
		/// Сохранение компонент с указаеним продуктов в файл-Excel
		/// </summary>
		/// <param name="model"></param>
		public void SaveEquipmentDeviceToExcelFile(ReportBindingModel model)
		{
			SaveToExcel.CreateDoc(new ExcelInfo
			{
				FileName = model.FileName,
				Title = "Список компонент",
				EquipmentDevices = GetEquipmentDevice()
			});
		}

		/// <summary>
		/// Сохранение заказов в файл-Pdf
		/// </summary>
		/// <param name="model"></param>
		public void SaveOrdersToPdfFile(ReportBindingModel model)
		{
			SaveToPdf.CreateDoc(new PdfInfo
			{
				FileName = model.FileName,
				Title = "Список заказов",
				DateFrom = model.DateFrom.Value,
				DateTo = model.DateTo.Value,
				Orders = GetOrders(model)
			});
		}
	}
}
