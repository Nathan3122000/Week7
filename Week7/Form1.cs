using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxKalimat_TextChanged(object sender, EventArgs e)
        {
            labelHasil.Text = textBoxKalimat.Text;
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            string hasil = labelHasil.Text;
            foreach (char huruf in labelHasil.Text)
            {
                    Convert.ToString(huruf).Replace(textBoxHurufAwal.Text, textBoxHurufAkhir.Text);
            }
        }
    }
}
