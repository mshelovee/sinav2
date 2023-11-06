using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace uygsinav2_96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbTaksit.Minimum = 1;
            tbTaksit.Maximum = 6;

        }

        private void tbTaksit_Scroll(object sender, EventArgs e)
        {
            int adet, taksit;
            double taksitliTutar, birim;
            taksit = tbTaksit.Value;
            birim = Convert.ToInt32(txtBirim.Text);

            taksitliTutar = birim / taksit;

            lblTutar.Text = taksitliTutar.ToString();
        }
    }
}
