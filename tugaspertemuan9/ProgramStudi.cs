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
    public partial class ProgramStudi : Form
    {
        public ProgramStudi()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            InformasiOrangtua infoOrtu = new InformasiOrangtua();
            infoOrtu.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
