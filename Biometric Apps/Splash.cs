using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Biometric_Apps
{
    public partial class Splash : SplashScreen
    {
        int count = 30;
        public Splash()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count -= 1;
            if (count == 0)
            {
                timer1.Stop();
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();

            }
        }
    }
}