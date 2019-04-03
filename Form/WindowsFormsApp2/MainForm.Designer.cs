namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.AccSettings = new System.Windows.Forms.Button();
            this.RentedCars = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back to Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(12, 12);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(161, 56);
            this.buttonAddCar.TabIndex = 1;
            this.buttonAddCar.Text = "Cars";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // AccSettings
            // 
            this.AccSettings.Location = new System.Drawing.Point(439, 12);
            this.AccSettings.Name = "AccSettings";
            this.AccSettings.Size = new System.Drawing.Size(161, 56);
            this.AccSettings.TabIndex = 2;
            this.AccSettings.Text = "Account Settings";
            this.AccSettings.UseVisualStyleBackColor = true;
            this.AccSettings.Click += new System.EventHandler(this.AccSettings_Click);
            // 
            // RentedCars
            // 
            this.RentedCars.Location = new System.Drawing.Point(224, 12);
            this.RentedCars.Name = "RentedCars";
            this.RentedCars.Size = new System.Drawing.Size(161, 56);
            this.RentedCars.TabIndex = 3;
            this.RentedCars.Text = "Rented Cars";
            this.RentedCars.UseVisualStyleBackColor = true;
            this.RentedCars.Click += new System.EventHandler(this.RentedCars_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "About us";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(824, 577);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RentedCars);
            this.Controls.Add(this.AccSettings);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(840, 616);
            this.MinimumSize = new System.Drawing.Size(840, 616);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button AccSettings;
        private System.Windows.Forms.Button RentedCars;
        private System.Windows.Forms.Button button2;
    }
}