using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MasinKirayesi
{
    public partial class frmsatis : Form
    {
        public frmsatis()
        {
            InitializeComponent();
        }
        baglanti bg = new baglanti();
        private void frmsatis_Load(object sender, EventArgs e)
        {
            string sorguu = "select * from satis";
            SqlDataAdapter adtrr = new SqlDataAdapter();
            dataGridView1.DataSource = listele(adtrr,sorguu);
            Satishesabla(label1);
        }
        void Liste()
        {
            SqlDataAdapter dp = new SqlDataAdapter("select * from muqavile", bg.Baglanti);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Satishesabla(Label lbl)
        {
            bg.Baslat();
            SqlCommand cmd = new SqlCommand("select sum(satis_tutar) from satis",bg.Baglanti);
            lbl.Text = "Cemi Mebleg:    " + cmd.ExecuteScalar() + "AZN";
            bg.Bitir();
        }
        DataTable tablo;
        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu,bg.Baglanti);
            adtr.Fill(tablo);
            bg.Bitir();
            return tablo;
        }
    }
}
