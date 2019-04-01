namespace WindowsFormsApp2
{
    partial class RentedCars
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDoorCount = new System.Windows.Forms.Label();
            this.lblSeatCount = new System.Windows.Forms.Label();
            this.lblFuelCons = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(396, 165);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(71, 13);
            this.lblTransmission.TabIndex = 21;
            this.lblTransmission.Text = "Transmission:";
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Location = new System.Drawing.Point(396, 123);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(58, 13);
            this.lblPricePerDay.TabIndex = 20;
            this.lblPricePerDay.Text = "Price/Day:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(396, 83);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 19;
            this.lblModel.Text = "Model:";
            // 
            // lblDoorCount
            // 
            this.lblDoorCount.AutoSize = true;
            this.lblDoorCount.Location = new System.Drawing.Point(396, 209);
            this.lblDoorCount.Name = "lblDoorCount";
            this.lblDoorCount.Size = new System.Drawing.Size(38, 13);
            this.lblDoorCount.TabIndex = 18;
            this.lblDoorCount.Text = "Doors:";
            // 
            // lblSeatCount
            // 
            this.lblSeatCount.AutoSize = true;
            this.lblSeatCount.Location = new System.Drawing.Point(279, 209);
            this.lblSeatCount.Name = "lblSeatCount";
            this.lblSeatCount.Size = new System.Drawing.Size(37, 13);
            this.lblSeatCount.TabIndex = 17;
            this.lblSeatCount.Text = "Seats:";
            // 
            // lblFuelCons
            // 
            this.lblFuelCons.AutoSize = true;
            this.lblFuelCons.Location = new System.Drawing.Point(279, 165);
            this.lblFuelCons.Name = "lblFuelCons";
            this.lblFuelCons.Size = new System.Drawing.Size(71, 13);
            this.lblFuelCons.TabIndex = 16;
            this.lblFuelCons.Text = "Consumption:";
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(279, 123);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(34, 13);
            this.lblCarType.TabIndex = 15;
            this.lblCarType.Text = "Type:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(279, 83);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 14;
            this.lblBrand.Text = "Brand:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(430, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 23);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 195);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // RentedCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 284);
            this.Controls.Add(this.btnRemove);
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
            this.Name = "RentedCars";
            this.Text = "RentedCars";
            this.Load += new System.EventHandler(this.RentedCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDoorCount;
        private System.Windows.Forms.Label lblSeatCount;
        private System.Windows.Forms.Label lblFuelCons;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnRemove;
    }
}