namespace Licence.LoginForm
{
    partial class Dummy
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
            this.dummy_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dummy_button
            // 
            this.dummy_button.Location = new System.Drawing.Point(145, 140);
            this.dummy_button.Name = "dummy_button";
            this.dummy_button.Size = new System.Drawing.Size(75, 23);
            this.dummy_button.TabIndex = 0;
            this.dummy_button.Text = "Exit";
            this.dummy_button.UseVisualStyleBackColor = true;
            this.dummy_button.Click += new System.EventHandler(this.dummy_button_Click);
            // 
            // Dummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dummy_button);
            this.Name = "Dummy";
            this.Text = "Dummy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dummy_button;
    }
}