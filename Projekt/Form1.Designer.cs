namespace Projekt
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiasto = new System.Windows.Forms.TextBox();
            this.btnSprawdzPogode = new System.Windows.Forms.Button();
            this.picIkonaPogody = new System.Windows.Forms.PictureBox();
            this.lblNazwaMiasta = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblWarunki = new System.Windows.Forms.Label();
            this.lblSzczegoly = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonaPogody)).BeginInit();
            this.SuspendLayout();
            
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz miasto:";
            
            this.txtMiasto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.txtMiasto.Location = new System.Drawing.Point(317, 25);
            this.txtMiasto.Name = "txtMiasto";
            this.txtMiasto.Size = new System.Drawing.Size(366, 54);
            this.txtMiasto.TabIndex = 1;
           
            this.btnSprawdzPogode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSprawdzPogode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSprawdzPogode.FlatAppearance.BorderSize = 0;
            this.btnSprawdzPogode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnSprawdzPogode.Location = new System.Drawing.Point(719, 25);
            this.btnSprawdzPogode.Name = "btnSprawdzPogode";
            this.btnSprawdzPogode.Size = new System.Drawing.Size(253, 54);
            this.btnSprawdzPogode.TabIndex = 2;
            this.btnSprawdzPogode.Text = "Sprawdź pogodę ->";
            this.btnSprawdzPogode.UseVisualStyleBackColor = false;
            this.btnSprawdzPogode.Click += new System.EventHandler(this.btnSprawdzPogode_Click);
            
            this.picIkonaPogody.BackColor = System.Drawing.Color.Transparent;
            this.picIkonaPogody.Location = new System.Drawing.Point(297, 225);
            this.picIkonaPogody.Name = "picIkonaPogody";
            this.picIkonaPogody.Size = new System.Drawing.Size(428, 404);
            this.picIkonaPogody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIkonaPogody.TabIndex = 3;
            this.picIkonaPogody.TabStop = false;
           
            this.lblNazwaMiasta.AutoSize = true;
            this.lblNazwaMiasta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F);
            this.lblNazwaMiasta.Location = new System.Drawing.Point(613, 115);
            this.lblNazwaMiasta.Name = "lblNazwaMiasta";
            this.lblNazwaMiasta.Size = new System.Drawing.Size(186, 58);
            this.lblNazwaMiasta.TabIndex = 4;
            this.lblNazwaMiasta.Text = "Miasto";
            
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F);
            this.lblTemperatura.Location = new System.Drawing.Point(874, 318);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(163, 116);
            this.lblTemperatura.TabIndex = 5;
            this.lblTemperatura.Text = "°C";
            
            this.lblWarunki.AutoSize = true;
            this.lblWarunki.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblWarunki.Location = new System.Drawing.Point(886, 500);
            this.lblWarunki.Name = "lblWarunki";
            this.lblWarunki.Size = new System.Drawing.Size(182, 46);
            this.lblWarunki.TabIndex = 6;
            this.lblWarunki.Text = "Warunki";
            
            this.lblSzczegoly.AutoSize = true;
            this.lblSzczegoly.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblSzczegoly.Location = new System.Drawing.Point(603, 728);
            this.lblSzczegoly.Name = "lblSzczegoly";
            this.lblSzczegoly.Size = new System.Drawing.Size(212, 46);
            this.lblSzczegoly.TabIndex = 7;
            this.lblSzczegoly.Text = "szczegóły";
            
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblStatus.Location = new System.Drawing.Point(1101, 949);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(421, 34);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status: Czekam na miasto...";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1534, 992);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSzczegoly);
            this.Controls.Add(this.lblWarunki);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblNazwaMiasta);
            this.Controls.Add(this.picIkonaPogody);
            this.Controls.Add(this.btnSprawdzPogode);
            this.Controls.Add(this.txtMiasto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIkonaPogody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiasto;
        private System.Windows.Forms.Button btnSprawdzPogode;
        private System.Windows.Forms.PictureBox picIkonaPogody;
        private System.Windows.Forms.Label lblNazwaMiasta;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblWarunki;
        private System.Windows.Forms.Label lblSzczegoly;
        private System.Windows.Forms.Label lblStatus;
    }
}

