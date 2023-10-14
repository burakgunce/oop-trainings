using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSekillerDunyasi
{
    public partial class Form2 : Form
    {
        List<ICizilebilir> sekiller = new List<ICizilebilir>();
        Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            //// ornek dd
            //e.Graphics.FillRectangle(Brushes.Red, 100, 100, 300, 200);
            //// ornek elips
            //e.Graphics.FillEllipse(Brushes.Green, 150, 150, 200, 200);
            ////kendi fırcamızla cızım
            //Brush firca = new SolidBrush(Color.FromArgb(128, 90, 180, 120));
            //e.Graphics.FillRectangle(firca, 150, 150, 200, 200);

            foreach (var sekil in sekiller)
            {
                sekil.Ciz(e.Graphics);
            }
            pnlCizim.Refresh();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sekil s;

            switch (cboTur.SelectedItem?.ToString())
            {
                case "Dikdörtgen":
                    s = new Dikdortgen();
                    break;
                case "Elips":
                    s = new Elips();
                    break;


                default:
                    MessageBox.Show("lutfen bır sekıl secınız");
                    return;
            }

            s.X = (int)nudX.Value;
            s.Y = (int)nudY.Value;
            s.Genislik = (int)nudGenislik.Value;
            s.Yukseklik = (int)nudYukseklik.Value;
            s.Renk = pboRenk.BackColor;
            sekiller.Add(s);

            SekilleriListele();
            lstSekiller.SelectedItem = s;

        }

        private void SekilleriListele()
        {
            lstSekiller.Items.Clear();
            foreach (Sekil sekil in sekiller)
            {
                lstSekiller.Items.Add(sekil);
            }

        }

        private void pboRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pboRenk.BackColor = colorDialog1.Color;
        }

        private void SeciliSekliListedeTasi(int yeniIndex)
        {
            if (lstSekiller.SelectedItem is Dikdortgen)
            {
                Dikdortgen secilenSekil = (Dikdortgen)lstSekiller.SelectedItem;
                sekiller.Remove(secilenSekil);
                sekiller.Insert(yeniIndex, secilenSekil);
                SekilleriListele();
                pnlCizim.Refresh();
                lstSekiller.SelectedIndex = yeniIndex;
            }
            else
            {
                Elips secilenSekil = (Elips)lstSekiller.SelectedItem;
                sekiller.Remove(secilenSekil);
                sekiller.Insert(yeniIndex, secilenSekil);
                SekilleriListele();
                pnlCizim.Refresh();
                lstSekiller.SelectedIndex = yeniIndex;
            }
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            if (sid < 1) return;
            SeciliSekliListedeTasi(sid - 1);
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            if (sid < 0 || sid == sekiller.Count - 1) return;
            SeciliSekliListedeTasi(sid + 1);
        }

        private void btnRastgeleEkle_Click(object sender, EventArgs e)
        {
            int mx = (int)pnlCizim.Width; // max x
            int my = (int)pnlCizim.Height; // max y
            int mw = (int)pnlCizim.Width; // max width
            int mh = (int)pnlCizim.Height; // max height
            int sc = (int)cboTur.Items.Count; // shapes count
            int mc = 256; // max color

            nudX.Value = rnd.Next(mx);
            nudY.Value = rnd.Next(my);
            nudGenislik.Value = rnd.Next(mw - (int)nudX.Value); // kenarlara tasmaması ıcın
            nudYukseklik.Value = rnd.Next(mh - (int)nudY.Value);
            pboRenk.BackColor = Color.FromArgb(rnd.Next(mc), rnd.Next(mc), rnd.Next(mc), rnd.Next(mc));
            cboTur.SelectedIndex = rnd.Next(sc);
            btnEkle.PerformClick();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            sekiller.Clear();
            SekilleriListele();
            pnlCizim.Refresh();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SeciliKisiyiSil();
        }

        private void SeciliKisiyiSil()
        {
            sekiller.RemoveAt(lstSekiller.SelectedIndex);
            SekilleriListele();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pnlCizim.Width, pnlCizim.Height);
            pnlCizim.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            bmp.Save(@"\deneme.png", ImageFormat.Png);
        }


        private void btnMetinEkle_Click(object sender, EventArgs e)
        {
            Yazi yazi = new Yazi((int)nudX.Value,(int)nudY.Value,txtMetin.Text,pboRenk.BackColor);
        }
    }
}
