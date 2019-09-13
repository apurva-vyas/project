namespace LU.UserInterface
{
    partial class login
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
            this.username1 = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username1
            // 
            this.username1.Location = new System.Drawing.Point(441, 121);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(100, 20);
            this.username1.TabIndex = 0;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(441, 173);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(100, 20);
            this.password1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbutton.Location = new System.Drawing.Point(452, 256);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.username1);
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbutton;
    }
}

