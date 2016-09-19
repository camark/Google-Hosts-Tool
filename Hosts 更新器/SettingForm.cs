// *************************************************************************************************
//
// 文件名称（File Name）：       SettingForm.cs
// 
// 功能描述（Description）：     配置应用程序设置项，将配置项写入程序设置类
//                                     
// 作者（Author）：              牛俊亮
//  
// 日期（Create Date）：         2016-08-27
//  
// 修改记录（Revision History）：
//      R1：
//          修改作者：           
//          修改日期：　　　     
//          修改原因：           
//
// *************************************************************************************************

using System;
using System.Windows.Forms;
using Google_Hosts_更新器.Properties;

namespace Google_Hosts_更新器
{
    public partial class SettingForm : Form
    {
        // 创建程序设置类实例对象
        private static readonly Settings Settings = new Settings();

        #region 加载设置 >> 保存设置

        // 程序启动时，加载设置类
        public SettingForm()
        {
            InitializeComponent();

            //读取设置项
            //checbBoot.Checked = Settings.CheckBox_BootChecked;
            combAutoUpdate.SelectedIndex = Settings.ComboBox_AutoUpdateInt;
        }

        // 单击按钮时，写入设置类
        private void butSaveSettings_Click(object sender, EventArgs e)
        {
            // 写入设置项
            Settings.CheckBox_BootChecked = checbBoot.Checked;
            Settings.ComboBox_AutoUpdateInt = combAutoUpdate.SelectedIndex;

            DialogResult isbutton = MessageBox.Show(@"保存设置会关闭应用程序,并且需要手动启动,是否保存?", @"提示", MessageBoxButtons.YesNo);
            if (isbutton == DialogResult.No) return;

            // 保存设置项
            Settings.Save();

            MainForm form = new MainForm();
            form.MainForm_FormClosing(null, null);
        }

        #endregion

        //#region 方法组

        ///// <summary>
        ///// 开机启动
        ///// </summary>
        //private void Boot()
        //{
        //    if (checkBox_Boot.Checked)
        //    {
        //        RegistryKey bootKey = Registry.LocalMachine;
        //        bootKey = bootKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        //        bootKey?.SetValue(Application.ProductName, Application.ExecutablePath);
        //    }
        //    else
        //    {
        //        RegistryKey delKey = Registry.LocalMachine;
        //        delKey = delKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        //        delKey?.DeleteValue(Application.ProductName, true);
        //    }
        //}

        ///// <summary>
        ///// Hosts自动更新
        ///// </summary>
        //private void AutoUpdate()
        //{
        //    if (comboBox_AutoUpdate.SelectedIndex == 2)
        //    {
        //        MessageBox.Show(@"不自动更新吗?以后上不去Google别后悔哦~", @"滑稽.jpg");
        //    }
        //}

        //#endregion

    }
}
