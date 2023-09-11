using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Business_Entities;
using DAL;
using MySql.Data.MySqlClient;
namespace Biometric_Apps
{
    public partial class register : DevExpress.XtraEditors.XtraForm
    {
        DbConnection db = new DbConnection();
        public register()
        {
            InitializeComponent();
        }
        #region Add Staff Members
        public static List<Byte[]> prints = new List<byte[]>();
        Bus_Person busper = new Bus_Person();
        Dal_Person dalper = new Dal_Person();

       
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate()
            {
                Template = template;
                if (Template != null)
                    MessageBox.Show("The Fingerprint Template is Saved.", "Fingerprint Enrollment");
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }
        private DPFP.Template Template;
        delegate void Function();

        #endregion 
        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {
           
        }
        private void saveprints(Byte[] array)
        {
            DbConnection.CloseConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into Finger (nic,Finger)values(@cnic,@img)", DbConnection.con);

                cmd.Parameters.Add(new MySqlParameter("@cnic", TextBoxcnic.Text));
                cmd.Parameters.Add(new MySqlParameter("@img", array));
                if (DbConnection.con.State == System.Data.ConnectionState.Closed)
                {
                    DbConnection.con.Open();
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            EnrollmentForm rn = new EnrollmentForm();
            rn.OnTemplate += this.OnTemplate;
            rn.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (TextBoxcnic.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Reg ID");
                return;
            }
            if (prints.Count != 0)
            {
                foreach (Byte[] b in prints)
                {
                    saveprints(b);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Finger Prints");
            }
            
           
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}