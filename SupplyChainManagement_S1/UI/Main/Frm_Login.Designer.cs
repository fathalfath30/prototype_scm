namespace SupplyChainManagement_S1.UI.Main
{
    partial class Frm_Login
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Login = new MetroFramework.Controls.MetroButton();
            this.Btn_Batal = new MetroFramework.Controls.MetroButton();
            this.Lnbl_Lupa_password = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password :";
            // 
            // Txt_Username
            // 
            this.Txt_Username.AcceptsTab = true;
            this.Txt_Username.Location = new System.Drawing.Point(104, 59);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(286, 20);
            this.Txt_Username.TabIndex = 2;
            this.Txt_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Username_KeyDown);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(104, 88);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(286, 20);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Password_KeyDown);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(196, 114);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(94, 25);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseSelectable = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Batal
            // 
            this.Btn_Batal.Location = new System.Drawing.Point(296, 114);
            this.Btn_Batal.Name = "Btn_Batal";
            this.Btn_Batal.Size = new System.Drawing.Size(94, 25);
            this.Btn_Batal.TabIndex = 5;
            this.Btn_Batal.Text = "Batal";
            this.Btn_Batal.UseSelectable = true;
            this.Btn_Batal.Click += new System.EventHandler(this.Btn_Batal_Click);
            // 
            // Lnbl_Lupa_password
            // 
            this.Lnbl_Lupa_password.Location = new System.Drawing.Point(23, 116);
            this.Lnbl_Lupa_password.Name = "Lnbl_Lupa_password";
            this.Lnbl_Lupa_password.Size = new System.Drawing.Size(105, 23);
            this.Lnbl_Lupa_password.TabIndex = 6;
            this.Lnbl_Lupa_password.Text = "Lupa Password";
            this.Lnbl_Lupa_password.UseSelectable = true;
            this.Lnbl_Lupa_password.Click += new System.EventHandler(this.Lnbl_Lupa_password_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 161);
            this.Controls.Add(this.Lnbl_Lupa_password);
            this.Controls.Add(this.Btn_Batal);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Frm_Login";
            this.Resizable = false;
            this.Text = "User Authentication";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.TextBox Txt_Password;
        private MetroFramework.Controls.MetroButton Btn_Login;
        private MetroFramework.Controls.MetroButton Btn_Batal;
        private MetroFramework.Controls.MetroLink Lnbl_Lupa_password;
    }
}