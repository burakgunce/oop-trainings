using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSekillerDunyasi
{
    public partial class Form2 : Form
    {
        List<Sekil> sekiller = new List<Sekil>();
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
                lstSekiller.SelectedIndex = yeniIndex;
            }
            else
            {
                Elips secilenSekil = (Elips)lstSekiller.SelectedItem;
                sekiller.Remove(secilenSekil);
                sekiller.Insert(yeniIndex, secilenSekil);
                SekilleriListele();
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

        }
    }
}
