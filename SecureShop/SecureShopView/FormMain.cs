using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.BusinessLogics;

namespace SecureShopView
{
	public partial class FormMain : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }
		private readonly OrderLogic _orderLogic;
		private readonly ReportLogic _reportLogic;
		private readonly WorkModeling _workModeling;
		public FormMain(OrderLogic orderLogic, ReportLogic reportLogic, WorkModeling workModeling)
		{
			InitializeComponent();
			_orderLogic = orderLogic;
			_reportLogic = reportLogic;
			_workModeling = workModeling;
			LoadData();
		}
		private void FormMain_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void LoadData()
		{
			try
			{
				var list = _orderLogic.Read(null);
				if (list != null)
				{
					dataGridView.DataSource = list;
					dataGridView.Columns[0].Visible = false;
					dataGridView.Columns[1].Visible = false;
					dataGridView.Columns[2].Visible = false;
					dataGridView.Columns[3].Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void DevicesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormDevices>();
			form.ShowDialog();
		}
		private void EquipmentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormEquipments>();
			form.ShowDialog();
		}
		private void ButtonCreateOrder_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormCreateOrder>();
			form.ShowDialog();
			LoadData();
		}
		private void ButtonTakeOrderInWork_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
				try
				{
					_orderLogic.TakeOrderInWork(new ChangeStatusBindingModel { OrderId = id });
					LoadData();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void ButtonOrderReady_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
				try
				{
					_orderLogic.FinishOrder(new ChangeStatusBindingModel { OrderId = id });
					LoadData();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void ButtonPayOrder_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
				try
				{
					_orderLogic.PayOrder(new ChangeStatusBindingModel { OrderId = id });
					LoadData();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void DevicesToolStripMenuReportItem_Click(object sender, EventArgs e)
		{
			using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					_reportLogic.SaveDevicesToWordFile(new ReportBindingModel
					{
						FileName = dialog.FileName
					});
					MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void DeviceEquipmentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormReportEquipmentDevices>(); form.ShowDialog();
		}

		private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormReportOrders>(); form.ShowDialog();
		}

		private void ButtonRef_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormClients>();
			form.ShowDialog();
		}

		private void ImplementersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormImplementers>();
			form.ShowDialog();
		}

		private void StartWorkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_workModeling.DoWork();
			LoadData();
		}

		private void MessagesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormMessages>();
			form.ShowDialog();
		}
	}
}
