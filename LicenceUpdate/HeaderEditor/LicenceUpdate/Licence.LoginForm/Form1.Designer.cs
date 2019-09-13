namespace Licence.LoginForm
{
    partial class Form1
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
            this.login_username_label = new System.Windows.Forms.Label();
            this.login_password_label = new System.Windows.Forms.Label();
            this.login_username_text = new System.Windows.Forms.TextBox();
            this.login_password_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_username_label
            // 
            this.login_username_label.AutoSize = true;
            this.login_username_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_username_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.login_username_label.Location = new System.Drawing.Point(89, 95);
            this.login_username_label.Name = "login_username_label";
            this.login_username_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.login_username_label.Size = new System.Drawing.Size(55, 13);
            this.login_username_label.TabIndex = 0;
            this.login_username_label.Text = "Username";
            this.login_username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_password_label
            // 
            this.login_password_label.AutoSize = true;
            this.login_password_label.Location = new System.Drawing.Point(93, 151);
            this.login_password_label.Name = "login_password_label";
            this.login_password_label.Size = new System.Drawing.Size(53, 13);
            this.login_password_label.TabIndex = 1;
            this.login_password_label.Text = "Password";
            // 
            // login_username_text
            // 
            this.login_username_text.Location = new System.Drawing.Point(187, 95);
            this.login_username_text.Name = "login_username_text";
            this.login_username_text.Size = new System.Drawing.Size(156, 20);
            this.login_username_text.TabIndex = 2;
            // 
            // login_password_text
            // 
            this.login_password_text.Location = new System.Drawing.Point(187, 151);
            this.login_password_text.Name = "login_password_text";
            this.login_password_text.PasswordChar = '*';
            this.login_password_text.Size = new System.Drawing.Size(156, 20);
            this.login_password_text.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.login_button.Location = new System.Drawing.Point(187, 234);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(98, 32);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_password_text);
            this.Controls.Add(this.login_username_text);
            this.Controls.Add(this.login_password_label);
            this.Controls.Add(this.login_username_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_username_label;
        private System.Windows.Forms.Label login_password_label;
        private System.Windows.Forms.TextBox login_username_text;
        private System.Windows.Forms.TextBox login_password_text;
        private System.Windows.Forms.Button login_button;
    }
}

