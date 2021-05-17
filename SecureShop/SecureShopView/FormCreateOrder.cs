﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.BusinessLogics;
using SecureShopBusinessLogic.ViewModels;
using Unity;


namespace SecureShopView
{
    public partial class FormCreateOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly EquipmentLogic _logicP;
        private readonly OrderLogic _logicO;
        private readonly ClientLogic _logicC;
        public FormCreateOrder(EquipmentLogic logicE, OrderLogic logicO, ClientLogic logicC)
        {
            InitializeComponent();
            _logicP = logicE;
            _logicO = logicO;
            _logicC = logicC;
        }
        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<EquipmentViewModel> list = _logicP.Read(null);
                if (list != null)
                {
                    comboBoxEquipment.DisplayMember = "EquipmentName";
                    comboBoxEquipment.ValueMember = "Id";
                    comboBoxEquipment.DataSource = list;
                    comboBoxEquipment.SelectedItem = null;
                }
                List<ClientViewModel> listClients = _logicC.Read(null);
                if (listClients != null)
                {
                    comboBoxClient.DisplayMember = "ClientFIO";
                    comboBoxClient.ValueMember = "Id";
                    comboBoxClient.DataSource = listClients;
                    comboBoxClient.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalcSum()
        {
            if (comboBoxEquipment.SelectedValue != null && !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxEquipment.SelectedValue);
                    EquipmentViewModel equipment = _logicP.Read(new EquipmentBindingModel { Id = id })?[0];
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSum.Text = (count * equipment?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void TextBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ComboBoxEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxEquipment.SelectedValue == null)
            {
                MessageBox.Show("Выберите комплектацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicO.CreateOrder(new CreateOrderBindingModel
                {
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                    EquipmentId = Convert.ToInt32(comboBoxEquipment.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}