
namespace SecureShopView
{
	partial class FormDevices
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.devicesAddBtn = new System.Windows.Forms.Button();
			this.devicesEditBtn = new System.Windows.Forms.Button();
			this.devicesDeleteBtn = new System.Windows.Forms.Button();
			this.devicesUpdateBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 25;
			this.dataGridView.Size = new System.Drawing.Size(430, 426);
			this.dataGridView.TabIndex = 0;
			// 
			// devicesAddBtn
			// 
			this.devicesAddBtn.Location = new System.Drawing.Point(470, 12);
			this.devicesAddBtn.Name = "devicesAddBtn";
			this.devicesAddBtn.Size = new System.Drawing.Size(75, 25);
			this.devicesAddBtn.TabIndex = 1;
			this.devicesAddBtn.Text = "Добавить";
			this.devicesAddBtn.UseVisualStyleBackColor = true;
			// 
			// devicesEditBtn
			// 
			this.devicesEditBtn.Location = new System.Drawing.Point(470, 60);
			this.devicesEditBtn.Name = "devicesEditBtn";
			this.devicesEditBtn.Size = new System.Drawing.Size(75, 25);
			this.devicesEditBtn.TabIndex = 2;
			this.devicesEditBtn.Text = "Изменить";
			this.devicesEditBtn.UseVisualStyleBackColor = true;
			// 
			// devicesDeleteBtn
			// 
			this.devicesDeleteBtn.Location = new System.Drawing.Point(470, 111);
			this.devicesDeleteBtn.Name = "devicesDeleteBtn";
			this.devicesDeleteBtn.Size = new System.Drawing.Size(75, 25);
			this.devicesDeleteBtn.TabIndex = 3;
			this.devicesDeleteBtn.Text = "Удалить";
			this.devicesDeleteBtn.UseVisualStyleBackColor = true;
			// 
			// devicesUpdateBtn
			// 
			this.devicesUpdateBtn.Location = new System.Drawing.Point(470, 169);
			this.devicesUpdateBtn.Name = "devicesUpdateBtn";
			this.devicesUpdateBtn.Size = new System.Drawing.Size(75, 25);
			this.devicesUpdateBtn.TabIndex = 4;
			this.devicesUpdateBtn.Text = "Обновить";
			this.devicesUpdateBtn.UseVisualStyleBackColor = true;
			// 
			// FormDevices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 450);
			this.Controls.Add(this.devicesUpdateBtn);
			this.Controls.Add(this.devicesDeleteBtn);
			this.Controls.Add(this.devicesEditBtn);
			this.Controls.Add(this.devicesAddBtn);
			this.Controls.Add(this.dataGridView);
			this.Name = "FormDevices";
			this.Text = "FormDevices";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button devicesAddBtn;
		private System.Windows.Forms.Button devicesEditBtn;
		private System.Windows.Forms.Button devicesDeleteBtn;
		private System.Windows.Forms.Button devicesUpdateBtn;
	}
}