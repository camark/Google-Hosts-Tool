// *************************************************************************************************
//
// 文件名称(File Name)：         MainForm.cs
// 
// 功能描述(Description)：       程序主窗口,用于更新Hosts，并显示本地、云端Hosts版本日期
//
// Hosts文件来源(Hosts File)：   开源社区GitHub:https://raw.githubusercontent.com/racaljk/hosts/master/hosts
//                                     
// 作者(Author)：                牛俊亮
//  
// 日期(Create Date)：           2016-08-27
//
// 修改记录（Revision History）：
//      R1：
//          修改作者：           牛俊亮
//          修改日期：　　　     2016-08-28
//          修改原因：           将 "UpdateHosts方法" 内的 "UpdateHosts类" 利用对象初始化器赋值更改为构造方法赋值
// 
//      R2：
//          修改作者：           牛俊亮
//          修改日期：　　　     2016-08-30
//          修改原因：           新增网站Label标签，用于方便快速启动网页
//                              禁止应用程序重复运行
//
// *************************************************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Google_Hosts_更新器.Properties;

namespace Google_Hosts_更新器
{
    public partial class MainForm : Form
    {
        private static readonly Settings Settings = new Settings();  // 创建（Settings）程序设置类实例对象
        private readonly string _networkAdd;                         // 云端Hosts文件地址
        private string _hostsPath;                                   // 本地Hosts文件路径
        private string _backPath;                                    // 本地Hosts文件备份路径

        #region 加载设置 >> 保存设置

        // 程序启动时，加载设置类
        public MainForm()
        {
            //检测是否重复运行
            Process process = Process.GetCurrentProcess();
            string processName = process.ProcessName;
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length > 1)
            {
                //结束进程
                Environment.Exit(0);
            }

            // 禁止编译器对跨线程访问做检查
            CheckForIllegalCrossThreadCalls = false;

            // 窗体设计方法
            InitializeComponent();

            // 开机启动最小化
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                Hide();
            }

            // 加载设置
            this._hostsPath = Settings.HostsPath;
            this._networkAdd = Settings.NetworkAdd;
            this._backPath = Settings.BackPath;
            //this.lblLocalHostsDate.Text = Settings.LocalHostsDate;
            //this.lblNetworkHostsDate.Text = Settings.NetworkHostsDate;
            //this.lblUpdateDate.Text = Settings.UpdateDate;

            // 检测是否自动更新
            switch (Settings.ComboBox_AutoUpdateInt)
            {
                // 每十分钟自动更新
                case 0:
                    Thread autoUpdateThread = new Thread(this.AutoUpdate);
                    autoUpdateThread.Start();
                    break;

                // 每次启动更新
                case 1:
                    Thread startingUpdateThread = new Thread(this.UpdateHosts);
                    startingUpdateThread.Start();
                    break;
            }

