namespace StrayRabbit.MMS.WindowsForm
{
    partial class Login
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
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.txt_userName = new DevExpress.XtraEditors.TextEdit();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.EditValue = "";
            this.txt_password.Location = new System.Drawing.Point(383, 185);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(160, 20);
            this.txt_password.TabIndex = 17;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // txt_userName
            // 
            this.txt_userName.EditValue = "";
            this.txt_userName.Location = new System.Drawing.Point(383, 152);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(160, 20);
            this.txt_userName.TabIndex = 16;
            this.txt_userName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // btn_login
            // 
            this.btn_login.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_login.ImageOptions.Image = global::StrayRabbit.MMS.WindowsForm.Properties.Resources.ok;
            this.btn_login.Location = new System.Drawing.Point(383, 229);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 21;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_cancle.ImageOptions.Image = global::StrayRabbit.MMS.WindowsForm.Properties.Resources.Cancle;
            this.btn_cancle.Location = new System.Drawing.Point(476, 229);
            this.btn_cancle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 22;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::StrayRabbit.MMS.WindowsForm.Properties.Resources.Login1;
            this.ClientSize = new System.Drawing.Size(575, 281);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.TextEdit txt_userName;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.SimpleButton btn_cancle;
    }
}