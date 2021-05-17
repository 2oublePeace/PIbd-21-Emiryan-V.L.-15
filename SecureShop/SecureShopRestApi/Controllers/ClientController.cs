using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.BusinessLogics;
using SecureShopBusinessLogic.ViewModels;
using Microsoft.AspNetCore.Mvc;
using GiftShopBusinessLogic.BusinessLogics;

namespace SecureShopRestApi.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class ClientController : ControllerBase
	{
		private readonly ClientLogic _logic;

		public ClientController(ClientLogic logic)
		{
			_logic = logic;
		}
		[HttpGet]
		public ClientViewModel Login(string login, string password) => _logic.Read(new ClientBindingModel { Email = login, Password = password })?[0];

		[HttpPost]
		public void Register(ClientBindingModel model) => _logic.CreateOrUpdate(model);

		[HttpPost]
		public void UpdateData(ClientBindingModel model) => _logic.CreateOrUpdate(model);
	}
}
