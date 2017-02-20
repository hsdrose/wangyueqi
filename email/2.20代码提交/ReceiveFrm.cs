using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using jmail;
using System.IO;

namespace SendMailAndReceiveMail
{
    public partial class ReceiveFrm : Form
    {

        MainForm parentform;
     
        public ReceiveFrm(MainForm frm)
        {
            this.parentform = frm;
            InitializeComponent();
     
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
         
        }

        private void btnReceive_Click_1(object sender, EventArgs e)
        {
        
            ///建立收邮件对象   

            jmail.POP3Class popMail = new POP3Class();
            /**/
            ///建立邮件信息接口   
            jmail.Message mailMessage;

            /**/
            ///建立附件集接口   
            jmail.Attachments atts;

            /**/
            ///建立附件接口   
            jmail.Attachment att;
             
          
             
           
            try
            {
                popMail.Connect(parentform.txtMail.Text.Trim(), parentform.txtPassWord.Text.Trim(), parentform.txtServer.Text.Trim(), Convert.ToInt32(parentform.txtPoint.Text.Trim()));


                lsvMail.View = View.Details;
                // Allow the user to edit item text.
                lsvMail.LabelEdit = false;
                // Allow the user to rearrange columns.
                lsvMail.AllowColumnReorder = true;
                // Select the item and subitems when selection is made.
                lsvMail.FullRowSelect = true;
                // Display grid lines.
                lsvMail.GridLines = true;
                // Sort the items in the list in ascending order.
          
            

                /**/
                ///如果收到邮件   
                if (0 < popMail.Count)
                {
                    /**/
                    ///根据取到的邮件数量依次取得每封邮件   
                    for (int i = 1; i <= popMail.Count; i++)
                    {
                 

                        /**/
                        ///取得一条邮件信息   
                        mailMessage = popMail.Messages[i];

                        /**/
                        ///取得该邮件的附件集合   
                        atts = mailMessage.Attachments;
                   

                        /**/
                        ///设置邮件的编码方式                             
     


                        mailMessage.Silent = true;
                        mailMessage.EnableCharsetTranslation = true;
                        mailMessage.ContentTransferEncoding = "Base64";
                        mailMessage.Encoding = "Base64";
                        mailMessage.Charset = "gb2312";
                        mailMessage.ContentType = "text/html";
                        mailMessage.ISOEncodeHeaders = false; 



                        /**/
                        ///是否将信头编码成iso-8859-1字符集                           
                 
                        MailInfo MailInfoObj = new MailInfo();
                        MailInfoObj.MailSubject = mailMessage.Subject;
                        MailInfoObj.MailMessage = mailMessage.HTMLBody;
                        MailInfoObj.FromMail = mailMessage.From;
                        MailInfoObj.atts = new List<string>();
                        for (int j = 0; j < atts.Count; j++)
                        {
                            /**/
                            ///取得附件   
                            att = atts[j];

                            /**/
                            ///附件名称                                 
                            string atturl= "e:\\" + att.Name;
                            /**/
                            ///上传到服务器   
                            if (!File.Exists(atturl))
                            {
                                att.SaveToFile(atturl);
                            }
                            MailInfoObj.atts.Add(atturl);

                        }
                        ListViewItem item = new ListViewItem();
                        item.Text = mailMessage.From;
                        item.Tag = MailInfoObj;
                        lsvMail.Items.Add(item);
                    }

        
                }
                else
                {
                    lbMsg.Text = "没有新邮件!";
                }

                //popMail.DeleteMessages();
                popMail.Disconnect();
                popMail = null;
            }
            catch (Exception ex)
            {
                lbMsg.Text = "请检查邮件服务器的设置是否正确！";
            }

        }

        private void lsvMail_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (lsvMail.SelectedItems.Count > 0)
            {
                MailInfo mailMessage = (MailInfo)lsvMail.SelectedItems[0].Tag;
                panel1.Controls.Clear();

                txtMessage.DocumentText = mailMessage.MailMessage;
                txtSubject.Text = mailMessage.MailSubject;
                List<string> atts = mailMessage.atts;

                if (atts != null)
                {
                    LinkLabel linkLabel1 = new LinkLabel();
                    linkLabel1.Text = "共有" + atts.Count.ToString()+ "个附件" ;
                    for (int j = 0; j < atts.Count; j++)
                    {
                        /**/
                        ///取得附件   
                        string att = atts[j];

                        /**/
                        ///附件名称                                 


                        linkLabel1.Links[j].LinkData = att;

                        linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel_Click);

                        panel1.Controls.Add(linkLabel1);

                    }
                }
            }

        

        }

        private void linkLabel_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel lb = (LinkLabel)sender;

            try
            {
                System.Diagnostics.Process.Start(lb.Links[0].LinkData.ToString());
            }
            catch
            {
                MessageBox.Show("附件无法打开！");
            } 


        }
       
    }

     
}
