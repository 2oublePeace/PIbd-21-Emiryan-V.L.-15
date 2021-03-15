
namespace SecureShopView
{
	partial class FormEquipmentDevice
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
			this.feSaveBtn = new System.Windows.Forms.Button();
			this.feCancelBtn = new System.Windows.Forms.Button();
			this.deviceCBLbl = new System.Windows.Forms.Label();
			this.countLbl = new System.Windows.Forms.Label();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.textBoxCount = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// feSaveBtn
			// 
			this.feSaveBtn.Location = new System.Drawing.Point(167, 68);
			this.feSaveBtn.Name = "feSaveBtn";
			this.feSaveBtn.Size = new System.Drawing.Size(75, 25);
			this.feSaveBtn.TabIndex = 0;
			this.feSaveBtn.Text = "Сохранить";
			this.feSaveBtn.UseVisualStyleBackColor = true;
			// 
			// feCancelBtn
			// 
			this.feCancelBtn.Location = new System.Drawing.Point(248, 68);
			this.feCancelBtn.Name = "feCancelBtn";
			this.feCancelBtn.Size = new System.Drawing.Size(75, 25);
			this.feCancelBtn.TabIndex = 1;
			this.feCancelBtn.Text = "Отмена";
			this.feCancelBtn.UseVisualStyleBackColor = true;
			// 
			// deviceCBLbl
			// 
			this.deviceCBLbl.AutoSize = true;
			this.deviceCBLbl.Location = new System.Drawing.Point(12, 9);
			this.deviceCBLbl.Name = "deviceCBLbl";
			this.deviceCBLbl.Size = new System.Drawing.Size(58, 15);
			this.deviceCBLbl.TabIndex = 2;
			this.deviceCBLbl.Text = "Девайсы:";
			// 
			// countLbl
			// 
			this.countLbl.AutoSize = true;
			this.countLbl.Location = new System.Drawing.Point(12, 42);
			this.countLbl.Name = "countLbl";
			this.countLbl.Size = new System.Drawing.Size(75, 15);
			this.countLbl.TabIndex = 3;
			this.countLbl.Text = "Количество:";
			// 
			// comboBox
			// 
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(93, 6);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(230, 23);
			this.comboBox.TabIndex = 4;
			// 
			// textBoxCount
			// 
			this.textBoxCount.Location = new System.Drawing.Point(93, 39);
			this.textBoxCount.Name = "textBoxCount";
			this.textBoxCount.Size = new System.Drawing.Size(230, 23);
			this.textBoxCount.TabIndex = 5;
			// 
			// FormEquipmentDevice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 108);
			this.Controls.Add(this.textBoxCount);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.countLbl);
			this.Controls.Add(this.deviceCBLbl);
			this.Controls.Add(this.feCancelBtn);
			this.Controls.Add(this.feSaveBtn);
			this.Name = "FormEquipmentDevice";
			this.Text = "Девайс комплектации";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button feSaveBtn;
		private System.Windows.Forms.Button feCancelBtn;
		private System.Windows.Forms.Label deviceComboBox;
		private System.Windows.Forms.Label countLbl;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.TextBox textBoxCount;
		private System.Windows.Forms.Label deviceCBLbl;
	}
}