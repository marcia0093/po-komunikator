namespace Communicator
{
    partial class Register
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
            this.register_login = new System.Windows.Forms.TextBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_login
            // 
            this.register_login.Location = new System.Drawing.Point(411, 138);
            this.register_login.Name = "register_login";
            this.register_login.Size = new System.Drawing.Size(502, 31);
            this.register_login.TabIndex = 0;
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(411, 191);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(501, 31);
            this.register_password.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 88);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zarejestruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 858);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_login);
            this.Name = "Register";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox register_login;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}