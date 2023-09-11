namespace Biometric_Apps
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnFinger = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxcnic = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxcnic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.Location = new System.Drawing.Point(180, 21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(244, 33);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "BIOMETRIC - LOGIN";
            // 
            // btnFinger
            // 
            this.btnFinger.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnFinger.Appearance.Options.UseFont = true;
            this.btnFinger.ImageOptions.Image = global::Biometric_Apps.Properties.Resources.fingerprint_48;
            this.btnFinger.Location = new System.Drawing.Point(167, 156);
            this.btnFinger.Name = "btnFinger";
            this.btnFinger.Size = new System.Drawing.Size(278, 75);
            this.btnFinger.TabIndex = 18;
            this.btnFinger.Text = "Verify FingerPrint";
            this.btnFinger.Click += new System.EventHandler(this.btnFinger_Click);
            // 
            // TextBoxcnic
            // 
            this.TextBoxcnic.Enabled = false;
            this.TextBoxcnic.Location = new System.Drawing.Point(195, 107);
            this.TextBoxcnic.Name = "TextBoxcnic";
            this.TextBoxcnic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TextBoxcnic.Properties.Appearance.Options.UseFont = true;
            this.TextBoxcnic.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TextBoxcnic.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TextBoxcnic.Properties.MaxLength = 10;
            this.TextBoxcnic.Size = new System.Drawing.Size(220, 26);
            this.TextBoxcnic.TabIndex = 19;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 267);
            this.Controls.Add(this.TextBoxcnic);
            this.Controls.Add(this.btnFinger);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxcnic.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnFinger;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TextBoxcnic;
    }
}