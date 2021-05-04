
namespace SecureShopView
{
	partial class FormReportEquipmentDevices
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
			this.saveInExcelBtn = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// saveInExcelBtn
			// 
			this.saveInExcelBtn.Location = new System.Drawing.Point(12, 12);
			this.saveInExcelBtn.Name = "saveInExcelBtn";
			this.saveInExcelBtn.Size = new System.Drawing.Size(143, 20);
			this.saveInExcelBtn.TabIndex = 0;
			this.saveInExcelBtn.Text = "Сохранить в Excel";
			this.saveInExcelBtn.UseVisualStyleBackColor = true;
			this.saveInExcelBtn.Click += new System.EventHandler(this.ButtonSaveToExcel_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 38);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(442, 400);
			this.dataGridView.TabIndex = 1;
			// 
			// FormReportEquipmentDevices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 450);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.saveInExcelBtn);
			this.Name = "FormReportEquipmentDevices";
			this.Text = "FormReportEquipmentDevices";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button saveInExcelBtn;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}