using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugaspertemuan9
{
    public partial class InformasiOrangtua : Form
    {
        public InformasiOrangtua()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_namaOrtuLk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            InformasiSekolah insek = new InformasiSekolah();
            insek.Show();
        }
    }
}
