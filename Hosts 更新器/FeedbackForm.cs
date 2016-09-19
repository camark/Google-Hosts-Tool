// *************************************************************************************************
//
// 文件名称（File Name）：       FeedbackForm.cs
// 
// 功能描述（Description）：     通过邮件方式获取用户反馈信息
//                                     
// 作者（Author）：              牛俊亮
//  
// 日期（Create Date）：         2016-08-27
// 
// 修改记录（Revision History）：
//      R1：
//          修改作者：           牛俊亮
//          修改日期：　　　     2016-08-30
//          修改原因：           将发送邮件的QQ邮箱账号更改为163邮箱
//                              邮箱账号:   googlehosts@163.com
//                              邮箱密码:   GoogleHosts163
//                              邮箱授权码: googlehosts163
//
// *************************************************************************************************

using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace Google_Hosts_更新器
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        #region 文本框焦点反馈

        // txtSubject 获得焦点
        private void txtSubject_Enter(object sender, EventArgs e)
        {
            if (txtSubject.Text != @"QQ，手机号，邮箱地址....") return;
            txtSubject.Text = "";
            txtSubject.ForeColor = Color.White;
        }
        // txtSubject 失去焦点
        private void txtSubject_Leave(object sender, EventArgs e)
        {
            if (txtSubject.Text != "") return;
            txtSubject.Text = @"QQ，手机号，邮箱地址....";
            txtSubject.ForeColor = Color.Gainsboro;
        }

        // txtBody 获得焦点
        private void txtBody_Enter(object sender, EventArgs e)
        {
            if (txtBody.Text != @"这里是正文~~") return;
            txtBody.Text = "";
            txtBody.ForeColor = Color.White;
        }
        // txtBody 失去焦点
        private void txtBody_Leave(object sender, EventArgs e)
        {
            if (txtBody.Text != "") return;
            txtBody.Text = @"这里是正文~~";
            txtBody.ForeColor = Color.Gainsboro;
        }

        #endregion

        #region 发送邮件

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text != @"QQ，手机号，邮箱地址...." && txtBody.Text != @"这里是正文~~")
            {
                Thread sendMail = new Thread(Mail);
                sendMail.Start();
            }
            else
            {
                MessageBox.Show(@"请输入联系方式或建议信息~", @"提示");
            }
        }

        #endregion

        #region 方法组

        /// <summary>
        /// 发送邮件
        /// </summary>
        private void Mail()
        {
            const string host = "smtp.163.com";                             // SMTP服务器
            const int port = 25;                                            // 服务器端口
            const string userName = "googlehosts@163.com";                  // 用户名
            const string password = "googlehosts163";                       // 授权码
            const string from = "googlehosts@163.com";                      // 发件人
            const string to = "googlehosts@163.com";                        // 收件人
            string subject = txtSubject.Text;                               // 邮件主题
            string body = txtBody.Text;                                     // 邮件正文

            try
            {
                SmtpClient client = new SmtpClient(host, port)              // 连接SMTP服务器
                {
                    EnableSsl = true,                                       // SSl加密链接
                    Credentials = new NetworkCredential(userName, password) // 邮箱账号和授权码
                };                                                          // QQ邮箱一定要有:SSL加密 = true

                MailMessage msg = new MailMessage(from, to, subject, body)  // 设置发件人、收件人、邮件主题、正文
                {
                    Priority = MailPriority.High                            // 邮件优先级
                };

                btnSend.Text = @"正在发送...";
                client.Send(msg);                                           // 邮件发送
                MessageBox.Show(@"邮件发送成功！", @"提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"提示");
            }
            finally
            {
                btnSend.Text = @"发送反馈";
            }
        }

        #endregion

    }
}
