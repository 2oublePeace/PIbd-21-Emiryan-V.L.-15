
namespace SecureShopView
{
	partial class FormMain
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
			this.topMenuStrip = new System.Windows.Forms.MenuStrip();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.устройстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.комплектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.createOrderBtn = new System.Windows.Forms.Button();
			this.takeToExecutionBtn = new System.Windows.Forms.Button();
			this.orderReadyBtn = new System.Windows.Forms.Button();
			this.orderPayed = new System.Windows.Forms.Button();
			this.updateList = new System.Windows.Forms.Button();
			this.topMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// topMenuStrip
			// 
			this.topMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
			this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.topMenuStrip.Name = "topMenuStrip";
			this.topMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
			this.topMenuStrip.Size = new System.Drawing.Size(1305, 35);
			this.topMenuStrip.TabIndex = 0;
			this.topMenuStrip.Text = "menuStrip1";
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.устройстваToolStripMenuItem,
            this.комплектыToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
			this.справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// устройстваToolStripMenuItem
			// 
			this.устройстваToolStripMenuItem.Name = "устройстваToolStripMenuItem";
			this.устройстваToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
			this.устройстваToolStripMenuItem.Text = "Устройства";
			this.устройстваToolStripMenuItem.Click += new System.EventHandler(this.DevicesToolStripMenuItem_Click);
			// 
			// комплектыToolStripMenuItem
			// 
			this.комплектыToolStripMenuItem.Name = "комплектыToolStripMenuItem";
			this.комплектыToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
			this.комплектыToolStripMenuItem.Text = "Комплекты";
			this.комплектыToolStripMenuItem.Click += new System.EventHandler(this.EquipmentsToolStripMenuItem_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(18, 42);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.Size = new System.Drawing.Size(951, 632);
			this.dataGridView.TabIndex = 1;
			// 
			// createOrderBtn
			// 
			this.createOrderBtn.Location = new System.Drawing.Point(1024, 185);
			this.createOrderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.createOrderBtn.Name = "createOrderBtn";
			this.createOrderBtn.Size = new System.Drawing.Size(222, 35);
			this.createOrderBtn.TabIndex = 2;
			this.createOrderBtn.Text = "Создать заказ";
			this.createOrderBtn.UseVisualStyleBackColor = true;
			this.createOrderBtn.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
			// 
			// takeToExecutionBtn
			// 
			this.takeToExecutionBtn.Location = new System.Drawing.Point(1024, 262);
			this.takeToExecutionBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.takeToExecutionBtn.Name = "takeToExecutionBtn";
			this.takeToExecutionBtn.Size = new System.Drawing.Size(222, 35);
			this.takeToExecutionBtn.TabIndex = 3;
			this.takeToExecutionBtn.Text = "Отдать на выполнение";
			this.takeToExecutionBtn.UseVisualStyleBackColor = true;
			this.takeToExecutionBtn.Click += new System.EventHandler(this.ButtonTakeOrderInWork_Click);
			// 
			// orderReadyBtn
			// 
			this.orderReadyBtn.Location = new System.Drawing.Point(1024, 338);
			this.orderReadyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.orderReadyBtn.Name = "orderReadyBtn";
			this.orderReadyBtn.Size = new System.Drawing.Size(222, 35);
			this.orderReadyBtn.TabIndex = 4;
			this.orderReadyBtn.Text = "Заказ готов";
			this.orderReadyBtn.UseVisualStyleBackColor = true;
			this.orderReadyBtn.Click += new System.EventHandler(this.ButtonOrderReady_Click);
			// 
			// orderPayed
			// 
			this.orderPayed.Location = new System.Drawing.Point(1024, 415);
			this.orderPayed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.orderPayed.Name = "orderPayed";
			this.orderPayed.Size = new System.Drawing.Size(222, 35);
			this.orderPayed.TabIndex = 5;
			this.orderPayed.Text = "Заказ оплачен";
			this.orderPayed.UseVisualStyleBackColor = true;
			this.orderPayed.Click += new System.EventHandler(this.ButtonPayOrder_Click);
			// 
			// updateList
			// 
			this.updateList.Location = new System.Drawing.Point(1024, 492);
			this.updateList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.updateList.Name = "updateList";
			this.updateList.Size = new System.Drawing.Size(222, 35);
			this.updateList.TabIndex = 6;
			this.updateList.Text = "Обновить список";
			this.updateList.UseVisualStyleBackColor = true;
			this.updateList.Click += new System.EventHandler(this.ButtonRef_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1305, 692);
			this.Controls.Add(this.updateList);
			this.Controls.Add(this.orderPayed);
			this.Controls.Add(this.orderReadyBtn);
			this.Controls.Add(this.takeToExecutionBtn);
			this.Controls.Add(this.createOrderBtn);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.topMenuStrip);
			this.MainMenuStrip = this.topMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.topMenuStrip.ResumeLayout(false);
			this.topMenuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip topMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem устройстваToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem комплектыToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button createOrderBtn;
		private System.Windows.Forms.Button takeToExecutionBtn;
		private System.Windows.Forms.Button orderReadyBtn;
		private System.Windows.Forms.Button orderPayed;
		private System.Windows.Forms.Button updateList;
	}
}