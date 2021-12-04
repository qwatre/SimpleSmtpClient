using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Net;




namespace SimpleSmtpClient
{
    public partial class mainForm : Form
    {
        private const int V = 300000;
        private const int MAX_LINES = 499;

        public mainForm()
        {
            InitializeComponent();
        }

        private void guiUseCredentials_CheckedChanged(object sender, EventArgs e)
        {
            guiUser.ReadOnly = true;
            guiPassword.ReadOnly = true;
            if (guiUseCredentials.Checked)
            {
                guiUser.ReadOnly = false;
                guiPassword.ReadOnly = false;
            }
        }

        private void guiSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Host = guiServerName.Text;
                client.Port = Convert.ToInt32(guiPort.Text);
                if (guiUseCredentials.Checked)
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(guiUser.Text, guiPassword.Text);
                }
                if (guiUseSsl.Checked)
                {
                    client.EnableSsl = true;
                }
                MailMessage message = CreateMailMessage();
                //client.Timeout = V;
                client.Send(message);
                MessageBox.Show("Email Sent.");
                //MessageBox.Show(""+client.Timeout);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private MailMessage CreateMailMessage()
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(guiEmailFrom.Text,guiFromName.Text);
            mailMessage.To.Add(guiEmailTo.Text);
            

            string str = textBox1.Text;
            IEnumerable<string> names = str
                                        .Split(new char[] { '\r' })
                                        .Where(x => x != null && x.Trim().Length > 0)
                                        .Select(x => x.Trim());

            foreach (var obj in names)
            {
                mailMessage.Bcc.Add(obj.ToString());
            }
            
            mailMessage.Body = htmlEditControl1.DocumentHTML.ToString();
            NameValueCollection c = new NameValueCollection();
                        
            


            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = guiEmailSubject.Text;
            return mailMessage;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            guiEmailFrom.Text = guiUser.Text;
            IPCLI.Text=GetIPAddress();
            guiEmailTo.Text = guiUser.Text;

            var path = System.IO.Path.GetDirectoryName(
      System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);
        
            

            using (var reader = new StreamReader(path+@"\smtp.csv"))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',',';');
                   
                    



                    comboBox1.Items.Add(values[0].ToString());
                    
                   
                       
                }
                




            }



        }

        private void guiUser_TextChanged(object sender, EventArgs e)
        {
            guiEmailFrom.Text = guiUser.Text;
            guiEmailTo.Text = guiUser.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        /*public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        */
        static string GetIPAddress()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
           


            using (WebResponse response = request.GetResponse())
            
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serverGroup_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailGroup_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guiUser.Text = comboBox1.Text;
            guiPassword.Text = comboBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Lines.Count() > MAX_LINES)
            {
                MessageBox.Show("max 499");
                textBox1.Clear();

            }
            






        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.textBox1.Lines.Length >= MAX_LINES && e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }
    }
}
