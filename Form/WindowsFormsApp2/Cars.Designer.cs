namespace WindowsFormsApp2
{
    partial class Cars
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
            this.btnRent = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblFuelCons = new System.Windows.Forms.Label();
            this.lblSeatCount = new System.Windows.Forms.Label();
            this.lblDoorCount = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(436, 12);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 21);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(279, 80);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand:";
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(279, 120);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(34, 13);
            this.lblCarType.TabIndex = 3;
            this.lblCarType.Text = "Type:";
            // 
            // lblFuelCons
            // 
            this.lblFuelCons.AutoSize = true;
            this.lblFuelCons.Location = new System.Drawing.Point(279, 162);
            this.lblFuelCons.Name = "lblFuelCons";
            this.lblFuelCons.Size = new System.Drawing.Size(71, 13);
            this.lblFuelCons.TabIndex = 4;
            this.lblFuelCons.Text = "Consumption:";
            // 
            // lblSeatCount
            // 
            this.lblSeatCount.AutoSize = true;
            this.lblSeatCount.Location = new System.Drawing.Point(279, 206);
            this.lblSeatCount.Name = "lblSeatCount";
            this.lblSeatCount.Size = new System.Drawing.Size(37, 13);
            this.lblSeatCount.TabIndex = 5;
            this.lblSeatCount.Text = "Seats:";
            // 
            // lblDoorCount
            // 
            this.lblDoorCount.AutoSize = true;
            this.lblDoorCount.Location = new System.Drawing.Point(396, 206);
            this.lblDoorCount.Name = "lblDoorCount";
            this.lblDoorCount.Size = new System.Drawing.Size(38, 13);
            this.lblDoorCount.TabIndex = 6;
            this.lblDoorCount.Text = "Doors:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(396, 80);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Location = new System.Drawing.Point(396, 120);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(58, 13);
            this.lblPricePerDay.TabIndex = 8;
            this.lblPricePerDay.Text = "Price/Day:";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(396, 162);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(71, 13);
            this.lblTransmission.TabIndex = 9;
            this.lblTransmission.Text = "Transmission:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 195);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 285);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblPricePerDay);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblDoorCount);
            this.Controls.Add(this.lblSeatCount);
            this.Controls.Add(this.lblFuelCons);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnRent);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblFuelCons;
        private System.Windows.Forms.Label lblSeatCount;
        private System.Windows.Forms.Label lblDoorCount;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}