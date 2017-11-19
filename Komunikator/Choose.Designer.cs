namespace Communicator
{
    partial class Choose
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
            this.Login = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(239, 183);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(276, 159);
            this.Login.TabIndex = 0;
            this.Login.Text = "Zaloguj";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.login_Click);
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(521, 183);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(312, 159);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "Zarejestruj";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 597);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.Login);
            this.Name = "Choose";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button SignUp;
    }
}