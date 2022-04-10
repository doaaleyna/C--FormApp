using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arabaYarissi
{
    public partial class Anasayfafrm : Form
    {
        public Anasayfafrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyunfrm frm1 = new oyunfrm();
            frm1.Show();
            this.Hide();
            

        }
    }
}
