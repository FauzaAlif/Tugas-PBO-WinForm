using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPBOCuaca
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void btn_iya_Click(object sender, EventArgs e)
        {
            DetailTransaksi form = new DetailTransaksi();
            form.ShowDialog();
            this.Close();
        }

        private void btn_tidak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
