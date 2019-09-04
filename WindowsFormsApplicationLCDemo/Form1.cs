using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationLCDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss = HttpPost(
                "http://112.124.58.198:2010/DataShare/api/Account/Login?loginName=htdzadmin&loginPwd=e10adc3949ba59abbe56e057f20f883e",
                "");
            Console.WriteLine(ss);
            //Console.ReadKey();

            apiBoxShow.Text = ss;
        }

        public static string HttpPost(string url, string body)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "POST";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            //request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 1.1.4322)";


            //CookieContainer CookiesContainer = null ;

            //if (CookiesContainer == null)
            //{
            //    CookiesContainer = new CookieContainer();
            //}

            //request.CookieContainer = CookiesContainer;  //启用cookie


            byte[] buffer = encoding.GetBytes(body);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ss = HttpGet("https://api.douban.com/v2/movie/in_theaters?count=3");
        }

        public static string HttpGet(string url)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, application/xml;q=0.9, */*;q=0.8";
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "HelloWorld LC ";

            HelloWorldLabel.Text = "HelloWorld LC Label";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void HTGETRealTimeDataAPIbutton_Click(object sender, EventArgs e)
        {
            // String ss = "HELLO LC 你好啊！";
            string ss = HttpPost(
                "http://112.124.58.198:2010/DataShare/api/FLMeter/GetRealTimeData?SharedNo=FM0000000348", "");
            // string ss = HttpGet("http://112.124.58.198:2010/DataShare/api/FLMeter/GetRealTimeData?SharedNo=FM0000000348");
            Console.WriteLine(ss);
            // Console.ReadKey();

            apiBoxShow.Text = ss;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void HT_Login_POST_button_Click(object sender, EventArgs e)
        {
            string ss = HttpPost(
                "http://112.124.58.198:2010/DataShare/api/Account/Login?loginName=htdzadmin&loginPwd=e10adc3949ba59abbe56e057f20f883e",
                "");
            Console.WriteLine(ss);
            // Console.Read();
            // Cookie c = new Cookie();

            apiBoxShow.Text = ss;
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {
                MessageBox.Show("sendTo title contents 必填，不能没有内容");
            }
            else
            {
                String sendTo = textBox3.Text;
                String title = textBox4.Text;
                String contents = textBox2.Text;

//            SendMailUse(sendTo, title, contents);
                SendMailUse2(sendTo, title, contents);
            }
        }

        private void SendMailUse(string sendTo, string title, string contents)
        {
            string host = "smtp.163.com"; // 邮件服务器smtp.163.com表示网易邮箱服务器    
            string userName = "###@163.com"; // 发送端账号   
            string password = "lc201088"; // 发送端密码(这个客户端重置后的密码)


            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network; //指定电子邮件发送方式    
            client.Host = host; //邮件服务器
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(userName, password); //用户名、密码

            //////////////////////////////////////
            string strfrom = userName;
            string strto = sendTo; // "ahlc@sina.cn";
            // string strcc = "#@qq.com";//抄送
            
            string subject = title; //"这是测试邮件标题LC From C#";//邮件的主题             
            string body = contents; //"测试邮件内容LC From C#";//发送的邮件正文  

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.From = new MailAddress(strfrom, "LC of 163");
            msg.To.Add(strto);
            //  msg.CC.Add(strcc);

            msg.Subject = subject; //邮件标题   
            msg.Body = body; //邮件内容   
            msg.BodyEncoding = System.Text.Encoding.UTF8; //邮件内容编码   
            msg.IsBodyHtml = true; //是否是HTML邮件   
            msg.Priority = MailPriority.High; //邮件优先级   
            
            try
            {
                client.Send(msg);
                Console.WriteLine("发送成功！");
                MessageBox.Show("发送给:" + sendTo + " 的邮件成功！");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                Console.WriteLine(ex.Message, "发送邮件出错！");
            }
        }

        /**
         * 优化版本-优化异常抛出
         */
        private void SendMailUse2(string sendTo, string title, string contents)
        {
            string host = "smtp.163.com"; // 邮件服务器smtp.163.com表示网易邮箱服务器    
            string userName = "###@163.com"; // 发送端账号   
            string password = "lc201088"; // 发送端密码(这个客户端重置后的密码)
            
            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network; //指定电子邮件发送方式    
            client.Host = host; //邮件服务器
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(userName, password); //用户名、密码

            //////////////////////////////////////
            string strfrom = userName;
            string strto = sendTo; // "ahlc@sina.cn";
            // string strcc = "#@qq.com";//抄送
            
            string subject = title; //"这是测试邮件标题LC From C#";//邮件的主题             
            string body = contents; //"测试邮件内容LC From C#";//发送的邮件正文  

            try
            {
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.From = new MailAddress(strfrom, "LC of 163");
                msg.To.Add(strto);
                //  msg.CC.Add(strcc);
                msg.Subject = subject; //邮件标题   
                msg.Body = body; //邮件内容   
                msg.BodyEncoding = System.Text.Encoding.UTF8; //邮件内容编码   
                msg.IsBodyHtml = true; //是否是HTML邮件   
                msg.Priority = MailPriority.High; //邮件优先级  

                client.Send(msg);
                Console.WriteLine("发送成功！");
                MessageBox.Show("发送给:" + sendTo + " 的邮件成功！");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message, "发送邮件出错！");
                MessageBox.Show("发送邮件出错！ " + ex.Message.ToString());
            }
        }


        public static void SendMailUse()
        {
            string host = "smtp.163.com"; // 邮件服务器smtp.163.com表示网易邮箱服务器    
            string userName = "###@163.com"; // 发送端账号   
            string password = "lc201088"; // 发送端密码(这个客户端重置后的密码)


            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network; //指定电子邮件发送方式    
            client.Host = host; //邮件服务器
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(userName, password); //用户名、密码

            //////////////////////////////////////
            string strfrom = userName;
            string strto = "ahlc@sina.cn";
            // string strcc = "#@qq.com";//抄送


            string subject = "这是测试邮件标题LC From C#"; //邮件的主题             
            string body = "测试邮件内容LC From C#"; //发送的邮件正文  

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.From = new MailAddress(strfrom, "LC of 163");
            msg.To.Add(strto);
            //  msg.CC.Add(strcc);

            msg.Subject = subject; //邮件标题   
            msg.Body = body; //邮件内容   
            msg.BodyEncoding = System.Text.Encoding.UTF8; //邮件内容编码   
            msg.IsBodyHtml = true; //是否是HTML邮件   
            msg.Priority = MailPriority.High; //邮件优先级   


            try
            {
                client.Send(msg);
                Console.WriteLine("发送成功");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                Console.WriteLine(ex.Message, "发送邮件出错");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}