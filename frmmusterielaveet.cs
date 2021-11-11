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
    public partial class frmmusterielaveet : Form
    {
        public frmmusterielaveet()
        {
            InitializeComponent();
        }
        baglanti bg = new baglanti();

        private void frmmusterielaveet_Load(object sender, EventArgs e)
        {
            formDropShadow1.ShadowAngle = 20;
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

            if (txtadsoyad.TextLength == 0 || txtaze.TextLength == 0 || txtemail.TextLength == 0 || txtadres.TextLength == 0 || txttelefon.TextLength == 0)
            {
                MessageBox.Show("Xahis Edirik Bos Yerleri Doldurun!", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (adduser(Convert.ToInt32(txtaze.Text), txtadsoyad.Text, txttelefon.Text,txtemail.Text,txtadres.Text))
                {
                    MessageBox.Show("Istifadeci Elave Olundu");
                    txtaze.Clear();
                    txtadsoyad.Clear();
                    txttelefon.Clear();
                    txtemail.Clear();
                    txtadres.Clear();
                }
            }
        }
        public bool adduser(int azeno, string adsoyad, string telefon, string adres, string email)
        {
            SqlCommand insrt = new SqlCommand("insert into Musteri(AzeNo,adsoyad,telefon,adres,email) values (@azeno,@namesurname,@telefon,@adres,@email) ", bg.Baglanti);
            insrt.Parameters.AddWithValue("@azeno", azeno);
            insrt.Parameters.AddWithValue("@namesurname", adsoyad);
            insrt.Parameters.AddWithValue("@telefon", telefon);
            insrt.Parameters.AddWithValue("@adres", adres);
            insrt.Parameters.AddWithValue("@email", email);
            
            bg.Baslat();

            if (insrt.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            bg.Bitir();
            insrt.Dispose();
        }
    }
}
      
  