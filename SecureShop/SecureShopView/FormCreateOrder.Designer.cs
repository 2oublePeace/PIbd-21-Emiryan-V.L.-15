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
			this.button2 = new System.Windows.Forms.Button();
			this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
			this.textBoxSum = new System.Windows.Forms.TextBox();
			this.textBoxCount = new System.Windows.Forms.TextBox();
			this.equipmentLbl = new System.Windows.Forms.Label();
			this.countLbl = new System.Windows.Forms.Label();
			this.sumLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(189, 87);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 25);
			this.saveBtn.TabIndex = 0;
			this.saveBtn.Text = "Сохранить";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(270, 87);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 25);
			this.button2.TabIndex = 1;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// comboBoxEquipment
			// 
			this.comboBoxEquipment.FormattingEnabled = true;
			this.comboBoxEquipment.Location = new System.Drawing.Point(102, 6);
			this.comboBoxEquipment.Name = "comboBoxEquipment";
			this.comboBoxEquipment.Size = new System.Drawing.Size(243, 21);
			this.comboBoxEquipment.TabIndex = 2;
			// 
			// textBoxSum
			// 
			this.textBoxSum.Location = new System.Drawing.Point(102, 61);
			this.textBoxSum.Name = "textBoxSum";
			this.textBoxSum.Size = new System.Drawing.Size(243, 20);
			this.textBoxSum.TabIndex = 3;
			// 
			// textBoxCount
			// 
			this.textBoxCount.Location = new System.Drawing.Point(102, 34);
			this.textBoxCount.Name = "textBoxCount";
			this.textBoxCount.Size = new System.Drawing.Size(243, 20);
			this.textBoxCount.TabIndex = 4;
			// 
			// equipmentLbl
			// 
			this.equipmentLbl.AutoSize = true;
			this.equipmentLbl.Location = new System.Drawing.Point(12, 9);
			this.equipmentLbl.Name = "equipmentLbl";
			this.equipmentLbl.Size = new System.Drawing.Size(84, 13);
			this.equipmentLbl.TabIndex = 5;
			this.equipmentLbl.Text = "Комплектация:";
			// 
			// countLbl
			// 
			this.countLbl.AutoSize = true;
			this.countLbl.Location = new System.Drawing.Point(12, 37);
			this.countLbl.Name = "countLbl";
			this.countLbl.Size = new System.Drawing.Size(69, 13);
			this.countLbl.TabIndex = 6;
			this.countLbl.Text = "Количество:";
			// 
			// sumLbl
			// 
			this.sumLbl.AutoSize = true;
			this.sumLbl.Location = new System.Drawing.Point(12, 64);
			this.sumLbl.Name = "sumLbl";
			this.sumLbl.Size = new System.Drawing.Size(44, 13);
			this.sumLbl.TabIndex = 7;
			this.sumLbl.Text = "Сумма:";
			// 
			// FormCreateOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 121);
			this.Controls.Add(this.sumLbl);
			this.Controls.Add(this.countLbl);
			this.Controls.Add(this.equipmentLbl);
			this.Controls.Add(this.textBoxCount);
			this.Controls.Add(this.textBoxSum);
			this.Controls.Add(this.comboBoxEquipment);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.saveBtn);
			this.Name = "FormCreateOrder";
			this.Text = "Заказ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBoxEquipment;
		private System.Windows.Forms.TextBox textBoxSum;
		private System.Windows.Forms.TextBox textBoxCount;
		private System.Windows.Forms.Label equipmentLbl;
		private System.Windows.Forms.Label countLbl;
		private System.Windows.Forms.Label sumLbl;
	}
}