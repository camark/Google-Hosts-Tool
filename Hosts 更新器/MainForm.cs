// *************************************************************************************************
//
// �ļ�����(File Name)��         MainForm.cs
// 
// ��������(Description)��       ����������,���ڸ���Hosts������ʾ���ء��ƶ�Hosts�汾����
//
// Hosts�ļ���Դ(Hosts File)��   ��Դ����GitHub:https://raw.githubusercontent.com/racaljk/hosts/master/hosts
//                                     
// ����(Author)��                ţ����
//  
// ����(Create Date)��           2016-08-27
//
// �޸ļ�¼��Revision History����
//      R1��
//          �޸����ߣ�           ţ����
//          �޸����ڣ�������     2016-08-28
//          �޸�ԭ��           �� "UpdateHosts����" �ڵ� "UpdateHosts��" ���ö����ʼ������ֵ����Ϊ���췽����ֵ
// 
//      R2��
//          �޸����ߣ�           ţ����
//          �޸����ڣ�������     2016-08-30
//          �޸�ԭ��           ������վLabel��ǩ�����ڷ������������ҳ
//                              ��ֹӦ�ó����ظ�����
//
// *************************************************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Google_Hosts_������.Properties;

namespace Google_Hosts_������
{
    public partial class MainForm : Form
    {
        private static readonly Settings Settings = new Settings();  // ������Settings������������ʵ������
        private readonly string _networkAdd;                         // �ƶ�Hosts�ļ���ַ
        private string _hostsPath;                                   // ����Hosts�ļ�·��
        private string _backPath;                                    // ����Hosts�ļ�����·��

        #region �������� >> ��������

        // ��������ʱ������������
        public MainForm()
        {
            //����Ƿ��ظ�����
            Process process = Process.GetCurrentProcess();
            string processName = process.ProcessName;
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length > 1)
            {
                //��������
                Environment.Exit(0);
            }

            // ��ֹ�������Կ��̷߳��������
            CheckForIllegalCrossThreadCalls = false;

            // ������Ʒ���
            InitializeComponent();

            // ����������С��
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                Hide();
            }

            // ��������
            this._hostsPath = Settings.HostsPath;
            this._networkAdd = Settings.NetworkAdd;
            this._backPath = Settings.BackPath;
            //this.lblLocalHostsDate.Text = Settings.LocalHostsDate;
            //this.lblNetworkHostsDate.Text = Settings.NetworkHostsDate;
            //this.lblUpdateDate.Text = Settings.UpdateDate;

            // ����Ƿ��Զ�����
            switch (Settings.ComboBox_AutoUpdateInt)
            {
                // ÿʮ�����Զ�����
                case 0:
                    Thread autoUpdateThread = new Thread(this.AutoUpdate);
                    autoUpdateThread.Start();
                    break;

                // ÿ����������
                case 1:
                    Thread startingUpdateThread = new Thread(this.UpdateHosts);
                    startingUpdateThread.Start();
                    break;
            }

