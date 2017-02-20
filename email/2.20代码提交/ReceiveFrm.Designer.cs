namespace SendMailAndReceiveMail
{
    partial class ReceiveFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.lsvMail = new System.Windows.Forms.ListView();
            this.Address = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FormMailAddress:";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(79, 378);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "收取";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "MailMessage:";
            // 
            // lbMsg
            // 
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(204, 384);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(383, 23);
            this.lbMsg.TabIndex = 7;
            // 
            // lsvMail
            // 
            this.lsvMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address});
            this.lsvMail.Location = new System.Drawing.Point(12, 44);
            this.lsvMail.Name = "lsvMail";
            this.lsvMail.Size = new System.Drawing.Size(142, 328);
            this.lsvMail.TabIndex = 8;
            this.lsvMail.UseCompatibleStateImageBehavior = false;
            this.lsvMail.SelectedIndexChanged += new System.EventHandler(this.lsvMail_SelectedIndexChanged);
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 100;
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(237, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 41);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Attachment:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(237, 96);
            this.txtMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(468, 229);
            this.txtMessage.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Subject:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(237, 50);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(468, 21);
            this.txtSubject.TabIndex = 14;
            // 
            // ReceiveFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 415);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvMail);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.label1);
            this.Name = "ReceiveFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiveMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView lsvMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser txtMessage;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubject;

    }
}

