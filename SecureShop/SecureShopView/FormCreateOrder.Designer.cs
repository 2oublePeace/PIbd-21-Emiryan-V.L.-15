namespace SecureShopView
{
	partial class FormCreateOrder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.saveBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
			this.textBoxSum = new System.Windows.Forms.TextBox();
			this.textBoxCount = new System.Windows.Forms.TextBox();
			this.equipmentLbl = new System.Windows.Forms.Label();
			this.countLbl = new System.Windows.Forms.Label();
			this.sumLbl = new System.Windows.Forms.Label();
			this.comboBoxClient = new System.Windows.Forms.ComboBox();
			this.clientLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(284, 167);
			this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(112, 38);
			this.saveBtn.TabIndex = 0;
			this.saveBtn.Text = "Сохранить";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(405, 167);
			this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(112, 38);
			this.cancelBtn.TabIndex = 1;
			this.cancelBtn.Text = "Отмена";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// comboBoxEquipment
			// 
			this.comboBoxEquipment.FormattingEnabled = true;
			this.comboBoxEquipment.Location = new System.Drawing.Point(153, 9);
			this.comboBoxEquipment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxEquipment.Name = "comboBoxEquipment";
			this.comboBoxEquipment.Size = new System.Drawing.Size(362, 28);
			this.comboBoxEquipment.TabIndex = 2;
			this.comboBoxEquipment.Click += new System.EventHandler(this.ComboBoxEquipment_SelectedIndexChanged);
			// 
			// textBoxSum
			// 
			this.textBoxSum.Location = new System.Drawing.Point(153, 127);
			this.textBoxSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxSum.Name = "textBoxSum";
			this.textBoxSum.Size = new System.Drawing.Size(362, 26);
			this.textBoxSum.TabIndex = 3;
			this.textBoxSum.Click += new System.EventHandler(this.TextBoxCount_TextChanged);
			// 
			// textBoxCount
			// 
			this.textBoxCount.Location = new System.Drawing.Point(153, 85);
			this.textBoxCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxCount.Name = "textBoxCount";
			this.textBoxCount.Size = new System.Drawing.Size(362, 26);
			this.textBoxCount.TabIndex = 4;
			this.textBoxCount.Click += new System.EventHandler(this.TextBoxCount_TextChanged);
			// 
			// equipmentLbl
			// 
			this.equipmentLbl.AutoSize = true;
			this.equipmentLbl.Location = new System.Drawing.Point(18, 14);
			this.equipmentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.equipmentLbl.Name = "equipmentLbl";
			this.equipmentLbl.Size = new System.Drawing.Size(124, 20);
			this.equipmentLbl.TabIndex = 5;
			this.equipmentLbl.Text = "Комплектация:";
			// 
			// countLbl
			// 
			this.countLbl.AutoSize = true;
			this.countLbl.Location = new System.Drawing.Point(18, 90);
			this.countLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.countLbl.Name = "countLbl";
			this.countLbl.Size = new System.Drawing.Size(104, 20);
			this.countLbl.TabIndex = 6;
			this.countLbl.Text = "Количество:";
			// 
			// sumLbl
			// 
			this.sumLbl.AutoSize = true;
			this.sumLbl.Location = new System.Drawing.Point(18, 131);
			this.sumLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.sumLbl.Name = "sumLbl";
			this.sumLbl.Size = new System.Drawing.Size(62, 20);
			this.sumLbl.TabIndex = 7;
			this.sumLbl.Text = "Сумма:";
			// 
			// comboBoxClient
			// 
			this.comboBoxClient.FormattingEnabled = true;
			this.comboBoxClient.Location = new System.Drawing.Point(153, 45);
			this.comboBoxClient.Name = "comboBoxClient";
			this.comboBoxClient.Size = new System.Drawing.Size(364, 28);
			this.comboBoxClient.TabIndex = 8;
			// 
			// clientLbl
			// 
			this.clientLbl.AutoSize = true;
			this.clientLbl.Location = new System.Drawing.Point(18, 53);
			this.clientLbl.Name = "clientLbl";
			this.clientLbl.Size = new System.Drawing.Size(69, 20);
			this.clientLbl.TabIndex = 9;
			this.clientLbl.Text = "Клиент:";
			// 
			// FormCreateOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 224);
			this.Controls.Add(this.clientLbl);
			this.Controls.Add(this.comboBoxClient);
			this.Controls.Add(this.sumLbl);
			this.Controls.Add(this.countLbl);
			this.Controls.Add(this.equipmentLbl);
			this.Controls.Add(this.textBoxCount);
			this.Controls.Add(this.textBoxSum);
			this.Controls.Add(this.comboBoxEquipment);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.saveBtn);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormCreateOrder";
			this.Text = "Создать заказ";
			this.Load += new System.EventHandler(this.FormCreateOrder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.ComboBox comboBoxEquipment;
		private System.Windows.Forms.TextBox textBoxSum;
		private System.Windows.Forms.TextBox textBoxCount;
		private System.Windows.Forms.Label equipmentLbl;
		private System.Windows.Forms.Label countLbl;
		private System.Windows.Forms.Label sumLbl;
		private System.Windows.Forms.ComboBox comboBoxClient;
		private System.Windows.Forms.Label clientLbl;
	}
}