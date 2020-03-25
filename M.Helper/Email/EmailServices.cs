using M.Helper.AppConfigurtaion;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace M.Helper.Email
{
    /// <summary>
    /// 邮件服务
    /// </summary>
    public class EmailServices
    {
        /// <summary>
        /// 发件人邮箱账号
        /// </summary>
        protected static string AddresserID { get; set; }

        /// <summary>
        /// 发件人邮箱名称
        /// </summary>
        protected static string AddresserName { get; set; }

        /// <summary>
        /// 邮件标题
        /// </summary>
        protected static string MailTitle { get; set; }

        /// <summary>
        /// 邮件内容后缀
        /// </summary>
        protected static string MailContent { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        protected static string Host { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        protected static int Port { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        protected static string AuthorzationCode { get; set; }

        /// <summary>
        /// 验证码位数
        /// </summary>
        protected static int RandomCodeDigit { get; set; }

        static EmailServices()
        {
            // 拿到邮件服务配置信息
            AddresserID = AppConfigurtaionService.Configuration["EmailServicesStrings:AddresserID"];
            AddresserName = AppConfigurtaionService.Configuration["EmailServicesStrings:AddresserName"];
            MailTitle = AppConfigurtaionService.Configuration["EmailServicesStrings:MailTitle"];
            MailContent = AppConfigurtaionService.Configuration["EmailServicesStrings:MailContent"];
            Host = AppConfigurtaionService.Configuration["EmailServicesStrings:Host"];
            Port = int.Parse(AppConfigurtaionService.Configuration["EmailServicesStrings:Port"]);
            AuthorzationCode = AppConfigurtaionService.Configuration["EmailServicesStrings:AuthorzationCode"];
            // 拿到验证码位数
            RandomCodeDigit = int.Parse(AppConfigurtaionService.Configuration["EmailServicesStrings:RandomCodeDigit"]);
        }

        /// <summary>
        /// 验证码生成
        /// </summary>
        /// <returns>验证码</returns>
        public string RandomCode()
        {
            var randomCodeDigit = RandomCodeDigit * RandomCodeDigit;
            int[] Code = new int[randomCodeDigit];
            string CodeStr = "";
            Random r = new Random();
            for (int i = 0; i < randomCodeDigit; i++)
            {
                Code[i] = r.Next(0, 9);
            }
            for (int i = 0; i < RandomCodeDigit; i++)
            {
                CodeStr += Code[r.Next(0, randomCodeDigit - 1)];
            }
            return CodeStr;
        }

        /// <summary>
        /// 发送QQ邮件
        /// </summary>
        /// <param name="RecipientId">收件人邮箱账号</param>
        /// <param name="RecipientBody">邮件内容</param>
        public string SendQQEmail(string recipientId, string recipientBody)
        {
            // 实例化一个发送邮件类
            MailMessage mailMessage = new MailMessage();
            // 发件人邮箱地址。
            mailMessage.From = new MailAddress(AddresserID, AddresserName);
            // 收件人邮箱地址。
            mailMessage.To.Add(new MailAddress(recipientId));
            // 邮件标题。
            mailMessage.Subject = MailTitle;
            // 邮件内容。
            mailMessage.Body = recipientBody + string.Format(MailContent, DateTime.Now.ToString());
            // 实例化一个SmtpClient类。
            SmtpClient client = new SmtpClient
            {
                // IP地址
                Host = Host,
                // 端口号
                Port = Port,
                // 使用安全加密连接。
                EnableSsl = true,
                // 不和请求一块发送。
                UseDefaultCredentials = false,
                // 验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
                Credentials = new NetworkCredential(AddresserID, AuthorzationCode)
            };
            // 签名证书
            ServicePointManager.ServerCertificateValidationCallback = delegate (Object obj, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
            // 发送
            client.Send(mailMessage);
            // 返回生成的邮件内容
            return mailMessage.Body;
        }

        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="recipientId">收件人账号</param>
        /// <returns></returns>
        public string SendRandomCode(string recipientId)
        {
            // 生成验证码
            string randomCode = RandomCode();
            string recipientBody = string.Format("【{0}】您的邮箱验证码是：{1}。请在页面中提交验证码完成验证。", AppConfigurtaionService.Configuration["ProjectInfo:Project_Name"], randomCode);
            return SendQQEmail(recipientId, recipientBody);
        }
    }
}
