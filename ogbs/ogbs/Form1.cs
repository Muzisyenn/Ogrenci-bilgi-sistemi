using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogbs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            ogrenci ogrenciForm = new ogrenci();
            ogrenciForm.Show();
            this.Hide();
        }

        private void btnogretmen_Click(object sender, EventArgs e)
        {
            ogretmen ogretmenForm = new ogretmen();
            ogretmenForm.Show();
            this.Hide();
        }

        private void btnmemur_Click(object sender, EventArgs e)
        {
            memur memurForm = new memur();
            memurForm.Show();
            this.Hide();
        }
    }
}
