namespace SecureShopView
{
    partial class FormImplementer
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
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelWorkTime = new System.Windows.Forms.Label();
			this.textBoxWorkTime = new System.Windows.Forms.TextBox();
			this.labelPauseTime = new System.Windows.Forms.Label();
			this.textBoxPauseTime = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(76, 23);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(224, 26);
			this.textBoxName.TabIndex = 0;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(20, 28);
			this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(44, 20);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Имя:";
			// 
			// labelWorkTime
			// 
			this.labelWorkTime.AutoSize = true;
			this.labelWorkTime.Location = new System.Drawing.Point(20, 68);
			this.labelWorkTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelWorkTime.Name = "labelWorkTime";
			this.labelWorkTime.Size = new System.Drawing.Size(122, 20);
			this.labelWorkTime.TabIndex = 3;
			this.labelWorkTime.Text = "Время работы:";
			// 
			// textBoxWorkTime
			// 
			this.textBoxWorkTime.Location = new System.Drawing.Point(153, 63);
			this.textBoxWorkTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxWorkTime.Name = "textBoxWorkTime";
			this.textBoxWorkTime.Size = new System.Drawing.Size(148, 26);
			this.textBoxWorkTime.TabIndex = 2;
			// 
			// labelPauseTime
			// 
			this.labelPauseTime.AutoSize = true;
			this.labelPauseTime.Location = new System.Drawing.Point(20, 108);
			this.labelPauseTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPauseTime.Name = "labelPauseTime";
			this.labelPauseTime.Size = new System.Drawing.Size(122, 20);
			this.labelPauseTime.TabIndex = 5;
			this.labelPauseTime.Text = "Время отдыха:";
			// 
			// textBoxPauseTime
			// 
			this.textBoxPauseTime.Location = new System.Drawing.Point(153, 103);
			this.textBoxPauseTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxPauseTime.Name = "textBoxPauseTime";
			this.textBoxPauseTime.Size = new System.Drawing.Size(148, 26);
			this.textBoxPauseTime.TabIndex = 4;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(24, 157);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(279, 35);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(24, 202);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(279, 35);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// FormImplementer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 251);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelPauseTime);
			this.Controls.Add(this.textBoxPauseTime);
			this.Controls.Add(this.labelWorkTime);
			this.Controls.Add(this.textBoxWorkTime);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxName);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormImplementer";
			this.Text = "Исполнитель";
			this.Load += new System.EventHandler(this.FormImplementer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWorkTime;
        private System.Windows.Forms.TextBox textBoxWorkTime;
        private System.Windows.Forms.Label labelPauseTime;
        private System.Windows.Forms.TextBox textBoxPauseTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}