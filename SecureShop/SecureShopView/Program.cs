using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using SecureShopBusinessLogic.BusinessLogics;
using SecureShopBusinessLogic.Interfaces;
using SecureShopFileImplement.Implements;
using Unity.Lifetime;

namespace SecureShopView
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var container = BuildUnityContainer();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(container.Resolve<FormMain>());
		}

		private static IUnityContainer BuildUnityContainer()
		{
			var currentContainer = new UnityContainer();
			currentContainer.RegisterType<IDeviceStorage, DeviceStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IOrderStorage, OrderStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IEquipmentStorage, EquipmentStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<DeviceLogic>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<OrderLogic>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<EquipmentLogic>(new HierarchicalLifetimeManager());
			return currentContainer;
		}
	}
}