            // 检测是否开机启动
            if (Settings.CheckBox_BootChecked)
            {
                RegistryKey registry = Registry.LocalMachine;                                                         // 创建注册表类实例
                registry = registry.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run", true);   // 获取写入权限
                object isFind = registry?.GetValue(Application.ProductName);                                          // 获取值是否存在
                if (isFind == null)                                                                                   // 如果值不存在，便写入启动项并关闭写入器、刷新磁盘
                {
                    registry?.SetValue(Application.ProductName, "\"" + Application.ExecutablePath + "\" /mini");
                    registry?.Close();
                }
            }
            else
            {
                RegistryKey registry = Registry.LocalMachine;                                                         // 创建注册表类实例
                registry = registry.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run", true);   // 获取写入权限
                object isFind = registry?.GetValue(Application.ProductName);                                          // 获取值是否存在
                if (isFind != null)                                                                                   // 如果值已存在，便删除启动项并关闭写入器、刷新磁盘
                {
                    registry.DeleteValue(Application.ProductName, false);
                    registry.Close();
                }
            }
        }

        // 程序关闭前，写入设置类
        public void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 写入设置类
            Settings.HostsPath = this._hostsPath;
            Settings.LocalHostsDate = this.lblLocalHostsDate.Text;
            Settings.NetworkHostsDate = this.lblNetworkHostsDate.Text;
            Settings.UpdateDate = this.lblUpdateDate.Text;

            // 保存设置
            Settings.Save();

            Environment.Exit(0); // 退出所有线程
        }

        /// <summary>
        /// 自动更新（每10分钟）
        /// </summary>
        private void AutoUpdate()
        {
            while (true)
            {
                UpdateHosts();
                Thread.Sleep(1000 * 60 * 10); // 10分钟
            }
        }

        #endregion

        #region 按钮

        // 多线程更新Hosts
        private void buttonUpdateHosts_Click(object sender, EventArgs e)
        {
            if (btnUpdateHosts.Text != @"更新Hosts") return;

            Thread updateHostsThread = new Thread(UpdateHosts);
            updateHostsThread.Start();
        }

        /// <summary>
        /// 更新Hosts
        /// </summary>
        private void UpdateHosts()
        {
            // 检测是否更新成功
            int s;

            btnUpdateHosts.Text = @"正在更新...";
            btnUpdateHosts.UseWaitCursor = true;

            try
            {
                // 创建（UpdateHosts）更新Hosts类实例对象，并提供Hosts地址和路径
                UpdateHosts updateHosts = new UpdateHosts(this._networkAdd, this._hostsPath);

                s = updateHosts.CompareDate();

                lblLocalHostsDate.Text = updateHosts.LocalHostsDate;
                lblNetworkHostsDate.Text = updateHosts.NetworkHostsDate;
                lblUpdateDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(@"对Hosts文件的访问被拒绝，请检查Hosts文件是否被隐藏！", @"提示");
                s = 2;
            }
            catch (Exception)
            {
                s = 2;
            }

            switch (s)
            {
                // 无需更新
                case 0:
                    btnUpdateHosts.UseWaitCursor = false;
                    btnUpdateHosts.Text = @"已是最新!";
                    Thread.Sleep(2000);
                    break;

                // 已下载更新到最新
                case 1:
                    btnUpdateHosts.UseWaitCursor = false;

                    // 气泡提醒：更新成功
                    notifyIcon1.ShowBalloonTip(2000, "", "Hosts已更新至最新!", ToolTipIcon.Info);
                    break;

                // 更新失败
                default:
                    btnUpdateHosts.UseWaitCursor = false;
                    btnUpdateHosts.Text = @"更新失败!";
                    Thread.Sleep(2000);
                    break;
            }

            btnUpdateHosts.Text = @"更新Hosts";
        }

        #endregion

        #region 右键菜单

        private void 选择HostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hosts文件窗口
            openFileDialog1.ShowDialog();
        }

        private void 备份HostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this._backPath += DateTime.Now.ToString("yyyy-MM-dd_HH：mm：ss");
                File.Copy(_hostsPath, _backPath, true);
                MessageBox.Show($@"备份成功！备份文件储存在：{_backPath}", @"提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm();    // 创建SettingForm（设置窗口）的实例对象
            setting.Show();                             // 显示设置窗口
        }

        private void 意见反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm(); // 创建FeedbackForm（意见反馈窗口）的实例对象
            feedback.Show();                            // 显示意见反馈窗口
        }

        private void 关于Hosts管理器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 关于Hosts管理器窗口
            MessageBox.Show(@"by: 牛俊亮", @"关于Hosts管理器");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 选择Hosts文件设置路径（Hosts文件窗口）
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this._hostsPath = openFileDialog1.FileName;
        }

        #endregion

        #region 托盘图标

        // 单击最小化隐藏至托盘
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // 隐藏窗口
                Hide();
            }
        }

        // 双击托盘图标恢复窗口
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // 显示窗口
            Visible = true;
            WindowState = FormWindowState.Normal;
        }

        #endregion

        #region 网页快速启动标签

        private void lbGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Google
            Process.Start("https://www.google.com.hk/");
        }

        private void lbTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Twitter
            Process.Start("https://twitter.com/?lang=zh-cn");
        }

        private void lbFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Facebook
            Process.Start("https://zh-cn.facebook.com/");
        }

        private void lbWikipedia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Wikipedia
            Process.Start("https://zh.wikipedia.org/wiki/Wikipedia:%E9%A6%96%E9%A1%B5");
        }

        #endregion

    }
}
