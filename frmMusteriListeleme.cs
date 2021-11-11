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
    public partial class frmMusteriListeleme : Form
    {
        public frmMusteriListeleme()
        {
            InitializeComponent();
        }
        baglanti bg = new baglanti();

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Liste()
        {
            SqlDataAdapter dp = new SqlDataAdapter("select * from Musteri", bg.Baglanti);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Sexsiyyet Vesiqesinin No";
            dataGridView1.Columns[1].HeaderText = "Adi Ve Soyadi";
            dataGridView1.Columns[2].HeaderText = "Telefon Nomresi";
            dataGridView1.Columns[3].HeaderText = "Adresi";
            dataGridView1.Columns[4].HeaderText = "Email";
        }

        private void frmMusteriListeleme_Load_1(object sender, EventArgs e)
        {
            Liste();
            formDropShadow1.ShadowAngle = 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bg.Baslat();
            SqlDataAdapter dp = new SqlDataAdapter("select * from Musteri where AzeNo like '%" + textBox1.Text + "%'", bg.Baglanti);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            bg.Bitir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow setir = dataGridView1.CurrentRow;
            txtaze.Text = setir.Cells[0].Value.ToString();
            txtadsoyad.Text = setir.Cells[1].Value.ToString();
            txttelefon.Text = setir.Cells[2].Value.ToString();
            txtadres.Text = setir.Cells[3].Value.ToString();
            txtemail.Text = setir.Cells[4].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            bg.Baslat();
            SqlCommand update = new SqlCommand(" update Musteri set adsoyad = @namesurname,telefon = @telefon,adres = @adres,email = @email where AzeNo = @azeno", bg.Baglanti);
            update.Parameters.AddWithValue("@azeno", txtaze.Text);
            update.Parameters.AddWithValue("@namesurname", txtadsoyad.Text);
            update.Parameters.AddWithValue("@telefon", txttelefon.Text);
            update.Parameters.AddWithValue("@adres", txtadres.Text);
            update.Parameters.AddWithValue("@email", txtemail.Text);
        
            update.ExecuteNonQuery();
            bg.Bitir();
            MessageBox.Show("Guncelleme Heyata Kecirildi");
            Liste();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            bg.Baslat();
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter("select * from Musteri where AzeNo like '%" + textBox1.Text + "%'", bg.Baglanti);
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            bg.Bitir();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bg.Baslat();
            SqlCommand cmd = new SqlCommand("delete from Musteri where AzeNo = '" + dataGridView1.CurrentRow.Cells["AzeNo"].Value.ToString() + "'", bg.Baglanti);
            cmd.ExecuteNonQuery();
            bg.Bitir();
            MessageBox.Show("Silmek Ugurla Heyata Kecirildi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
