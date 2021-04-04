
namespace SecureShopView
{
	partial class FormEquipment
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
			this.nameLbl = new System.Windows.Forms.Label();
			this.priceLbl = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.updateBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			this.addBtn = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.deviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deviceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saveBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Location = new System.Drawing.Point(16, 9);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(60, 13);
			this.nameLbl.TabIndex = 0;
			this.nameLbl.Text = "Название:";
			// 
			// priceLbl
			// 
			this.priceLbl.AutoSize = true;
			this.priceLbl.Location = new System.Drawing.Point(16, 41);
			this.priceLbl.Name = "priceLbl";
			this.priceLbl.Size = new System.Drawing.Size(36, 13);
			this.priceLbl.TabIndex = 1;
			this.priceLbl.Text = "Цена:";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(81, 38);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(181, 20);
			this.textBoxPrice.TabIndex = 2;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(81, 6);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(181, 20);
			this.textBoxName.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.updateBtn);
			this.groupBox1.Controls.Add(this.deleteBtn);
			this.groupBox1.Controls.Add(this.editBtn);
			this.groupBox1.Controls.Add(this.addBtn);
			this.groupBox1.Controls.Add(this.dataGridView);
			this.groupBox1.Location = new System.Drawing.Point(12, 61);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(620, 331);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Компоненты";
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(483, 216);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(75, 23);
			this.updateBtn.TabIndex = 4;
			this.updateBtn.Text = "Обновить";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.ButtonUpdate_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(483, 156);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteBtn.TabIndex = 3;
			this.deleteBtn.Text = "Удалить";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.ButtonDel_Click);
			// 
			// editBtn
			// 
			this.editBtn.Location = new System.Drawing.Point(483, 100);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(75, 23);
			this.editBtn.TabIndex = 2;
			this.editBtn.Text = "Изменить";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.ButtonEdit_Click);
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(483, 47);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 1;
			this.addBtn.Text = "Добавить";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceID,
            this.deviceColumn,
            this.countColumn});
			this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView.Location = new System.Drawing.Point(7, 19);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(465, 260);
			this.dataGridView.TabIndex = 0;
			// 
			// deviceID
			// 
			this.deviceID.HeaderText = "ID";
			this.deviceID.Name = "deviceID";
			this.deviceID.Visible = false;
			// 
			// deviceColumn
			// 
			this.deviceColumn.HeaderText = "Устройство";
			this.deviceColumn.Name = "deviceColumn";
			this.deviceColumn.Width = 200;
			// 
			// countColumn
			// 
			this.countColumn.HeaderText = "Количество";
			this.countColumn.Name = "countColumn";
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(476, 398);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 5;
			this.saveBtn.Text = "Сохранить";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(557, 398);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 6;
			this.cancelBtn.Text = "Отмена";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// FormEquipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.priceLbl);
			this.Controls.Add(this.nameLbl);
			this.Name = "FormEquipment";
			this.Text = "FormEquipment";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLbl;
		private System.Windows.Forms.Label priceLbl;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn deviceID;
		private System.Windows.Forms.DataGridViewTextBoxColumn deviceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countColumn;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button cancelBtn;
	}
}