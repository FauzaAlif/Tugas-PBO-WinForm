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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {
            new DBHelpers().Execute($"Delete from laptop where id_laptop = '{textBox1.Text}'");
            this.Close();
        }
    }
}
