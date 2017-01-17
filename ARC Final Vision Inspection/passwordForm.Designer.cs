namespace ARC_Final_Vision_Inspection
{
    partial class passwordForm
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
            this.passwordCancelButton = new System.Windows.Forms.Button();
            this.passwordOKButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // passwordCancelButton
            // 
            this.passwordCancelButton.Location = new System.Drawing.Point(133, 90);
            this.passwordCancelButton.Name = "passwordCancelButton";
            this.passwordCancelButton.Size = new System.Drawing.Size(67, 24);
            this.passwordCancelButton.TabIndex = 11;
            this.passwordCancelButton.Text = "Cancel";
            this.passwordCancelButton.UseVisualStyleBackColor = true;
            this.passwordCancelButton.Click += new System.EventHandler(this.passwordCancelButton_Click);
            // 
            // passwordOKButton
            // 
            this.passwordOKButton.Location = new System.Drawing.Point(28, 90);
            this.passwordOKButton.Name = "passwordOKButton";
            this.passwordOKButton.Size = new System.Drawing.Size(67, 24);
            this.passwordOKButton.TabIndex = 10;
            this.passwordOKButton.Text = "OK";
            this.passwordOKButton.UseVisualStyleBackColor = true;
            this.passwordOKButton.Click += new System.EventHandler(this.passwordOKButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(100, 18);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 7;
            this.usernameTextbox.Text = "admin";
            this.usernameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTextbox_KeyPress);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(100, 44);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox.TabIndex = 6;
            this.passwordTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextbox_KeyPress);
            // 
            // passwordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 133);
            this.Controls.Add(this.passwordCancelButton);
            this.Controls.Add(this.passwordOKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Name = "passwordForm";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passwordCancelButton;
        private System.Windows.Forms.Button passwordOKButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.MaskedTextBox passwordTextbox;
    }
}