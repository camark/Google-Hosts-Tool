// *************************************************************************************************
//
// 文件名称（File Name）：       UpdateHosts.cs
// 
// 功能描述（Description）：     获取云端Hosts文件版本日期，本地Hosts文件版本日期，对比、更新并返回更新状态
//                                     
// 作者（Author）：              牛俊亮
//  
// 日期（Create Date）：         2016-08-27
//
// 修改记录（Revision History）：
//      R1：
//          修改作者：           牛俊亮
//          修改日期：　　　     2016-08-28
//          修改理由：           将 "NetworkAdd" 和 "HostsPath" 自动属性修改为 "私有只读字段"，
//                              并增加 "带参构造方法" 为以上两个字段赋值
//
//      R2：
//          修改作者：           牛俊亮
//          修改日期：　　　     2016-09-01
//          修改理由：           增加 "时间对比语句" 的异常处理
//  
//      R3：
//          修改作者：           牛俊亮
//          修改日期：　　　     2016-09-02
//          修改理由：           增加 "GetLocalHostsDate" 方法的异常处理
//
//      R3：
//          修改作者：           牛俊亮
//          修改日期：　　　     2016-09-11
//          修改理由：           增加 "using System.Text.RegularExpressions" 
//                              修改 "GetLocalHostsDate()" "GetNetworHosts()" 的字符串分割查找日期方法
//                              改为 "正则表达式" 查找日期
//
// *************************************************************************************************

using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Google_Hosts_更新器
{
    /// <summary>
    /// Hosts文件日期获取、对比
    /// </summary>
    internal class UpdateHosts
    {

        #region 字段 or 属性

        /// <summary>
        /// 云端Hosts地址
        /// </summary>
        private readonly string _networkAdd;

        /// <summary>
        /// 本地Hosts路径
        /// </summary>
        private readonly string _hostsPath;

        /// <summary>
        /// 云端Hosts文本
        /// </summary>
        private string _networkHostsString;

        /// <summary>
        /// 本地Hosts日期
        /// </summary>
        public string LocalHostsDate { get; private set; }

        /// <summary>
        /// 云端Hosts日期
        /// </summary>a
        public string NetworkHostsDate { get; private set; }

        #endregion

        #region 构造方法

        /// <param name="networkAdd">云端Hosts地址</param>
        /// <param name="hostsPath">本地Hosts路径</param>
        public UpdateHosts(string networkAdd, string hostsPath)
        {
            this._networkAdd = networkAdd;
            this._hostsPath = hostsPath;
        }

        #endregion

        #region 方法组

        /// <summary>
        /// 获取本地Hosts日期
        /// </summary>
        private void GetLocalHostsDate()
        {
            try
            {
                Regex regexLocal = new Regex(@"\d{4}-\d{2}-\d{2}");
                string localHostsString = File.ReadAllText(_hostsPath);

                LocalHostsDate = regexLocal.Match(localHostsString).ToString();
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText(_hostsPath, @"2000-00-00");
            }
        }

        /// <summary>
        /// 获取云端Hosts日期和文件
        /// </summary> 
        private void GetNetworHosts()
        {
            Regex regexNet = new Regex(@"\d{4}-\d{2}-\d{2}");
            WebClient webDownload = new WebClient { Credentials = CredentialCache.DefaultCredentials };
            _networkHostsString = webDownload.DownloadString(_networkAdd);

            NetworkHostsDate = regexNet.Match(_networkHostsString).ToString();
        }

        /// <summary>
        /// 对比文件日期并更新,返回 0:无需更新,1:已下载更新
        /// </summary>
        /// <returns>
        /// 0:无需更新
        /// 1:已下载更新
        /// </returns>
        public int CompareDate()
        {
            GetNetworHosts();
            GetLocalHostsDate();

            // 时间对比的结果
            int result;

            try
            {
                result = DateTime.Compare(DateTime.Parse(LocalHostsDate), DateTime.Parse(NetworkHostsDate));
            }
            catch (Exception)
            {
                result = -1;
            }

            if (result != -1) return 0;

            File.WriteAllText(_hostsPath, _networkHostsString);
            GetLocalHostsDate();
            return 1;
        }

        #endregion

    }
}