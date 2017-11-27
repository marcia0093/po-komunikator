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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Login.FlatAppearance.BorderSize = 5;
            this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Login.Location = new System.Drawing.Point(54, 59);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(600, 150);
            this.Login.TabIndex = 0;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.login_Click);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.White;
            this.SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.SignUp.FlatAppearance.BorderSize = 5;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignUp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SignUp.Location = new System.Drawing.Point(54, 341);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(600, 159);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "REGISTER";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(660, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.Login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Choose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communicator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button button1;
    }
}