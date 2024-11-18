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
    public partial class Home : System.Windows.Forms.Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void PNLisian_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Black;
             
            int borderWhidth = 3;

            Graphics g = e.Graphics;

            using (Pen pen = new Pen(borderColor, borderWhidth))
            {
                g.DrawRectangle(pen, 1, 1, PNLisian.Width - 1, PNLisian.Height - 1);
            }
        }

        private void bDatadiri_Click(object sender, EventArgs e)
        {
            DataDiri dd = new DataDiri();
            dd.Show();
        }

        private void bInfosekolah_Click(object sender, EventArgs e)
        {
            InformasiSekolah insek = new InformasiSekolah();
            insek.Show();
        }

        private void bInfoOrtu_Click(object sender, EventArgs e)
        {
            InformasiOrangtua infoOrtu = new InformasiOrangtua();
            infoOrtu.Show();
        }

        private void bProgram_Click(object sender, EventArgs e)
        {
            ProgramStudi prosud = new ProgramStudi();
            prosud.Show();
        }
    }
}
