using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.BusinessLogics;
using Unity;

namespace SecureShopView
{
	public partial class FormDevice : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }
		public int Id { set { id = value; } }
		private readonly DeviceLogic logic;
		private int? id;
		public FormDevice(DeviceLogic logic)
		{
			InitializeComponent();
			this.logic = logic;
		}
		private void FormDevice_Load(object sender, EventArgs e)
		{
			if (id.HasValue)
			{
				try
				{
					var view = logic.Read(new DeviceBindingModel { Id = id })?[0];
					if (view != null)
					{
						deviceTextBox.Text = view.ComponentName;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
			}
		}
		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(deviceTextBox.Text))
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
				return;
			}
			try
			{
				logic.CreateOrUpdate(new DeviceBindingModel
				{
					Id = id,
					ComponentName = deviceTextBox.Text
				});
				MessageBox.Show("Сохранение прошло успешно", "Сообщение",
			   MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
			}
		}
		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
