namespace WFAdamAsmaca
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
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.pnlOyunAlani = new System.Windows.Forms.Panel();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnOnay = new System.Windows.Forms.Button();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.lblTahminHakki = new System.Windows.Forms.Label();
            this.lblHarfSayisi = new System.Windows.Forms.Label();
            this.flpKelime = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbKafa = new System.Windows.Forms.PictureBox();
            this.ptbGovde = new System.Windows.Forms.PictureBox();
            this.ptbSolKol = new System.Windows.Forms.PictureBox();
            this.ptSagKol = new System.Windows.Forms.PictureBox();
            this.ptbSagBacak = new System.Windows.Forms.PictureBox();
            this.ptbSolBacak = new System.Windows.Forms.PictureBox();
            this.pnlOyunAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGovde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSolKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSagKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSagBacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSolBacak)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.Location = new System.Drawing.Point(12, 245);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(553, 64);
            this.lblDurum.TabIndex = 2;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(12, 216);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(553, 23);
            this.btnBasla.TabIndex = 4;
            this.btnBasla.Text = "Oyuna Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // pnlOyunAlani
            // 
            this.pnlOyunAlani.Controls.Add(this.txtTahmin);
            this.pnlOyunAlani.Controls.Add(this.btnOnay);
            this.pnlOyunAlani.Controls.Add(this.txtHarf);
            this.pnlOyunAlani.Controls.Add(this.lblTahminHakki);
            this.pnlOyunAlani.Controls.Add(this.lblHarfSayisi);
            this.pnlOyunAlani.Controls.Add(this.flpKelime);
            this.pnlOyunAlani.Location = new System.Drawing.Point(12, 2);
            this.pnlOyunAlani.Name = "pnlOyunAlani";
            this.pnlOyunAlani.Size = new System.Drawing.Size(553, 211);
            this.pnlOyunAlani.TabIndex = 5;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Enabled = false;
            this.txtTahmin.Location = new System.Drawing.Point(225, 95);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.ReadOnly = true;
            this.txtTahmin.Size = new System.Drawing.Size(100, 20);
            this.txtTahmin.TabIndex = 9;
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(236, 174);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 23);
            this.btnOnay.TabIndex = 8;
            this.btnOnay.Text = "ONAY";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // txtHarf
            // 
            this.txtHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf.Location = new System.Drawing.Point(241, 121);
            this.txtHarf.Multiline = true;
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(65, 47);
            this.txtHarf.TabIndex = 7;
            this.txtHarf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTahminHakki
            // 
            this.lblTahminHakki.AutoSize = true;
            this.lblTahminHakki.Location = new System.Drawing.Point(19, 121);
            this.lblTahminHakki.Name = "lblTahminHakki";
            this.lblTahminHakki.Size = new System.Drawing.Size(0, 13);
            this.lblTahminHakki.TabIndex = 6;
            // 
            // lblHarfSayisi
            // 
            this.lblHarfSayisi.AutoSize = true;
            this.lblHarfSayisi.Location = new System.Drawing.Point(19, 99);
            this.lblHarfSayisi.Name = "lblHarfSayisi";
            this.lblHarfSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblHarfSayisi.TabIndex = 6;
            // 
            // flpKelime
            // 
            this.flpKelime.Location = new System.Drawing.Point(71, 10);
            this.flpKelime.Name = "flpKelime";
            this.flpKelime.Size = new System.Drawing.Size(414, 83);
            this.flpKelime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(696, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(829, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 214);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // ptbKafa
            // 
            this.ptbKafa.Location = new System.Drawing.Point(674, 25);
            this.ptbKafa.Name = "ptbKafa";
            this.ptbKafa.Size = new System.Drawing.Size(66, 57);
            this.ptbKafa.TabIndex = 7;
            this.ptbKafa.TabStop = false;
            // 
            // ptbGovde
            // 
            this.ptbGovde.Location = new System.Drawing.Point(703, 81);
            this.ptbGovde.Name = "ptbGovde";
            this.ptbGovde.Size = new System.Drawing.Size(10, 137);
            this.ptbGovde.TabIndex = 7;
            this.ptbGovde.TabStop = false;
            // 
            // ptbSolKol
            // 
            this.ptbSolKol.Location = new System.Drawing.Point(639, 107);
            this.ptbSolKol.Name = "ptbSolKol";
            this.ptbSolKol.Size = new System.Drawing.Size(65, 48);
            this.ptbSolKol.TabIndex = 7;
            this.ptbSolKol.TabStop = false;
            // 
            // ptSagKol
            // 
            this.ptSagKol.Location = new System.Drawing.Point(711, 107);
            this.ptSagKol.Name = "ptSagKol";
            this.ptSagKol.Size = new System.Drawing.Size(66, 48);
            this.ptSagKol.TabIndex = 7;
            this.ptSagKol.TabStop = false;
            // 
            // ptbSagBacak
            // 
            this.ptbSagBacak.Location = new System.Drawing.Point(711, 208);
            this.ptbSagBacak.Name = "ptbSagBacak";
            this.ptbSagBacak.Size = new System.Drawing.Size(66, 56);
            this.ptbSagBacak.TabIndex = 7;
            this.ptbSagBacak.TabStop = false;
            // 
            // ptbSolBacak
            // 
            this.ptbSolBacak.Location = new System.Drawing.Point(639, 208);
            this.ptbSolBacak.Name = "ptbSolBacak";
            this.ptbSolBacak.Size = new System.Drawing.Size(66, 56);
            this.ptbSolBacak.TabIndex = 7;
            this.ptbSolBacak.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 319);
            this.Controls.Add(this.ptbGovde);
            this.Controls.Add(this.ptbSolBacak);
            this.Controls.Add(this.ptbSagBacak);
            this.Controls.Add(this.ptSagKol);
            this.Controls.Add(this.ptbSolKol);
            this.Controls.Add(this.ptbKafa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlOyunAlani);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblDurum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOyunAlani.ResumeLayout(false);
            this.pnlOyunAlani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGovde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSolKol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSagKol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSagBacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSolBacak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Panel pnlOyunAlani;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Label lblHarfSayisi;
        private System.Windows.Forms.FlowLayoutPanel flpKelime;
        private System.Windows.Forms.Label lblTahminHakki;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbKafa;
        private System.Windows.Forms.PictureBox ptbGovde;
        private System.Windows.Forms.PictureBox ptbSolKol;
        private System.Windows.Forms.PictureBox ptSagKol;
        private System.Windows.Forms.PictureBox ptbSagBacak;
        private System.Windows.Forms.PictureBox ptbSolBacak;
    }
}

