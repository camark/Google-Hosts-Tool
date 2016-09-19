namespace Google_Hosts_更新器
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Panel pnl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.选择HostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份HostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.意见反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于Hosts管理器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTwitter = new System.Windows.Forms.LinkLabel();
            this.lblNetworkHostsDate = new System.Windows.Forms.Label();
            this.lbFacebook = new System.Windows.Forms.LinkLabel();
            this.lbWikipedia = new System.Windows.Forms.LinkLabel();
            this.lblLocalHostsDate = new System.Windows.Forms.Label();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.lbGoogle = new System.Windows.Forms.LinkLabel();
            this.btnUpdateHosts = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            pnl = new System.Windows.Forms.Panel();
            this.menuForm.SuspendLayout();
            pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            label3.ContextMenuStrip = this.menuForm;
            label3.Cursor = System.Windows.Forms.Cursors.Default;
            label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label3.ForeColor = System.Drawing.Color.Gray;
            label3.Location = new System.Drawing.Point(29, 71);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(172, 16);
            label3.TabIndex = 6;
            label3.Text = "云端Hosts文件版本：";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择HostsToolStripMenuItem,
            this.备份HostsToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.意见反馈ToolStripMenuItem,
            this.关于Hosts管理器ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuForm.Name = "contextMenuStrip1";
            this.menuForm.Size = new System.Drawing.Size(170, 136);
            // 
            // 选择HostsToolStripMenuItem
            // 
            this.选择HostsToolStripMenuItem.Image = global::Google_Hosts_更新器.Properties.Resources.File;
            this.选择HostsToolStripMenuItem.Name = "选择HostsToolStripMenuItem";
            this.选择HostsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.选择HostsToolStripMenuItem.Text = "选择Hosts";
            this.选择HostsToolStripMenuItem.Click += new System.EventHandler(this.选择HostsToolStripMenuItem_Click);
            // 
            // 备份HostsToolStripMenuItem
            // 
            this.备份HostsToolStripMenuItem.Image = global::Google_Hosts_更新器.Properties.Resources.Backup;
            this.备份HostsToolStripMenuItem.Name = "备份HostsToolStripMenuItem";
            this.备份HostsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.备份HostsToolStripMenuItem.Text = "备份Hosts";
            this.备份HostsToolStripMenuItem.Click += new System.EventHandler(this.备份HostsToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Image = global::Google_Hosts_更新器.Properties.Resources.Settings;
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 意见反馈ToolStripMenuItem
            // 
            this.意见反馈ToolStripMenuItem.Image = global::Google_Hosts_更新器.Properties.Resources.Feedback;
            this.意见反馈ToolStripMenuItem.Name = "意见反馈ToolStripMenuItem";
            this.意见反馈ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.意见反馈ToolStripMenuItem.Text = "意见反馈";
            this.意见反馈ToolStripMenuItem.Click += new System.EventHandler(this.意见反馈ToolStripMenuItem_Click);
            // 
            // 关于Hosts管理器ToolStripMenuItem
            // 
            this.关于Hosts管理器ToolStripMenuItem.Image = global::Google_Hosts_更新器.Properties.Resources.About;
            this.关于Hosts管理器ToolStripMenuItem.Name = "关于Hosts管理器ToolStripMenuItem";
            this.关于Hosts管理器ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.关于Hosts管理器ToolStripMenuItem.Text = "关于Hosts管理器";
            this.关于Hosts管理器ToolStripMenuItem.Click += new System.EventHandler(this.关于Hosts管理器ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = global::Google_Hosts_更新器.Properties.Resources.Exit;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            label4.ContextMenuStrip = this.menuForm;
            label4.Cursor = System.Windows.Forms.Cursors.Default;
            label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label4.ForeColor = System.Drawing.Color.Gray;
            label4.Location = new System.Drawing.Point(29, 43);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(172, 16);
            label4.TabIndex = 5;
            label4.Text = "本地Hosts文件版本：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            label5.ContextMenuStrip = this.menuForm;
            label5.Cursor = System.Windows.Forms.Cursors.Default;
            label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label5.ForeColor = System.Drawing.Color.Gray;
            label5.Location = new System.Drawing.Point(29, 111);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(178, 16);
            label5.TabIndex = 9;
            label5.Text = "上次检查更新的时间：";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl
            // 
            pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            pnl.Controls.Add(this.lbTwitter);
            pnl.Controls.Add(this.lblNetworkHostsDate);
            pnl.Controls.Add(this.lbFacebook);
            pnl.Controls.Add(this.lbWikipedia);
            pnl.Controls.Add(this.lblLocalHostsDate);
            pnl.Controls.Add(this.lblUpdateDate);
            pnl.Controls.Add(label5);
            pnl.Controls.Add(label3);
            pnl.Controls.Add(this.lbGoogle);
            pnl.Controls.Add(label4);
            pnl.Location = new System.Drawing.Point(0, 177);
            pnl.Name = "pnl";
            pnl.Size = new System.Drawing.Size(583, 223);
            pnl.TabIndex = 11;
            // 
            // lbTwitter
            // 
            this.lbTwitter.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbTwitter.AutoSize = true;
            this.lbTwitter.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbTwitter.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTwitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbTwitter.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbTwitter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbTwitter.Location = new System.Drawing.Point(492, 74);
            this.lbTwitter.Name = "lbTwitter";
            this.lbTwitter.Size = new System.Drawing.Size(79, 19);
            this.lbTwitter.TabIndex = 14;
            this.lbTwitter.TabStop = true;
            this.lbTwitter.Text = "Twitter";
            this.lbTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTwitter.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbTwitter_LinkClicked);
            // 
            // lblNetworkHostsDate
            // 
            this.lblNetworkHostsDate.AutoSize = true;
            this.lblNetworkHostsDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblNetworkHostsDate.ContextMenuStrip = this.menuForm;
            this.lblNetworkHostsDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNetworkHostsDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Google_Hosts_更新器.Properties.Settings.Default, "NetworkHostsDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblNetworkHostsDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNetworkHostsDate.ForeColor = System.Drawing.Color.Gray;
            this.lblNetworkHostsDate.Location = new System.Drawing.Point(188, 71);
            this.lblNetworkHostsDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetworkHostsDate.Name = "lblNetworkHostsDate";
            this.lblNetworkHostsDate.Size = new System.Drawing.Size(16, 16);
            this.lblNetworkHostsDate.TabIndex = 4;
            this.lblNetworkHostsDate.Text = global::Google_Hosts_更新器.Properties.Settings.Default.NetworkHostsDate;
            this.lblNetworkHostsDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFacebook
            // 
            this.lbFacebook.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbFacebook.AutoSize = true;
            this.lbFacebook.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbFacebook.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbFacebook.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbFacebook.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbFacebook.Location = new System.Drawing.Point(482, 108);
            this.lbFacebook.Name = "lbFacebook";
            this.lbFacebook.Size = new System.Drawing.Size(89, 19);
            this.lbFacebook.TabIndex = 12;
            this.lbFacebook.TabStop = true;
            this.lbFacebook.Text = "Facebook";
            this.lbFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFacebook.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbFacebook_LinkClicked);
            // 
            // lbWikipedia
            // 
            this.lbWikipedia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbWikipedia.AutoSize = true;
            this.lbWikipedia.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbWikipedia.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWikipedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbWikipedia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbWikipedia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbWikipedia.Location = new System.Drawing.Point(472, 142);
            this.lbWikipedia.Name = "lbWikipedia";
            this.lbWikipedia.Size = new System.Drawing.Size(99, 19);
            this.lbWikipedia.TabIndex = 13;
            this.lbWikipedia.TabStop = true;
            this.lbWikipedia.Text = "Wikipedia";
            this.lbWikipedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWikipedia.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbWikipedia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbWikipedia_LinkClicked);
            // 
            // lblLocalHostsDate
            // 
            this.lblLocalHostsDate.AutoSize = true;
            this.lblLocalHostsDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblLocalHostsDate.ContextMenuStrip = this.menuForm;
            this.lblLocalHostsDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLocalHostsDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Google_Hosts_更新器.Properties.Settings.Default, "LocalHostsDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLocalHostsDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLocalHostsDate.ForeColor = System.Drawing.Color.Gray;
            this.lblLocalHostsDate.Location = new System.Drawing.Point(188, 43);
            this.lblLocalHostsDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalHostsDate.Name = "lblLocalHostsDate";
            this.lblLocalHostsDate.Size = new System.Drawing.Size(16, 16);
            this.lblLocalHostsDate.TabIndex = 3;
            this.lblLocalHostsDate.Text = global::Google_Hosts_更新器.Properties.Settings.Default.LocalHostsDate;
            this.lblLocalHostsDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.AutoSize = true;
            this.lblUpdateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblUpdateDate.ContextMenuStrip = this.menuForm;
            this.lblUpdateDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUpdateDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Google_Hosts_更新器.Properties.Settings.Default, "UpdateDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblUpdateDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUpdateDate.ForeColor = System.Drawing.Color.Gray;
            this.lblUpdateDate.Location = new System.Drawing.Point(97, 145);
            this.lblUpdateDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(16, 16);
            this.lblUpdateDate.TabIndex = 10;
            this.lblUpdateDate.Text = global::Google_Hosts_更新器.Properties.Settings.Default.UpdateDate;
            this.lblUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGoogle
            // 
            this.lbGoogle.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbGoogle.AutoSize = true;
            this.lbGoogle.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbGoogle.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoogle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbGoogle.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbGoogle.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbGoogle.Location = new System.Drawing.Point(502, 40);
            this.lbGoogle.Name = "lbGoogle";
            this.lbGoogle.Size = new System.Drawing.Size(69, 19);
            this.lbGoogle.TabIndex = 11;
            this.lbGoogle.TabStop = true;
            this.lbGoogle.Text = "Google";
            this.lbGoogle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGoogle.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbGoogle_LinkClicked);
            // 
            // btnUpdateHosts
            // 
            this.btnUpdateHosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnUpdateHosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateHosts.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateHosts.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateHosts.ForeColor = System.Drawing.Color.White;
            this.btnUpdateHosts.Location = new System.Drawing.Point(229, 144);
            this.btnUpdateHosts.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateHosts.Name = "btnUpdateHosts";
            this.btnUpdateHosts.Size = new System.Drawing.Size(140, 60);
            this.btnUpdateHosts.TabIndex = 1;
            this.btnUpdateHosts.Text = "更新Hosts";
            this.btnUpdateHosts.UseVisualStyleBackColor = false;
            this.btnUpdateHosts.Click += new System.EventHandler(this.buttonUpdateHosts_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Hosts";
            this.openFileDialog1.InitialDirectory = "C:\\WINDOWS\\system32\\drivers\\etc\\";
            this.openFileDialog1.Title = "Hosts 文件选择";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.menuForm;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Google Hosts管理器";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(583, 400);
            this.ContextMenuStrip = this.menuForm;
            this.Controls.Add(this.btnUpdateHosts);
            this.Controls.Add(pnl);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(599, 439);
            this.MinimumSize = new System.Drawing.Size(599, 439);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Hosts更新器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.menuForm.ResumeLayout(false);
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem 选择HostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于Hosts管理器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 意见反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.Label lblUpdateDate;
        private System.Windows.Forms.ToolStripMenuItem 备份HostsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Button btnUpdateHosts;
        private System.Windows.Forms.Label lblLocalHostsDate;
        private System.Windows.Forms.Label lblNetworkHostsDate;
        private System.Windows.Forms.LinkLabel lbGoogle;
        private System.Windows.Forms.LinkLabel lbWikipedia;
        private System.Windows.Forms.LinkLabel lbFacebook;
        private System.Windows.Forms.LinkLabel lbTwitter;
    }
}

