
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.устройстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.комплектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокУстройствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.устройстваПоКомплектациямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокЗазказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.createOrderBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(870, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.устройстваToolStripMenuItem,
            this.комплектыToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// устройстваToolStripMenuItem
			// 
			this.устройстваToolStripMenuItem.Name = "устройстваToolStripMenuItem";
			this.устройстваToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.устройстваToolStripMenuItem.Text = "Устройства";
			this.устройстваToolStripMenuItem.Click += new System.EventHandler(this.DevicesToolStripMenuItem_Click);
			// 
			// комплектыToolStripMenuItem
			// 
			this.комплектыToolStripMenuItem.Name = "комплектыToolStripMenuItem";
			this.комплектыToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.комплектыToolStripMenuItem.Text = "Комплекты";
			this.комплектыToolStripMenuItem.Click += new System.EventHandler(this.EquipmentsToolStripMenuItem_Click);
			// 
			// отчетыToolStripMenuItem
			// 
			this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокУстройствToolStripMenuItem,
            this.устройстваПоКомплектациямToolStripMenuItem,
            this.списокЗазказовToolStripMenuItem});
			this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
			this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.отчетыToolStripMenuItem.Text = "Отчеты";
			// 
			// списокУстройствToolStripMenuItem
			// 
			this.списокУстройствToolStripMenuItem.Name = "списокУстройствToolStripMenuItem";
			this.списокУстройствToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.списокУстройствToolStripMenuItem.Text = "Список устройств";
			this.списокУстройствToolStripMenuItem.Click += new System.EventHandler(this.DevicesToolStripMenuReportItem_Click);
			// 
			// устройстваПоКомплектациямToolStripMenuItem
			// 
			this.устройстваПоКомплектациямToolStripMenuItem.Name = "устройстваПоКомплектациямToolStripMenuItem";
			this.устройстваПоКомплектациямToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.устройстваПоКомплектациямToolStripMenuItem.Text = "Устройства по комплектациям";
			this.устройстваПоКомплектациямToolStripMenuItem.Click += new System.EventHandler(this.DeviceEquipmentsToolStripMenuItem_Click);
			// 
			// списокЗазказовToolStripMenuItem
			// 
			this.списокЗазказовToolStripMenuItem.Name = "списокЗазказовToolStripMenuItem";
			this.списокЗазказовToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.списокЗазказовToolStripMenuItem.Text = "Список зазказов";
			this.списокЗазказовToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 27);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(634, 411);
			this.dataGridView.TabIndex = 1;
			// 
			// createOrderBtn
			// 
			this.createOrderBtn.Location = new System.Drawing.Point(683, 120);
			this.createOrderBtn.Name = "createOrderBtn";
			this.createOrderBtn.Size = new System.Drawing.Size(148, 23);
			this.createOrderBtn.TabIndex = 2;
			this.createOrderBtn.Text = "Создать заказ";
			this.createOrderBtn.UseVisualStyleBackColor = true;
			this.createOrderBtn.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(683, 170);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Отдать на выполнение";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ButtonTakeOrderInWork_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(683, 220);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(148, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Заказ готов";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.ButtonOrderReady_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(683, 270);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(148, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Заказ оплачен";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.ButtonPayOrder_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(683, 320);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(148, 23);
			this.button5.TabIndex = 6;
			this.button5.Text = "Обновить список";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.ButtonRef_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 450);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.createOrderBtn);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem устройстваToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem комплектыToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button createOrderBtn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокУстройствToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem устройстваПоКомплектациямToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокЗазказовToolStripMenuItem;
	}
}