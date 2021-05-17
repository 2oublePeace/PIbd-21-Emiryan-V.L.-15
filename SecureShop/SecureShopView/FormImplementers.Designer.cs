namespace SecureShopView
{
	partial class FormImplementers
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
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(954, 311);
			this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(222, 35);
			this.buttonRefresh.TabIndex = 9;
			this.buttonRefresh.Text = "Обновить";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.ButtonUpdate_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(954, 214);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(222, 35);
			this.buttonDelete.TabIndex = 8;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(956, 117);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(222, 35);
			this.buttonEdit.TabIndex = 7;
			this.buttonEdit.Text = "Изменить";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(956, 20);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(222, 35);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(20, 20);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.Size = new System.Drawing.Size(926, 654);
			this.dataGridView.TabIndex = 5;
			// 
			// FormImplementers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridView);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormImplementers";
			this.Text = "Исполнители";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}