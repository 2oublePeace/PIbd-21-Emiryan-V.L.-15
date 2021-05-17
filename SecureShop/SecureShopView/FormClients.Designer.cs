
namespace SecureShopView
{
	partial class FormClients
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
			this.delBtn = new System.Windows.Forms.Button();
			this.updateBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(776, 388);
			this.dataGridView.TabIndex = 0;
			// 
			// delBtn
			// 
			this.delBtn.Location = new System.Drawing.Point(675, 406);
			this.delBtn.Name = "delBtn";
			this.delBtn.Size = new System.Drawing.Size(113, 32);
			this.delBtn.TabIndex = 1;
			this.delBtn.Text = "Удалить";
			this.delBtn.UseVisualStyleBackColor = true;
			this.delBtn.Click += new System.EventHandler(this.ButtonDelete_Click);
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(553, 406);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(113, 32);
			this.updateBtn.TabIndex = 2;
			this.updateBtn.Text = "Обновить";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.ButtonUpdate_Click);
			// 
			// FormClients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.delBtn);
			this.Controls.Add(this.dataGridView);
			this.Name = "FormClients";
			this.Text = "FormClients";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button delBtn;
		private System.Windows.Forms.Button updateBtn;
	}
}