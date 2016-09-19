namespace Google_Hosts_更新器
{
    partial class SettingForm
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
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label1;
            this.button_SaveSettings = new System.Windows.Forms.Button();
            this.combAutoUpdate = new System.Windows.Forms.ComboBox();
            this.checbBoot = new System.Windows.Forms.CheckBox();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            panel1.Controls.Add(this.button_SaveSettings);
            panel1.Controls.Add(this.combAutoUpdate);
            panel1.Controls.Add(this.checbBoot);
            panel1.Location = new System.Drawing.Point(0, 82);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(583, 318);
            panel1.TabIndex = 12;
            // 
            // button_SaveSettings
            // 
            this.button_SaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveSettings.ForeColor = System.Drawing.Color.Gray;
            this.button_SaveSettings.Location = new System.Drawing.Point(468, 276);
            this.button_SaveSettings.Name = "button_SaveSettings";
            this.button_SaveSettings.Size = new System.Drawing.Size(103, 30);
            this.button_SaveSettings.TabIndex = 3;
            this.button_SaveSettings.Text = "保存设置";
            this.button_SaveSettings.UseVisualStyleBackColor = true;
            this.button_SaveSettings.Click += new System.EventHandler(this.butSaveSettings_Click);
            // 
            // combAutoUpdate
            // 
            this.combAutoUpdate.BackColor = System.Drawing.Color.White;
            this.combAutoUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combAutoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combAutoUpdate.ForeColor = System.Drawing.Color.Gray;
            this.combAutoUpdate.FormattingEnabled = true;
            this.combAutoUpdate.Items.AddRange(new object[] {
            "自动更新（推荐）",
            "每次启动更新",
            "不自动更新（不推荐）"});
            this.combAutoUpdate.Location = new System.Drawing.Point(309, 108);
            this.combAutoUpdate.Name = "combAutoUpdate";
            this.combAutoUpdate.Size = new System.Drawing.Size(223, 24);
            this.combAutoUpdate.TabIndex = 0;
            // 
            // checbBoot
            // 
            this.checbBoot.AutoSize = true;
            this.checbBoot.BackColor = System.Drawing.Color.White;
            this.checbBoot.Checked = global::Google_Hosts_更新器.Properties.Settings.Default.CheckBox_BootChecked;
            this.checbBoot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checbBoot.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Google_Hosts_更新器.Properties.Settings.Default, "CheckBox_BootChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checbBoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checbBoot.ForeColor = System.Drawing.Color.Gray;
            this.checbBoot.Location = new System.Drawing.Point(444, 66);
            this.checbBoot.Name = "checbBoot";
            this.checbBoot.Size = new System.Drawing.Size(88, 20);
            this.checbBoot.TabIndex = 1;
            this.checbBoot.Text = "开机启动";
            this.checbBoot.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("微软雅黑", 55F);
            label1.Location = new System.Drawing.Point(1, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(188, 95);
            label1.TabIndex = 13;
            label1.Text = "设置";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(583, 400);
            this.Controls.Add(label1);
            this.Controls.Add(panel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(599, 439);
            this.MinimumSize = new System.Drawing.Size(599, 439);
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.Text = "设置";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checbBoot;
        private System.Windows.Forms.ComboBox combAutoUpdate;
        private System.Windows.Forms.Button button_SaveSettings;
    }
}