using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace WFAdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlOyunAlani.Enabled = false;
            flpKelime.Enabled = false;
            this.BackColor = Color.SlateGray;

            #region Picturbox Resim yolları
            ptbKafa.Image = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}/Adam/kafa.jpg");
            ptbKafa.BackgroundImageLayout = ImageLayout.Stretch;
            ptbGovde.Image = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}/Adam/govde.jpg");
            ptbGovde.BackgroundImageLayout = ImageLayout.Stretch;
            ptbSagBacak.Image = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}/Adam/sagayak.jpg");
            ptbSagBacak.BackgroundImageLayout = ImageLayout.Stretch;
            ptbSolBacak.Image = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}/Adam/solayak.jpg");
            ptbSolBacak.BackgroundImageLayout = ImageLayout.Stretch;
            ptSagKol.Image = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}/Adam/sagkol.JPG");
            ptSagKol.BackgroundImageLayout = ImageLayout.Stretch;
            ptbSolKol.Image = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}/Adam/solkol.JPG");
            ptbSolKol.BackgroundImageLayout = ImageLayout.Stretch;
            #endregion
            PicturboxDefault();
        }

        #region Global Tanımlamalar
        int Hak = 7;
        string Kelime=string.Empty;
        char[] Harf;
        string[] KelimeKutusu = {"araba","otobüs","ev","deniz","telefon"};
        int GelenDeger = 0;
        //object[] labelSirasi;
        Label lbl = new Label();
        Random rnd = new Random(); int a = 0;
        
        #endregion

        private void btnBasla_Click(object sender, EventArgs e)
        {
            KelimeOku();
            pnlOyunAlani.Enabled = true;
        }
     
        private void btnOnay_Click(object sender, EventArgs e)
        {
            HarfVarMi();
        }

        void LabelDefault()
        {
            lblDurum.Font = new Font("Arial Black", 10);
            lblDurum.TextAlign = ContentAlignment.MiddleCenter;
        }
     
        void PicturboxDefault()
        { 
                   ptbSolBacak.Visible = false;
                   
                   ptbSagBacak.Visible = false;
                   
                   ptbSolKol.Visible = false;
                   
                   ptSagKol.Visible = false;
                   
                   ptbGovde.Visible = false;

                   ptbKafa.Visible = false;
        }
        
        private void HarfVarMi()
        {
            if (string.IsNullOrEmpty(txtHarf.Text))
            {
                
            }
            else if (Kelime.IndexOf(txtHarf.Text)==-1)
            {   
                LabelDefault();
                lblDurum.BackColor = Color.Red;
                lblDurum.ForeColor = Color.White;
                lblDurum.Text = txtHarf.Text.ToUpper()+" harfi mevcut değil".ToUpper();
                Hak--; lblTahminHakki.Text = " ";
                lblTahminHakki.Text += "Tahmin Hakkı: " + Convert.ToString(Hak);
                switch (Hak)
                {
                    case 1: ptbSolBacak.Visible = true;
                        break;
                    case 2: ptbSagBacak.Visible = true;
                        break;
                    case 3: ptbSolKol.Visible = true;
                        break;
                    case 4: ptSagKol.Visible = true;
                        break;
                    case 5: ptbGovde.Visible = true;
                        break;
                    case 6: ptbKafa.Visible = true;
                        break;
                    default: lblDurum.Text = "Oyun Bitti";
                        break;
                }
                if (Hak==0)
                {
                    OyunuKaybetti();
                }
            }
            else
            {  
                txtTahmin.Clear();
               // GelenDeger = Kelime.IndexOf(txtHarf.Text);
                LabelDefault();
                lblDurum.BackColor = Color.Green;
                lblDurum.ForeColor = Color.YellowGreen;
                lblDurum.Text = txtHarf.Text.ToUpper() + " harfi mevcut.".ToUpper();
                OyunuKazandi();
            }
        }
          
        private void KelimeOku()
        {
            Hak = 7;
            lblTahminHakki.Text=lblHarfSayisi.Text = string.Empty;
            a = rnd.Next(1, 4);
            Kelime = KelimeKutusu[a];
            lblHarfSayisi.Text +="Harf Sayısı: "+Kelime.Length.ToString();
            lblTahminHakki.Text +="Tahmin Hakkı: "+Convert.ToString(Hak);
            
            KelimeTahminiOlustur();
            
        }

        private void KelimeTahminiOlustur()
        {
           flpKelime.Controls.Clear();
            for (int i = 0; i < Kelime.Length; i++)
            {
                Label lblalan = new Label();
                lblalan.Font = new Font("Thoma", 25);
                lblalan.Width = lblalan.Height = 61;
                lblalan.TextAlign = ContentAlignment.BottomCenter;
                lblalan.BackColor = Color.SkyBlue;
                lblalan.ForeColor = Color.White;
                lblalan.Text="_";
                lblalan.Tag = Kelime[i].ToString();
                flpKelime.Controls.Add(lblalan);
            }
        }

        private void OyunuKaybetti()
        {   
            foreach (Control item in flpKelime.Controls)
            {
                lbl = (Label)item;
                lbl.Text = lbl.Tag.ToString();
            }
        DialogResult dr = MessageBox.Show("Üzgünüm Oyunu Kaybettiniz Çıkmak için HAYIR'ı, Yeni Oyun için EVET'i seçiniz.","Oyun Bitti",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                    switch (dr)
                    {
                        case DialogResult.No: Application.Exit();
                            break;

                        case DialogResult.Yes: KelimeOku();
                            break;
                    }
                    PicturboxDefault();
        }

        private void OyunuKazandi()
        {
            if (txtTahmin.Text.Equals(Kelime))
            {
                DialogResult dr = MessageBox.Show("Oyunu Kazandınız Çıkmak için HAYIR'ı, Yeni Oyun için EVET'i seçiniz.", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                switch (dr)
                {
                    case DialogResult.No: Application.Exit();
                        break;

                    case DialogResult.Yes: KelimeOku();
                        break;
                }
            }
        }
    }
}
