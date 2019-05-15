using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _2.Ödev
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void kayitListele_Click(object sender, EventArgs e)
        {
            //Dosyayı okumak üzere açar.
            FileStream fs2 = new FileStream("veri.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw2 = new StreamReader(fs2);

            char[,] renkler = new char[100, 4];
            string satir;
            int say = 0;
            int karakter = 0, bosluk=0;
            int [] kelimeHarfSayisi = new int[1000];

            while ((satir = sw2.ReadLine()) != null)    //Dosyayı satır satır okur.
            {
                for (int i = 0; i < 100; i++)
                {
                    if (say == i)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            renkler[i, k] = satir.ToCharArray()[k];
                        }
                    }
                }
                for (int i = 3; i < satir.ToString().Length; i++)
                {
                    if (satir[i].ToString()!=" ")
                    {
                        karakter++;
                    }
                    else if (satir[i].ToString() == " ")
                    {
                        kelimeHarfSayisi[bosluk] = karakter;
                        bosluk++;
                        karakter = 0;
                    }
                }

                var yenisatir = satir.Substring(4, satir.Length - 4);  //Dosyadaki satırların ilk 4 karakterini siler. 

                richTextBox1.AppendText(yenisatir + "\n");
                say++;
            }

            bosluk = 0;
            int sayac = 0, toplam = 0, diziToplam = 0, l = 0, satirSayisi=0;

            for (int i = 0; i < say; i++)   //Richtextbox'a yazmak üzere renk kontrolünü yapar.
            {
                while (l<3)
                {
                    if (renkler[i, l] == 'k')
                    {
                        richTextBox1.SelectionStart = diziToplam + kelimeHarfSayisi[sayac] + bosluk + i;
                        diziToplam = kelimeHarfSayisi[sayac] + diziToplam;
                        toplam = toplam + kelimeHarfSayisi[sayac + 1] + bosluk;
                        richTextBox1.SelectionLength = toplam;
                        if (satirSayisi % 2 == 0)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        }
                        else
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                        }
                        richTextBox1.SelectionColor = Color.Red;
                        sayac++;
                        bosluk++;
                        l++;
                    }
                    if (renkler[i, l] == 'm')
                    {
                        richTextBox1.SelectionStart = diziToplam + kelimeHarfSayisi[sayac] + bosluk+i;
                        diziToplam = kelimeHarfSayisi[sayac] + diziToplam;
                        toplam = toplam + kelimeHarfSayisi[sayac + 1] + bosluk;
                        richTextBox1.SelectionLength = toplam;
                        if (satirSayisi % 2 == 0)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        }
                        else
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                        }
                        richTextBox1.SelectionColor = Color.Blue;
                        bosluk++;
                        l++;
                        sayac++;
                    }
                    if (renkler[i, l] == 'y')
                    {
                        richTextBox1.SelectionStart = diziToplam + kelimeHarfSayisi[sayac] + bosluk+i;
                        diziToplam = kelimeHarfSayisi[sayac] + diziToplam;
                        toplam = toplam + kelimeHarfSayisi[sayac + 1] + bosluk;
                        richTextBox1.SelectionLength = toplam;
                        if (satirSayisi % 2 == 0)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        }
                        else
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                        }
                        richTextBox1.SelectionColor = Color.Green;
                        l++;
                        sayac++;
                        bosluk++;
                    }
                    
                }
                diziToplam = toplam;
                bosluk = 0;
                sayac++;
                l = 0;
                satirSayisi++;

            }
            sw2.Close();
            fs2.Close();

            kayitListele.Enabled = false;
        }
    }
}