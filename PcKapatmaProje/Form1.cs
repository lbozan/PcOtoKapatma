using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PcKapat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Islem> _islem;
        private void Form1_Load(object sender, EventArgs e)
        {
            _islem = new List<Islem>();
            tmr.Start();
            cbislem.Items.Add(IslemSira.OturumuKapat);
            cbislem.Items.Add(IslemSira.Kapat);
            cbislem.Items.Add(IslemSira.Uyku);
            cbislem.Items.Add(IslemSira.YenidenB);
            numericSaat.Value = DateTime.Now.Hour;
            numericDakika.Value = DateTime.Now.Minute;
            numericSaniye.Value = DateTime.Now.Second;
            Menu.Enabled = false;

        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            int saat = DateTime.Now.Hour;
            int dakika = DateTime.Now.Minute;
            int saniye = DateTime.Now.Second;
            lblSaat.Text = string.Format("{0}:{1}:{2}", saat, dakika, saniye);
            _islem.Where(x => x.saat == saat && x.dakika == dakika && x.saniye == saniye).ToList().ForEach(x =>
            {
                switch (x.islem)
                {
                    //Bekleme, //Uyku, //YenidenB, //Kapat
                    case "OturumuKapat":
                        if (x.zorlama)
                        {
                            Process.Start("shutdown", "-l -f");
                        }
                        else
                        {
                            Process.Start("shutdown", "-l");
                        }
                        break;
                    case "Uyku":
                        if (x.zorlama)
                        {
                            Process.Start("shutdown", "-h -f");
                        }
                        else
                        {
                            Process.Start("shutdown", "-h");
                        }
                        break;
                    case "YenidenB":
                        if (x.zorlama)
                        {
                            Process.Start("shutdown", "-r -f");
                        }
                        else
                        {
                            Process.Start("shutdown", "-r");
                        }
                        break;
                    case "Kapat":
                        if (x.zorlama)
                        {
                            Process.Start("shutdown", "-s -f");
                        }
                        else
                        {
                            Process.Start("shutdown", "-s");
                        }
                        break;
                    default:
                        MessageBox.Show("Bir İşlem Başlatılamadı..");
                        break;
                }
            });

        }
        int say = 0;
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                say += 1;
                int saat = (int)numericSaat.Value;
                int dakika = (int)numericDakika.Value;
                int saniye = (int)numericSaniye.Value;
                bool zorla = cbZorla.Checked;
                _islem.Add(new Islem() { saat = saat, dakika = dakika, saniye = saniye, islem = cbislem.SelectedItem.ToString(), zorlama = zorla });

                lbislemSira.Items.Add(string.Format("{0}.Sıra | Zaman-> {1}:{2}:{3} | İşlem-> {4} | Kapatmayı Zorla->{5}", say, saat, dakika, saniye, cbislem.SelectedItem, zorla));


            }
            catch
            {
                MessageBox.Show("Bir İşlem Hatası Oluştu");
            }

        }
        //todo : asss
        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
        private void iptalToolStripMenuItem_Clickj(object sender, EventArgs e)
        {

            if (lbislemSira.SelectedIndex != -1)
            {
                lbislemSira.Items[lbislemSira.SelectedIndex] = "Boşaltıldı";
            }
        }
        private void lbislemSira_SelectedIndexChanged(object sender, EventArgs e)
        {
            Menu.Enabled = true;
        }
    }
    internal class Islem
    {
        public int saat { get; set; }
        public int dakika { get; set; }
        public int saniye { get; set; }
        public string islem { get; set; }
        public bool zorlama { get; set; }
    }
    internal enum IslemSira
    {
        OturumuKapat,
        Uyku,
        YenidenB,
        Kapat
    }
}
