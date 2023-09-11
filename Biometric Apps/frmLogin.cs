using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Biometric_Apps
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFinger_Click(object sender, EventArgs e)
        {
            VerificationForm var = new VerificationForm();
            var.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            if (var.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
               TextBoxcnic.Text = VerificationForm.cnic;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
       
       
    }
}