
namespace SecureShopView
{
	partial class FormDevice
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.deviceSaveBtn = new System.Windows.Forms.Button();
			this.deviceCancelBtn = new System.Windows.Forms.Button();
			this.deviceLbl = new System.Windows.Forms.Label();
			this.deviceTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// deviceSaveBtn
			// 
			this.deviceSaveBtn.Location = new System.Drawing.Point(152, 30);
			this.deviceSaveBtn.Name = "deviceSaveBtn";
			this.deviceSaveBtn.Size = new System.Drawing.Size(71, 22);
			this.deviceSaveBtn.TabIndex = 0;
			this.deviceSaveBtn.Text = "Сохранить";
			this.deviceSaveBtn.UseVisualStyleBackColor = true;
			this.deviceSaveBtn.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// deviceCancelBtn
			// 
			this.deviceCancelBtn.Location = new System.Drawing.Point(229, 30);
			this.deviceCancelBtn.Name = "deviceCancelBtn";
			this.deviceCancelBtn.Size = new System.Drawing.Size(64, 22);
			this.deviceCancelBtn.TabIndex = 1;
			this.deviceCancelBtn.Text = "Отмена";
			this.deviceCancelBtn.UseVisualStyleBackColor = true;
			this.deviceCancelBtn.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// deviceLbl
			// 
			this.deviceLbl.AutoSize = true;
			this.deviceLbl.Location = new System.Drawing.Point(10, 8);
			this.deviceLbl.Name = "deviceLbl";
			this.deviceLbl.Size = new System.Drawing.Size(60, 13);
			this.deviceLbl.TabIndex = 2;
			this.deviceLbl.Text = "Название:";
			// 
			// deviceTextBox
			// 
			this.deviceTextBox.Location = new System.Drawing.Point(71, 5);
			this.deviceTextBox.Name = "deviceTextBox";
			this.deviceTextBox.Size = new System.Drawing.Size(223, 20);
			this.deviceTextBox.TabIndex = 3;
			// 
			// FormDevice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 58);
			this.Controls.Add(this.deviceTextBox);
			this.Controls.Add(this.deviceLbl);
			this.Controls.Add(this.deviceCancelBtn);
			this.Controls.Add(this.deviceSaveBtn);
			this.Name = "FormDevice";
			this.Text = "Устройство";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button deviceSaveBtn;
		private System.Windows.Forms.Button deviceCancelBtn;
		private System.Windows.Forms.Label deviceLbl;
		private System.Windows.Forms.TextBox deviceTextBox;
	}
}

