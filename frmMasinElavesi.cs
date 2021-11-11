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
    public partial class frmMasinElavesi : Form
    {
        public frmMasinElavesi()
        {
            InitializeComponent();
        }
        baglanti bg = new baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnsekil_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                yanacagcmb.Items.Clear();
                if (markacmb.SelectedIndex == 0)
                {
                    yanacagcmb.Items.Add("Benzin");
                    yanacagcmb.Items.Add("Dizel");
                    seriacmb.Items.Add("C200");
                    seriacmb.Items.Add("C240");
                    seriacmb.Items.Add("E250");
                    seriacmb.Items.Add("E300");
                    seriacmb.Items.Add("Panorama");
                    seriacmb.Items.Add("ML500");
                    seriacmb.Items.Add("ML280");
                    seriacmb.Items.Add("ES-Sport");
                    seriacmb.Items.Add("A-Series");                   
                }
                else if(markacmb.SelectedIndex == 1)
                {
                    yanacagcmb.Items.Add("Benzin");
                    yanacagcmb.Items.Add("Dizel");
                    seriacmb.Items.Add("E39");
                    seriacmb.Items.Add("E60");
                    seriacmb.Items.Add("ES-Sport");
                }
                else if (markacmb.SelectedIndex == 2)
                {
                    yanacagcmb.Items.Add("Benzin");
                    yanacagcmb.Items.Add("Dizel");
                    seriacmb.Items.Add("Sunny");
                    seriacmb.Items.Add("GT-R");
                    seriacmb.Items.Add("Maximus");
                }
                else if (markacmb.SelectedIndex == 3)
                {
                    yanacagcmb.Items.Add("Benzin");
                    yanacagcmb.Items.Add("Dizel");
                    seriacmb.Items.Add("Prado");
                    seriacmb.Items.Add("Corolla");
                    seriacmb.Items.Add("Cri");
                }
                else if (markacmb.SelectedIndex == 8)
                {
                    yanacagcmb.Items.Add("Benzin");
                    yanacagcmb.Items.Add("Dizel");
                    seriacmb.Items.Add("Astra");
                    seriacmb.Items.Add("Vectra");
                    seriacmb.Items.Add("Corsa");
                }
                else if (markacmb.SelectedIndex == 5)
                {
                    yanacagcmb.Items.Add("Benzin");
                    yanacagcmb.Items.Add("Dizel");
                    seriacmb.Items.Add("Focus");
                    seriacmb.Items.Add("Fiesta");                  
                }
           
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {

            if (addcar(nomretxt.Text,markacmb.Text,seriacmb.Text,Iltxt.Text,rengtxt.Text,KMtxt.Text,yanacagcmb.Text,Convert.ToInt32(odenistxt.Text)))
            {
                MessageBox.Show("Masin Qeydiyyata Alindi");
                
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
        }
        public bool addcar(string nomre,string marka,string seria,string il,string rengi,string Km,string yanacag,int odenis)
        {
            SqlCommand insert = new SqlCommand("insert into Masin(Nomre,Model,Seri,il,reng,km,yanacag,odenis,sekil,tarix,veziyyet) values (@NOMRE,@MODEL,@SERI,@IL,@RENG,@KM,@YANACAG,@ODENIS,@SEKIL,@tarix,@veziyyet) ",bg.Baglanti);
            insert.Parameters.AddWithValue("@NOMRE",nomretxt.Text);
            insert.Parameters.AddWithValue("@MODEL", markacmb.Text);
            insert.Parameters.AddWithValue("@SERI", seriacmb.Text);
            insert.Parameters.AddWithValue("@IL", Iltxt.Text);
            insert.Parameters.AddWithValue("@RENG", rengtxt.Text);
            insert.Parameters.AddWithValue("@KM", KMtxt.Text);
            insert.Parameters.AddWithValue("@YANACAG", yanacagcmb.Text);
            insert.Parameters.AddWithValue("@ODENIS", int.Parse(odenistxt.Text));
            insert.Parameters.AddWithValue("@SEKIL", pictureBox1.ImageLocation);
            insert.Parameters.AddWithValue("@tarix", DateTime.Now.ToString());
            insert.Parameters.AddWithValue("@veziyyet",comboBox1.Text);




            bg.Baslat();

            if (insert.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            bg.Bitir();
            insert.Dispose();


        }

        private void frmMasinElavesi_Load(object sender, EventArgs e)
        {

        }
    }
}
