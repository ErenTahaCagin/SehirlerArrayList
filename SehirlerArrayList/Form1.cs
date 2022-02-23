using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehirlerArrayList
{
    public partial class Form1 : Form
    {
        ArrayList sehirler = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehir.Text);

            Listele();
        }

        private void Listele()
        {
            lbListe.Items.Clear();

            foreach (string sehir in sehirler)
            {
                lbListe.Items.Add(sehir);
            }
        }

        private void btnAEkle_Click(object sender, EventArgs e)
        {
            int indexNo = lbListe.SelectedIndex;
            sehirler.Insert(indexNo, txtSehir.Text);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int indexNo = lbListe.SelectedIndex;
            sehirler[indexNo] = txtSehir.Text;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexNo = lbListe.SelectedIndex;
            sehirler.RemoveAt(indexNo);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(sehirler.Contains(txtSehir.Text))
            {
                lblDurum.Text = "Aranan Değer Bulundu.";
            }
            else
            {
                lblDurum.Text = "Aranan Değer Bulunamadı.";
            }
        }
    }
}
