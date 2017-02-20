using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SendMailAndReceiveMail
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendFrm frm = new SendFrm(this);
            frm.ShowDialog();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ReceiveFrm frm = new ReceiveFrm(this);
            frm.ShowDialog();
        }
    }
}
