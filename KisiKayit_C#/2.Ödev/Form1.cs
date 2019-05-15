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
    public partial class Form1 : Form
    {
        
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }
       

        private void KayitEkle_Click(object sender, EventArgs e)
        {
            frm2.Show();    //Kayıt eklenen formu açar.
            
        }

        private void KayitList_Click(object sender, EventArgs e)
        {
            frm3.Show();    //Kayıt listelenen formu açar.
           
        }

    }
    
}
