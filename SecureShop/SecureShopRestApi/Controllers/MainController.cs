using Microsoft.AspNetCore.Mvc;
using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.BusinessLogics;
using SecureShopBusinessLogic.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SecureShopRestApi.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class MainController : ControllerBase
	{
		private readonly OrderLogic _order; private readonly EquipmentLogic _equipment; private readonly OrderLogic _main;
		public MainController(OrderLogic order, EquipmentLogic equipment, OrderLogic main)
		{
			_order = order;
			_equipment = equipment;
			_main = main;
		}

		[HttpGet]
		public List<EquipmentViewModel> GetEquipmentList() => _equipment.Read(null)?.ToList();

		[HttpGet]
		public EquipmentViewModel GetEquipment(int equipmentId) => _equipment.Read(new EquipmentBindingModel { Id = equipmentId })?[0];

		[HttpGet]
		public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new OrderBindingModel { ClientId = clientId });

		[HttpPost]
		public void CreateOrder(CreateOrderBindingModel model) =>
		_main.CreateOrder(model);
	}
}

