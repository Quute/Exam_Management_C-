namespace notkayit
{
    partial class FormOgrenciDetay
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
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblSınav1 = new System.Windows.Forms.Label();
            this.LblSınav2 = new System.Windows.Forms.Label();
            this.LblSınav3 = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblNumara = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblOrtalama = new System.Windows.Forms.Label();
            this.LblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(101, 51);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(133, 24);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "İsim Soyisim:";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numara:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınav 1:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınav 2:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınav 3:";
            // 
            // LblSınav1
            // 
            this.LblSınav1.AutoSize = true;
            this.LblSınav1.Location = new System.Drawing.Point(186, 212);
            this.LblSınav1.Name = "LblSınav1";
            this.LblSınav1.Size = new System.Drawing.Size(34, 24);
            this.LblSınav1.TabIndex = 5;
            this.LblSınav1.Text = "00";
            // 
            // LblSınav2
            // 
            this.LblSınav2.AutoSize = true;
            this.LblSınav2.Location = new System.Drawing.Point(186, 265);
            this.LblSınav2.Name = "LblSınav2";
            this.LblSınav2.Size = new System.Drawing.Size(34, 24);
            this.LblSınav2.TabIndex = 6;
            this.LblSınav2.Text = "00";
            // 
            // LblSınav3
            // 
            this.LblSınav3.AutoSize = true;
            this.LblSınav3.Location = new System.Drawing.Point(186, 317);
            this.LblSınav3.Name = "LblSınav3";
            this.LblSınav3.Size = new System.Drawing.Size(34, 24);
            this.LblSınav3.TabIndex = 7;
            this.LblSınav3.Text = "00";
            this.LblSınav3.Click += new System.EventHandler(this.label8_Click);
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(240, 51);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(64, 24);
            this.LblAdSoyad.TabIndex = 8;
            this.LblAdSoyad.Text = "NULL";
            // 
            // LblNumara
            // 
            this.LblNumara.AutoSize = true;
            this.LblNumara.Location = new System.Drawing.Point(186, 92);
            this.LblNumara.Name = "LblNumara";
            this.LblNumara.Size = new System.Drawing.Size(58, 24);
            this.LblNumara.TabIndex = 9;
            this.LblNumara.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "ORTALAMA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "DURUM:";
            // 
            // LblOrtalama
            // 
            this.LblOrtalama.AutoSize = true;
            this.LblOrtalama.Location = new System.Drawing.Point(234, 368);
            this.LblOrtalama.Name = "LblOrtalama";
            this.LblOrtalama.Size = new System.Drawing.Size(34, 24);
            this.LblOrtalama.TabIndex = 12;
            this.LblOrtalama.Text = "00";
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Location = new System.Drawing.Point(201, 420);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(34, 24);
            this.LblDurum.TabIndex = 13;
            this.LblDurum.Text = "00";
            // 
            // FormOgrenciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.LblOrtalama);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblNumara);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.LblSınav3);
            this.Controls.Add(this.LblSınav2);
            this.Controls.Add(this.LblSınav1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOgrenciDetay";
            this.Text = "Ogrenci Not Kayit Sistemi";
            this.Load += new System.EventHandler(this.FormOgrenciDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblSınav1;
        private System.Windows.Forms.Label LblSınav2;
        private System.Windows.Forms.Label LblSınav3;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblNumara;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblOrtalama;
        private System.Windows.Forms.Label LblDurum;
    }
}