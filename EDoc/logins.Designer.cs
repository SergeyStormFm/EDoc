namespace EDoc
{
    partial class logins
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.text_login = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.text_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(51, 19);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 0;
            this.textBox_login.Text = "1";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(68, 68);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Ok";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_logins_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(227, 68);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancels_Click);
            // 
            // text_login
            // 
            this.text_login.AutoSize = true;
            this.text_login.Location = new System.Drawing.Point(12, 26);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(33, 13);
            this.text_login.TabIndex = 3;
            this.text_login.Text = "Login";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(233, 19);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.Text = "1";
            // 
            // text_pass
            // 
            this.text_pass.AutoSize = true;
            this.text_pass.Location = new System.Drawing.Point(174, 26);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(53, 13);
            this.text_pass.TabIndex = 5;
            this.text_pass.Text = "Password";
            // 
            // logins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 124);
            this.ControlBox = false;
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.textBox_login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "logins";
            this.Text = "login";
            this.Load += new System.EventHandler(this.logins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label text_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label text_pass;
        private EDOCDataSet eDOCDataSet;
        private EDOCDataSetTableAdapters.userTableAdapter userTableAdapter;
        private EDOCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}