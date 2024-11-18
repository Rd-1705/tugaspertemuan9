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
    public partial class DataDiri : Form
    {
        public DataDiri()
        {
            InitializeComponent();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void btn_lanjut_Click(object sender, EventArgs e)
        {
            InformasiSekolah insek = new InformasiSekolah();
            insek.Show();
        }
    }
}
