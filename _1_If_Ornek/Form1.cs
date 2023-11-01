using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_If_Ornek
{
    public partial class Form1 : Form
    {
        // SORU : Girilen 3 sayıdan hangisi en büyük, hangisi en küçük hangisi ortancadır , bulan programı yazınız
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, enBuyuk, enKucuk, ortanca;
            if (txtSayi1.Text == "" || txtSayi2.Text == "" || txtSayi3.Text == "")
            {
                MessageBox.Show("Lütfen Bütün sayıları giriniz");
             }
            else {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
                sayi3 = Convert.ToInt32(txtSayi3.Text);

                if (sayi1 > sayi2 && sayi1 > sayi3)
                {
                    enBuyuk = sayi1;

                } else if (sayi2 > sayi1 && sayi2 > sayi3)
                {
                    enBuyuk = sayi2;
                }
                else
                {
                    enBuyuk = sayi3;
                }
                //-----------------------------------------------------
                if (sayi1 < sayi2 && sayi1 < sayi3)
                {
                    enKucuk = sayi1;

                } else if (sayi2 < sayi1 && sayi2 < sayi3)
                {
                    enKucuk = sayi2;
                }
                else
                {
                    enKucuk = sayi3;
                }
                //-----------------------------------------------------

                if (sayi1 < enBuyuk && sayi1 > enKucuk)
                {
                    ortanca = sayi1;
                }
                else if (sayi2 < enBuyuk && sayi2 > enKucuk)
                {
                    ortanca = sayi2;
                }
                else
                {
                    ortanca = sayi3;
                }
                MessageBox.Show("EN BÜYÜK : " + enBuyuk + "\nORTANCA : " + ortanca + "\nEN KÜÇÜK : " + enKucuk);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
