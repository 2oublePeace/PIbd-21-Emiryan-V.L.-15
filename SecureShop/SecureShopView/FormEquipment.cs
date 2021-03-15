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
using SecureShopBusinessLogic.ViewModels;


namespace SecureShopView
{
	public partial class FormEquipment : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }
		public int Id { set { id = value; } }
		private readonly EquipmentLogic logic;
		private int? id;
		private Dictionary<int, (string, int)> equipmentDevices;
		public FormEquipment(EquipmentLogic service)
		{
			InitializeComponent();
			this.logic = service;
		}
		private void FormProduct_Load(object sender, EventArgs e)
		{
			if (id.HasValue)
			{
				try
				{
					EquipmentViewModel view = logic.Read(new EquipmentBindingModel { Id = id.Value })?[0];
					if (view != null)
					{
						textBoxName.Text = view.EquipmentName;
						textBoxPrice.Text = view.Price.ToString();
						equipmentDevices = view.EquipmentDevices;
						LoadData();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
			}
			else
			{
				equipmentDevices = new Dictionary<int, (string, int)>();
			}
		}
		private void LoadData()
		{
			try
			{
				if (equipmentDevices != null)
				{
					dataGridView.Rows.Clear();
					foreach (var pc in equipmentDevices)
					{
						dataGridView.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2 });
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
			}
		}
		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormEquipmentDevice>();
			if (form.ShowDialog() == DialogResult.OK)
			{
				if (equipmentDevices.ContainsKey(form.Id))
				{
					equipmentDevices[form.Id] = (form.ComponentName, form.Count);
				}
				else
				{
					equipmentDevices.Add(form.Id, (form.ComponentName, form.Count));
				}
				LoadData();
			}
		}
		private void ButtonUpd_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				var form = Container.Resolve<FormEquipmentDevice>();
				int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
				form.Id = id;
				form.Count = equipmentDevices[id].Item2;
				if (form.ShowDialog() == DialogResult.OK)
				{
					equipmentDevices[form.Id] = (form.ComponentName, form.Count);
					LoadData();
				}
			}
		}
		private void ButtonDel_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
			   MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{

						equipmentDevices.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
					}
					LoadData();
				}
			}
		}
		private void ButtonRef_Click(object sender, EventArgs e)
		{
			LoadData();
		}
		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxName.Text))
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxPrice.Text))
			{
				MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
				return;
			}
			if (equipmentDevices == null || equipmentDevices.Count == 0)
			{
				MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
				return;
			}
			try
			{
				logic.CreateOrUpdate(new EquipmentBindingModel
				{
					Id = id,
				    EquipmentName = textBoxName.Text,
					Price = Convert.ToDecimal(textBoxPrice.Text),
					EquipmentDevices = equipmentDevices
				});
				MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); 
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
