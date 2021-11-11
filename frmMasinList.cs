using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasinKirayesi
{
    public partial class frmMasinList : Form
    {
        public frmMasinList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        baglanti bg = new baglanti();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow setir = dataGridView1.CurrentRow;
            nomretxt.Text = setir.Cells["Nomre"].Value.ToString();
            markacmb.Text = setir.Cells["Model"].Value.ToString();
            seriacmb.Text = setir.Cells["Seri"].Value.ToString();
            Iltxt.Text = setir.Cells["il"].Value.ToString();
            rengtxt.Text = setir.Cells["reng"].Value.ToString();
            KMtxt.Text = setir.Cells["km"].Value.ToString();
            yanacagcmb.Text = setir.Cells["yanacag"].Value.ToString();
            odenistxt.Text = setir.Cells["odenis"].Value.ToString();
            pictureBox1.ImageLocation = setir.Cells["sekil"].Value.ToString();
          
        }
        void Liste()
        {
            SqlDataAdapter dp = new SqlDataAdapter("select * from Masin", bg.Baglanti);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;     
        }

        private void frmMasinList_Load(object sender, EventArgs e)
        {
            Liste();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            bg.Baslat();
            SqlCommand cmd = new SqlCommand("update Masin set Model = @model,Seri = @seri,il = @il,reng = @reng,km = @km,yanacag = @yanacag,odenis = @odenis,tarix = @tarix,veziyyet = @veziyyet,sekil = @sekil where Nomre = @nomre ",bg.Baglanti);
            cmd.Parameters.AddWithValue("@model",markacmb.Text);
            cmd.Parameters.AddWithValue("@seri", seriacmb.Text);
            cmd.Parameters.AddWithValue("@il", Iltxt.Text);
            cmd.Parameters.AddWithValue("@reng", rengtxt.Text);
            cmd.Parameters.AddWithValue("@km", KMtxt.Text);
            cmd.Parameters.AddWithValue("@yanacag", yanacagcmb.Text);
            cmd.Parameters.AddWithValue("@odenis", odenistxt.Text);
            cmd.Parameters.AddWithValue("@sekil", pictureBox1.ImageLocation);
            cmd.Parameters.AddWithValue("Nomre", nomretxt.Text);
            cmd.Parameters.AddWithValue("@tarix", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@veziyyet", comboBox1.Text);
            pictureBox1.ImageLocation = "";
            cmd.ExecuteNonQuery();
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
            foreach (Control item in Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bg.Baslat();
            SqlCommand cmd = new SqlCommand("delete from Masin where Nomre = '" + dataGridView1.CurrentRow.Cells["Nomre"].Value.ToString() + "'", bg.Baglanti);
            cmd.ExecuteNonQuery();
            bg.Bitir();
            MessageBox.Show("Silmek Ugurla Heyata Kecirildi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Liste();
            pictureBox1.ImageLocation = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void combomasinlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combomasinlar.SelectedIndex == 0)
            {
                Liste();
            }
            if (combomasinlar.SelectedIndex == 1)
            {
                string cumle = "select * from Masin where veziyyet = 'Bos'";
                SqlDataAdapter dp = new SqlDataAdapter(cumle, bg.Baglanti);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (combomasinlar.SelectedIndex == 2)
            {
                string cumle = "select * from Masin where veziyyet = 'Dolu'";
                SqlDataAdapter dp = new SqlDataAdapter(cumle, bg.Baglanti);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
