namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "E-Mail:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(214, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(122, 20);
            this.txtUsername.TabIndex = 8;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(214, 70);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(123, 20);
            this.txtFirstname.TabIndex = 9;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(214, 103);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(122, 20);
            this.txtLastname.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(214, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(122, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtConfPassword
            // 
            this.txtConfPassword.Location = new System.Drawing.Point(214, 180);
            this.txtConfPassword.Name = "txtConfPassword";
            this.txtConfPassword.Size = new System.Drawing.Size(122, 20);
            this.txtConfPassword.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(124, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 315);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button3;
    }
}