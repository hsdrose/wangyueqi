using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SendMailAndReceiveMail
{
    public partial class SendFrm : Form
    {
        MainForm parentform;
        public SendFrm()
        {
            InitializeComponent();
        }

        public SendFrm( MainForm frm )
        {
            parentform = frm;
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            jmail.Message MailObj = new jmail.MessageClass();
            MailObj.From = parentform.txtMail.Text;  //发件人的地址
            MailObj.Logging = true;
            MailObj.MailServerUserName = parentform.txtMail.Text;   //发件人用户名
            MailObj.MailServerPassWord = parentform.txtPassWord.Text; //服务器验证
            MailObj.HTMLBody = txtMessage.Text;
            MailObj.Charset = "gb2312";
            MailObj.Subject = txtSubject.Text;
            MailObj.FromName = parentform.txtMail.Text;
            MailObj.AddRecipient(parentform.txtMail.Text, "User", "A");  //添加接收人
            MailObj.Priority = 3;
            if (txtAtt.Text != "")
            {
                MailObj.AddAttachment(txtAtt.Text, false, "image/jpg");
            }
            try
            {
                bool bool_OK = MailObj.Send(parentform.txtServer.Text, false);
                if (bool_OK == true)
                    MessageBox.Show("发送成功！");
                if (bool_OK == false)
                    MessageBox.Show("发送失败！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    // Insert code to read the stream here.
                    txtAtt.Text = openFileDialog1.FileName;

                    myStream.Close();
                }
            }

        }
    }
}
