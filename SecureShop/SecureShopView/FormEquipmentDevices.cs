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
using SecureShopBusinessLogic.ViewModels;
using Unity;

namespace SecureShopView
{
	public partial class FormEquipmentDevices : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }
		public int Id
		{
			get { return Convert.ToInt32(comboBoxDevice.SelectedValue); }
			set { comboBoxDevice.SelectedValue = value; }
		}
		public string ComponentName { get { return comboBoxDevice.Text; } }
		public int Count
		{
			get { return Convert.ToInt32(textBoxCount.Text); }
			set
			{
				textBoxCount.Text = value.ToString();
			}
		}
		public FormEquipmentDevices(DeviceLogic logic)
		{
			InitializeComponent();
			List<DeviceViewModel> list = logic.Read(null);
			if (list != null)
			{
				comboBoxDevice.DisplayMember = "ComponentName";
				comboBoxDevice.ValueMember = "Id";
				comboBoxDevice.DataSource = list;
				comboBoxDevice.SelectedItem = null;
			}
		}
		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxCount.Text))
			{
				MessageBox.Show("Заполните поле Количество", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (comboBoxDevice.SelectedValue == null)
			{
				MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
		    }
			DialogResult = DialogResult.OK;
			Close();
		}
		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

	}
}