            // ����Ƿ񿪻�����
            if (Settings.CheckBox_BootChecked)
            {
                RegistryKey registry = Registry.LocalMachine;                                                         // ����ע�����ʵ��
                registry = registry.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run", true);   // ��ȡд��Ȩ��
                object isFind = registry?.GetValue(Application.ProductName);                                          // ��ȡֵ�Ƿ����
                if (isFind == null)                                                                                   // ���ֵ�����ڣ���д��������ر�д������ˢ�´���
                {
                    registry?.SetValue(Application.ProductName, "\"" + Application.ExecutablePath + "\" /mini");
                    registry?.Close();
                }
            }
            else
            {
                RegistryKey registry = Registry.LocalMachine;                                                         // ����ע�����ʵ��
                registry = registry.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run", true);   // ��ȡд��Ȩ��
                object isFind = registry?.GetValue(Application.ProductName);                                          // ��ȡֵ�Ƿ����
                if (isFind != null)                                                                                   // ���ֵ�Ѵ��ڣ���ɾ��������ر�д������ˢ�´���
                {
                    registry.DeleteValue(Application.ProductName, false);
                    registry.Close();
                }
            }
        }

        // ����ر�ǰ��д��������
        public void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // д��������
            Settings.HostsPath = this._hostsPath;
            Settings.LocalHostsDate = this.lblLocalHostsDate.Text;
            Settings.NetworkHostsDate = this.lblNetworkHostsDate.Text;
            Settings.UpdateDate = this.lblUpdateDate.Text;

            // ��������
            Settings.Save();

            Environment.Exit(0); // �˳������߳�
        }

        /// <summary>
        /// �Զ����£�ÿ10���ӣ�
        /// </summary>
        private void AutoUpdate()
        {
            while (true)
            {
                UpdateHosts();
                Thread.Sleep(1000 * 60 * 10); // 10����
            }
        }

        #endregion

        #region ��ť

        // ���̸߳���Hosts
        private void buttonUpdateHosts_Click(object sender, EventArgs e)
        {
            if (btnUpdateHosts.Text != @"����Hosts") return;

            Thread updateHostsThread = new Thread(UpdateHosts);
            updateHostsThread.Start();
        }

        /// <summary>
        /// ����Hosts
        /// </summary>
        private void UpdateHosts()
        {
            // ����Ƿ���³ɹ�
            int s;

            btnUpdateHosts.Text = @"���ڸ���...";
            btnUpdateHosts.UseWaitCursor = true;

            try
            {
                // ������UpdateHosts������Hosts��ʵ�����󣬲��ṩHosts��ַ��·��
                UpdateHosts updateHosts = new UpdateHosts(this._networkAdd, this._hostsPath);

                s = updateHosts.CompareDate();

                lblLocalHostsDate.Text = updateHosts.LocalHostsDate;
                lblNetworkHostsDate.Text = updateHosts.NetworkHostsDate;
                lblUpdateDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(@"��Hosts�ļ��ķ��ʱ��ܾ�������Hosts�ļ��Ƿ����أ�", @"��ʾ");
                s = 2;
            }
            catch (Exception)
            {
                s = 2;
            }

            switch (s)
            {
                // �������
                case 0:
                    btnUpdateHosts.UseWaitCursor = false;
                    btnUpdateHosts.Text = @"��������!";
                    Thread.Sleep(2000);
                    break;

                // �����ظ��µ�����
                case 1:
                    btnUpdateHosts.UseWaitCursor = false;

                    // �������ѣ����³ɹ�
                    notifyIcon1.ShowBalloonTip(2000, "", "Hosts�Ѹ���������!", ToolTipIcon.Info);
                    break;

                // ����ʧ��
                default:
                    btnUpdateHosts.UseWaitCursor = false;
                    btnUpdateHosts.Text = @"����ʧ��!";
                    Thread.Sleep(2000);
                    break;
            }

            btnUpdateHosts.Text = @"����Hosts";
        }

        #endregion

        #region �Ҽ��˵�

        private void ѡ��HostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hosts�ļ�����
            openFileDialog1.ShowDialog();
        }

        private void ����HostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this._backPath += DateTime.Now.ToString("yyyy-MM-dd_HH��mm��ss");
                File.Copy(_hostsPath, _backPath, true);
                MessageBox.Show($@"���ݳɹ��������ļ������ڣ�{_backPath}", @"��ʾ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm();    // ����SettingForm�����ô��ڣ���ʵ������
            setting.Show();                             // ��ʾ���ô���
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm(); // ����FeedbackForm������������ڣ���ʵ������
            feedback.Show();                            // ��ʾ�����������
        }

        private void ����Hosts������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ����Hosts����������
            MessageBox.Show(@"by: ţ����", @"����Hosts������");
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ѡ��Hosts�ļ�����·����Hosts�ļ����ڣ�
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this._hostsPath = openFileDialog1.FileName;
        }

        #endregion

        #region ����ͼ��

        // ������С������������
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // ���ش���
                Hide();
            }
        }

        // ˫������ͼ��ָ�����
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // ��ʾ����
            Visible = true;
            WindowState = FormWindowState.Normal;
        }

        #endregion

        #region ��ҳ����������ǩ

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
