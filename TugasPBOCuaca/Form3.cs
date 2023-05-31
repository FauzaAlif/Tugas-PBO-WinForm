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

namespace TugasPBOCuaca
{
    public partial class DetailTransaksi : Form
    {
        public DetailTransaksi()
        {
            InitializeComponent();
        }

        private void btn_insertTransaksi2_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO detail_transaksi(id_transaksi, id_laptop, stok_dibeli) VALUES ({tb_IDTransaksi.Text},{tb_IDlaptop2.Text},{tb_Jumlah.Text})";
            new DBHelpers().Execute(sql);
            new DBHelpers().Execute($"UPDATE laptop SET stok = stok - ({tb_Jumlah}) WHERE id_laptop = {tb_IDlaptop2.Text}");
            Input form = new Input();
            form.ShowDialog();
            this.Close();
        }
    }
}
