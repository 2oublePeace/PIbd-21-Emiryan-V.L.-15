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
using SecureShopBusinessLogic.BusinessLogics;
using SecureShopBusinessLogic.ViewModels;

namespace SecureShopView
{
	public partial class FormEquipmentDevice : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }
		public int Id
		{
			get { return Convert.ToInt32(comboBox.SelectedValue); }
			set { comboBox.SelectedValue = value; }
		}
		public string ComponentName { get { return comboBox.Text; } }
		public int Count
		{
			get { return Convert.ToInt32(textBoxCount.Text); }
			set
			{
				textBoxCount.Text = value.ToString();
			}
		}
		public FormEquipmentDevice(DeviceLogic logic)
		{
			InitializeComponent();
			List<DeviceViewModel> list = logic.Read(null);
			if (list != null)
			{
				comboBox.DisplayMember = "ComponentName";
				comboBox.ValueMember = "Id";
				comboBox.DataSource = list;
				comboBox.SelectedItem = null;
			}
		}
		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(countLbl.Text))
			{
				MessageBox.Show("Заполните поле Количество", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (comboBox.SelectedValue == null)
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
