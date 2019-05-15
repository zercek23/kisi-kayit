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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void telefonNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TelefonNoTextBox'a rakam hariç yazılamaz.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 
        }

        private void telefonNoTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            //Tıklayınca yazıları siler.
            telefonNoTextBox.Text = "";
        }

        private void telefonNoTextBox_Leave(object sender, EventArgs e)
        {
            if (telefonNoTextBox.Text == "")
            {
                telefonNoTextBox.Text = "05*********";
            }
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            var isim = isimTextBox.Text;
            var soyisim = soyisimTextBox.Text;
            var telefonNo = Convert.ToInt64(telefonNoTextBox.Text);

            //Dosyayı üstüne yazmak üzere açar.
            FileStream fs = new FileStream("veri.txt", FileMode.Append, FileAccess.Write);
            StreamWriter yaz = new StreamWriter(fs);

            //Veriler girildi mi bunu kontrol eder.
            if (!kirmiziRadioButton1.Checked && !maviRadioButton1.Checked && !yesilRadioButton1.Checked)
            {
                MessageBox.Show("İsminiz için renk seçmediniz.");
            }
            else if (isim == "")
            {
                MessageBox.Show("İsminizi girmediniz.");
            }
            else if (!kirmiziRadioButton2.Checked && !maviRadioButton2.Checked && !yesilRadioButton2.Checked)
            {
                MessageBox.Show("Soyisminiz için renk seçmediniz.");
            }
            else if (soyisim == "")
            {
                MessageBox.Show("Soyisminizi girmediniz.");
            }
            else if (!kirmiziRadioButton3.Checked && !maviRadioButton3.Checked && !yesilRadioButton3.Checked)
            {
                MessageBox.Show("Telefon numaranız için renk seçmediniz.");
            }
            else if (telefonNoTextBox.Text == "05*********")
            {
                MessageBox.Show("Telefon numaranızı girmediniz.");
            }
            else
            {
                if (kirmiziRadioButton1.Checked)
                {
                    yaz.Write("k");
                }
                else if (maviRadioButton1.Checked)
                {
                    yaz.Write("m");
                }
                else if (yesilRadioButton1.Checked)
                {
                    yaz.Write("y");
                }
                else MessageBox.Show("İsim için bir renk seçilmedi.");

                if (kirmiziRadioButton2.Checked)
                {
                    yaz.Write("k");
                }
                else if (maviRadioButton2.Checked)
                {
                    yaz.Write("m");
                }
                else if (yesilRadioButton2.Checked)
                {
                    yaz.Write("y");
                }
                else MessageBox.Show("Soyisim için bir renk seçilmedi.");

                if (kirmiziRadioButton3.Checked)
                {
                    yaz.Write("k");
                }
                else if (maviRadioButton3.Checked)
                {
                    yaz.Write("m");
                }
                else if (yesilRadioButton3.Checked)
                {
                    yaz.Write("y");
                }
                else MessageBox.Show("Telefon numarası için bir renk seçilmedi.");
                
                //Dosyaya verileri yazar.
                yaz.Write(" " + isim + " ");
                yaz.Write(soyisim + " ");
                yaz.Write(telefonNo + " ");
                yaz.WriteLine();
                MessageBox.Show("KAYIT İŞLEMİ BAŞARILI!");
            }

            yaz.Flush();
            yaz.Close();
            fs.Close();
        }


    }
}

