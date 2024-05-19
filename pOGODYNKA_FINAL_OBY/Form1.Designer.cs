namespace pOGODYNKA_FINAL_OBY
{
    partial class Pogodynka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Wyszukiwanie = new System.Windows.Forms.TextBox();
            this.WyszukiwanieButton = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.labTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miasto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Wyszukiwanie
            // 
            this.Wyszukiwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyszukiwanie.Location = new System.Drawing.Point(125, 24);
            this.Wyszukiwanie.Name = "Wyszukiwanie";
            this.Wyszukiwanie.Size = new System.Drawing.Size(100, 29);
            this.Wyszukiwanie.TabIndex = 2;
            this.Wyszukiwanie.Tag = "";
            this.Wyszukiwanie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WyszukiwanieButton
            // 
            this.WyszukiwanieButton.Location = new System.Drawing.Point(231, 30);
            this.WyszukiwanieButton.Name = "WyszukiwanieButton";
            this.WyszukiwanieButton.Size = new System.Drawing.Size(75, 23);
            this.WyszukiwanieButton.TabIndex = 3;
            this.WyszukiwanieButton.Text = "Szukaj";
            this.WyszukiwanieButton.UseVisualStyleBackColor = true;
            this.WyszukiwanieButton.Click += new System.EventHandler(this.WyszukiwanieButton_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.SystemColors.Control;
            this.labCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCondition.Location = new System.Drawing.Point(165, 84);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(76, 24);
            this.labCondition.TabIndex = 4;
            this.labCondition.Text = "Pogoda";
            this.labCondition.Click += new System.EventHandler(this.label2_Click);
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.SystemColors.Control;
            this.labDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labDetails.Location = new System.Drawing.Point(165, 118);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(81, 24);
            this.labDetails.TabIndex = 5;
            this.labDetails.Text = "Szegóły";
            this.labDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labDetails.Click += new System.EventHandler(this.labDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(397, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wschód:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.SystemColors.Control;
            this.labSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSunrise.Location = new System.Drawing.Point(488, 84);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(42, 24);
            this.labSunrise.TabIndex = 7;
            this.labSunrise.Text = "N/A";
            this.labSunrise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.SystemColors.Control;
            this.labSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSunset.Location = new System.Drawing.Point(488, 118);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(42, 24);
            this.labSunset.TabIndex = 9;
            this.labSunset.Text = "N/A";
            this.labSunset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labSunset.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(397, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zachód:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.SystemColors.Control;
            this.labPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPressure.Location = new System.Drawing.Point(204, 209);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(42, 24);
            this.labPressure.TabIndex = 13;
            this.labPressure.Text = "N/A";
            this.labPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(50, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ciśnienie";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.labWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labWindSpeed.Location = new System.Drawing.Point(204, 174);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(42, 24);
            this.labWindSpeed.TabIndex = 11;
            this.labWindSpeed.Text = "N/A";
            this.labWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(50, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Prędkość wiatru:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(54, 84);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(105, 74);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 14;
            this.picIcon.TabStop = false;
            // 
            // labTemperature
            // 
            this.labTemperature.AutoSize = true;
            this.labTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.labTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTemperature.Location = new System.Drawing.Point(50, 84);
            this.labTemperature.Name = "labTemperature";
            this.labTemperature.Size = new System.Drawing.Size(42, 24);
            this.labTemperature.TabIndex = 15;
            this.labTemperature.Text = "N/A";
            this.labTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labTemperature.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Pogodynka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 317);
            this.Controls.Add(this.labTemperature);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.WyszukiwanieButton);
            this.Controls.Add(this.Wyszukiwanie);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Pogodynka";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Wyszukiwanie;
        private System.Windows.Forms.Button WyszukiwanieButton;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labTemperature;
    }
}

