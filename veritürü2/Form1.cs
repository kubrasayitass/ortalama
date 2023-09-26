using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritürü2
{
    public partial class lblSonuc2 : Form
    {
        public lblSonuc2()
        {
            InitializeComponent();
        }

        private void lblSonuc2_Load(object sender, EventArgs e)
        {
            int 
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int not1, not2;
            double sonuc;

            not1 = Convert.ToInt32(txtSayi1.Text);
            not2 = Convert.ToInt32(txtSayi2.Text);

            sonuc = (not1 + not2) / 2;

            lblSonuc.Text = sonuc.ToString();

                                                                              
        }
    }
}
