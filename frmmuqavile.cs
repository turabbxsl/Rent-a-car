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
    public partial class frmmuqavile : Form
    {
        public frmmuqavile()
        {
            InitializeComponent();
        }
        baglanti bg = new baglanti();

        private void frmmuqavile_Load(object sender, EventArgs e)
        {
            Bos_masinlar();
            Liste();

        }

        private void Bos_masinlar()
        {
            string sorgu = "select * from Masin where veziyyet = 'Bos'";
            BosMasinlar(combomasinlar, sorgu);
        }

        public void BosMasinlar(ComboBox combo,string sorgu)
        {
            bg.Baslat();
            SqlCommand cmd = new SqlCommand(sorgu,bg.Baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["Nomre"].ToString());
            }
            bg.Bitir();
        }
        //public void AzeNoAxtar(TextBox azeaxtar,TextBox azeno,TextBox adsoyad,TextBox telefon, string sorgu)
        //{
        //    bg.Baslat();
        //    SqlCommand cmd = new SqlCommand(sorgu, bg.Baglanti);
        //    SqlDataReader read = cmd.ExecuteReader();
        //    while (read.Read())
        //    {
               
        //        adsoyad.Text = read["adsoyad"].ToString();
        //        telefon.Text = read["telefon"].ToString();
        //    }
        //    bg.Bitir();
        //}
        public void AzeNo(TextBox azeno, TextBox adsoyad, TextBox telefon, string sorgu)
        {
            bg.Baslat();
            SqlCommand cmd = new SqlCommand(sorgu, bg.Baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {               
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            bg.Bitir();
        }
        public void Combodangetir(ComboBox masinlar,TextBox marka, TextBox seria, TextBox il,TextBox reng, string sorgu)
        {
            bg.Baslat();
            SqlCommand cmd = new SqlCommand(sorgu, bg.Baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["Model"].ToString();
                seria.Text = read["Seri"].ToString();
                il.Text = read["il"].ToString();
                reng.Text = read["reng"].ToString();
               
            }
            bg.Bitir();
        }
        public void Odenis_Hesabla(ComboBox combokirayesekili,TextBox Odenis,string sorgu)
        {
            bg.Baslat();
            SqlCommand cmd = new SqlCommand(sorgu, bg.Baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (combokirayesekili.SelectedIndex == 0)
                {
                    Odenis.Text = (int.Parse(read["odenis"].ToString()) * 1).ToString();
                }
                if (combokirayesekili.SelectedIndex == 1)
                {
                    Odenis.Text = (int.Parse(read["odenis"].ToString()) * 0.80).ToString();
                }
                if (combokirayesekili.SelectedIndex == 2)
                {
                    Odenis.Text = (int.Parse(read["odenis"].ToString()) * 0.70).ToString();
                }

            }
            bg.Bitir();
        }

        private void txtazeno_TextChanged(object sender, EventArgs e)
        {
            if (txtazeno.Text == "") foreach (Control item in groupbox1.Controls) if (item is TextBox) item.Text = "";

            string sorgu = "select * from Musteri where AzeNo like '" + txtazeno.Text + "'";
            AzeNo(txtazeno,txtadsoyad,txttelefon,sorgu);
        }

        private void combomasinlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from Masin where Nomre like '" + combomasinlar.SelectedItem + "'";
            Combodangetir(combomasinlar,txtmarka,txtseria,txtil,txtreng,sorgu);
        }

        private void KirayeSekili_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from Masin where Nomre like '" + combomasinlar.SelectedItem + "'";
            Odenis_Hesabla(comboKirayeSekili,txtkirayeodenisi,sorgu);
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dategiris.Text) - DateTime.Parse(datecixis.Text);
            int gun2 = gun.Days;
            txtgun.Text = gun2.ToString();
            txttutar.Text = (gun2 * int.Parse(txtkirayeodenisi.Text)).ToString();
            
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            datecixis.Text = DateTime.Now.ToShortDateString();
            dategiris.Text = DateTime.Now.ToShortDateString();
            comboKirayeSekili.Text = "";
            combomasinlar.Text = "";
            txtkirayeodenisi.Text = "";
            txtgun.Text = "";
            txttutar.Text = "";
            foreach (Control item in groupbox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupbox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }
        void Liste()
        {
            SqlDataAdapter dp = new SqlDataAdapter("select * from muqavile", bg.Baglanti);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnelaveet_Click(object sender, EventArgs e)
        {
            //if (txtadsoyad.TextLength == 0 || txtazeno.TextLength == 0 || txttelefon.TextLength == 0 || txtSV_No.TextLength == 0 || txtSV_tarixi.TextLength == 0 || txtSV_yer.TextLength == 0 || combomasinlar.SelectedIndex < 0 || combomasinlar.SelectedIndex > 2 || txtmarka.TextLength == 0 || txtseria.TextLength == 0 || txtil.TextLength == 0 || txtreng.TextLength == 0 || comboKirayeSekili.SelectedIndex < 0 || comboKirayeSekili.SelectedIndex > 3 || txtgun.TextLength == 0 || txttutar.TextLength == 0 || txtkirayeodenisi.TextLength == 0 || datecixis.Text == "" ||
            //    dategiris.Text == "")
            //{
            //    MessageBox.Show("Xahis Edirik Bos Yerleri Doldurun!", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    if (add(txtazeno.Text,txtazeno.Text, txttelefon.Text, txtSV_No.Text, txtSV_tarixi.Text, txtSV_yer.Text, combomasinlar.Text, txtmarka.Text, txtseria.Text, txtil.Text, txtreng.Text, comboKirayeSekili.Text, int.Parse(txtkirayeodenisi.Text),int.Parse(txtgun.Text),int.Parse(txttutar.Text),datecixis.Text,dategiris.Text))
            //    {
            //        MessageBox.Show("Muqavile Elave Olundu.","Melumat",MessageBoxButtons.OK,MessageBoxIcon.Information);


            //    }
            //}     
            bg.Baslat();
            SqlCommand cmd = new SqlCommand("insert into muqavile(azeno,adsoyad,telefon,s_no,s_tarix,s_yer,m_nomresi,marka,seria,il,reng,kirayesekili,kirayeodenisi,gun,tutar,cixistarixi,geridonustarixi) values (@azeno,@adsoyad,@telefon,@s_no,@s_tarix,@s_yer,@m_nomresi,@marka,@seria,@il,@reng,@kirayesekili,@kirayeodenisi,@gun,@tutar,@cixistarixi,@geridonustarixi)", bg.Baglanti);
            cmd.Parameters.AddWithValue("@azeno", txtazeno.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txttelefon.Text);
            cmd.Parameters.AddWithValue("@s_no", txtSV_No.Text);
            cmd.Parameters.AddWithValue("@s_tarix", txtSV_tarixi.Text);
            cmd.Parameters.AddWithValue("@s_yer", txtSV_yer.Text);
            cmd.Parameters.AddWithValue("@m_nomresi", combomasinlar.Text);
            cmd.Parameters.AddWithValue("@marka", txtmarka.Text);
            cmd.Parameters.AddWithValue("@seria", txtseria.Text);
            cmd.Parameters.AddWithValue("@il", txtil.Text);
            cmd.Parameters.AddWithValue("@reng", txtreng.Text);
            cmd.Parameters.AddWithValue("@kirayesekili", comboKirayeSekili.Text);
            cmd.Parameters.AddWithValue("@kirayeodenisi", int.Parse(txtkirayeodenisi.Text));
            cmd.Parameters.AddWithValue("@gun", int.Parse(txtgun.Text));
            cmd.Parameters.AddWithValue("@tutar", int.Parse(txttutar.Text));
            cmd.Parameters.AddWithValue("@cixistarixi", datecixis.Text);
            cmd.Parameters.AddWithValue("@geridonustarixi", dategiris.Text);
            cmd.ExecuteNonQuery();          
            MessageBox.Show("Muqavile Elave Olundu");
            temizle();
         
            Liste();


        }
        public bool add(string azeno, string adsoyad, string telefon,string s_no,string s_tarixi,string s_yer,string nomrecombo,string marka,string seria,string il,string reng,string sekilcombo,int odenis,int gun,int tutar,string cixis,string giris)
        {
            string sorgu = "insert into muqavile(azeno,adsoyad,telefon,s_no,s_tarix,s_yer,m_nomresi,marka,seria,il,reng,kirayesekili,kirayeodenisi,gun,tutar,cixistarixi,geridonustarixi) values (@azeno,@adsoyad,@telefon,@s_no,@s_tarix,@s_yer,@m_nomresi,@marka,@seria,@il,@reng,@kirayesekili,@kirayeodenisi,@gun,@tutar,@cixistarixi,@geridonustarixi)";
            SqlCommand cmd = new SqlCommand(sorgu, bg.Baglanti);
            cmd.Parameters.AddWithValue("@azeno", txtazeno.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txttelefon.Text);
            cmd.Parameters.AddWithValue("@s_no", txtSV_No.Text);
            cmd.Parameters.AddWithValue("@s_tarix", txtSV_tarixi.Text);
            cmd.Parameters.AddWithValue("@s_yer", txtSV_yer.Text);
            cmd.Parameters.AddWithValue("@m_nomresi", combomasinlar.Text);
            cmd.Parameters.AddWithValue("@marka", txtmarka.Text);
            cmd.Parameters.AddWithValue("@seria", txtseria.Text);
            cmd.Parameters.AddWithValue("@il", txtil.Text);
            cmd.Parameters.AddWithValue("@reng", txtreng.Text);
            cmd.Parameters.AddWithValue("@kirayesekili", comboKirayeSekili.Text);
            cmd.Parameters.AddWithValue("@kirayeodenisi", int.Parse(txtkirayeodenisi.Text));
            cmd.Parameters.AddWithValue("@gun", int.Parse(txtgun.Text));
            cmd.Parameters.AddWithValue("@tutar", int.Parse(txttutar.Text));
            cmd.Parameters.AddWithValue("@cixistarixi", datecixis.Text);
            cmd.Parameters.AddWithValue("@geridonustarixi", dategiris.Text);

            bg.Baslat();

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            bg.Bitir();
            cmd.Dispose();
        }
        public bool guncelle(string azeno, string adsoyad, string telefon, string s_no, string s_tarixi, string s_yer, string nomrecombo, string marka, string seria, string il, string reng, string sekilcombo, int odenis, int gun, int tutar, string cixis, string giris)
        {
            string sorgu = "update muqavile set azeno = @azeno,adsoyad = @adsoyad,telefon = @telefon,s_no = @s_no,s_tarix = @s_tarix,s_yer = @s_yer,marka = @marka,seria = @seria,il = @il,reng = @reng,kirayesekili = @kirayesekili,kirayeodenisi = @kirayeodenisi,gun = @gun,tutar = @tutar,cixistarixi = @cixistarixi,geridonustarixi = @geridonustarixi where m_nomresi = @m_nomresi ";
            SqlCommand cmd = new SqlCommand(sorgu, bg.Baglanti);
            cmd.Parameters.AddWithValue("@azeno", txtazeno.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txttelefon.Text);
            cmd.Parameters.AddWithValue("@s_no", txtSV_No.Text);
            cmd.Parameters.AddWithValue("@s_tarix", txtSV_tarixi.Text);
            cmd.Parameters.AddWithValue("@s_yer", txtSV_yer.Text);
            cmd.Parameters.AddWithValue("@m_nomresi", combomasinlar.Text);
            cmd.Parameters.AddWithValue("@marka", txtmarka.Text);
            cmd.Parameters.AddWithValue("@seria", txtseria.Text);
            cmd.Parameters.AddWithValue("@il", txtil.Text);
            cmd.Parameters.AddWithValue("@reng", txtreng.Text);
            cmd.Parameters.AddWithValue("@kirayesekili", comboKirayeSekili.Text);
            cmd.Parameters.AddWithValue("@kirayeodenisi", int.Parse(txtkirayeodenisi.Text));
            cmd.Parameters.AddWithValue("@gun", int.Parse(txtgun.Text));
            cmd.Parameters.AddWithValue("@tutar", int.Parse(txttutar.Text));
            cmd.Parameters.AddWithValue("@cixistarixi", datecixis.Text);
            cmd.Parameters.AddWithValue("@geridonustarixi", dategiris.Text);

            bg.Baslat();

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            bg.Bitir();
            cmd.Dispose();
        }

       

        private void btnyenile_Click(object sender, EventArgs e)
        {
            //if (txtadsoyad.TextLength == 0 || txtazeno.TextLength == 0 || txttelefon.TextLength == 0 || txtSV_No.TextLength == 0 || txtSV_tarixi.TextLength == 0 || txtSV_yer.TextLength == 0 || combomasinlar.SelectedIndex < 0 || combomasinlar.SelectedIndex > 2 || txtmarka.TextLength == 0 || txtseria.TextLength == 0 || txtil.TextLength == 0 || txtreng.TextLength == 0 || comboKirayeSekili.SelectedIndex < 0 || comboKirayeSekili.SelectedIndex > 3 || txtgun.TextLength == 0 || txttutar.TextLength == 0 || txtkirayeodenisi.TextLength == 0 || datecixis.Text == "" ||
            //     dategiris.Text == "")
            //{
            //    MessageBox.Show("Xahis Edirik Bos Yerleri Doldurun!", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    if (guncelle(txtazeno.Text, txtazeno.Text, txttelefon.Text, txtSV_No.Text, txtSV_tarixi.Text, txtSV_yer.Text, combomasinlar.Text, txtmarka.Text, txtseria.Text, txtil.Text, txtreng.Text, comboKirayeSekili.Text, int.Parse(txtkirayeodenisi.Text), int.Parse(txtgun.Text), int.Parse(txttutar.Text), datecixis.Text, dategiris.Text))
            //    {
            //        MessageBox.Show("Muqavile Guncellendi");

            //        Liste(); 
            //    }
            //}
            bg.Baslat();
            SqlCommand cmd = new SqlCommand("update muqavile set azeno = @azeno,adsoyad = @adsoyad,telefon = @telefon,s_no = @s_no,s_tarix = @s_tarix,s_yer = @s_yer,marka = @marka,seria = @seria,il = @il,reng = @reng,kirayesekili = @kirayesekili,kirayeodenisi = @kirayeodenisi,gun = @gun,tutar = @tutar,cixistarixi = @cixistarixi,geridonustarixi = @geridonustarixi where m_nomresi = @m_nomresi ",bg.Baglanti);

            cmd.Parameters.AddWithValue("@azeno", txtazeno.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txttelefon.Text);
            cmd.Parameters.AddWithValue("@s_no", txtSV_No.Text);
            cmd.Parameters.AddWithValue("@s_tarix", txtSV_tarixi.Text);
            cmd.Parameters.AddWithValue("@s_yer", txtSV_yer.Text);
            cmd.Parameters.AddWithValue("@m_nomresi", combomasinlar.Text);
            cmd.Parameters.AddWithValue("@marka", txtmarka.Text);
            cmd.Parameters.AddWithValue("@seria", txtseria.Text);
            cmd.Parameters.AddWithValue("@il", txtil.Text);
            cmd.Parameters.AddWithValue("@reng", txtreng.Text);
            cmd.Parameters.AddWithValue("@kirayesekili", comboKirayeSekili.Text);
            cmd.Parameters.AddWithValue("@kirayeodenisi", int.Parse(txtkirayeodenisi.Text));
            cmd.Parameters.AddWithValue("@gun", int.Parse(txtgun.Text));
            cmd.Parameters.AddWithValue("@tutar", int.Parse(txttutar.Text));
            cmd.Parameters.AddWithValue("@cixistarixi", datecixis.Text);
            cmd.Parameters.AddWithValue("@geridonustarixi", dategiris.Text);
            cmd.ExecuteNonQuery();
            bg.Bitir();
            MessageBox.Show("Guncelleme Heyata Kecirildi");
            Liste();
 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow setir = dataGridView1.CurrentRow;
            txtazeno.Text = setir.Cells[0].Value.ToString();
            txtadsoyad.Text = setir.Cells[1].Value.ToString();
            txttelefon.Text = setir.Cells[2].Value.ToString();
            txtSV_No.Text = setir.Cells[3].Value.ToString();
            txtSV_tarixi.Text = setir.Cells[4].Value.ToString();
            txtSV_yer.Text = setir.Cells[5].Value.ToString();
            combomasinlar.Text = setir.Cells[6].Value.ToString();
            txtmarka.Text = setir.Cells[7].Value.ToString();
            txtseria.Text = setir.Cells[8].Value.ToString();
            txtil.Text = setir.Cells[9].Value.ToString();
            txtreng.Text = setir.Cells[10].Value.ToString();
            comboKirayeSekili.Text = setir.Cells[11].Value.ToString();
            txtkirayeodenisi.Text = setir.Cells[12].Value.ToString();
            txtgun.Text = setir.Cells[13].Value.ToString();
            txttutar.Text = setir.Cells[14].Value.ToString();
            datecixis.Text = setir.Cells[15].Value.ToString();
            dategiris.Text = setir.Cells[16].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow setir = dataGridView1.CurrentRow;
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(setir.Cells["geridonustarixi"].Value.ToString());

            int odenis = int.Parse(setir.Cells["kirayeodenisi"].Value.ToString());
            TimeSpan gunferqi = bugun - donus;
            int _gunferqi = gunferqi.Days;
            int odenisferqi;
            odenisferqi = _gunferqi * odenis;
            txtelaveodenis.Text = odenisferqi.ToString();
            string t = txtelaveodenis.Text.Substring(1,txtelaveodenis.Text.Length - 1);
            txtelaveodenis.Text = t;
            
            
        }

        private void btnmasinkirayever_Click(object sender, EventArgs e)
        {
            if (txtelaveodenis.Text != "")
            {
                DataGridViewRow setir = dataGridView1.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());

                int odenis = int.Parse(setir.Cells["kirayeodenisi"].Value.ToString());
                int tutar = int.Parse(setir.Cells["tutar"].Value.ToString());

                DateTime cixis = DateTime.Parse(setir.Cells["cixistarixi"].Value.ToString());
                TimeSpan gun = bugun - cixis;

                int _gun = gun.Days;
                int toplamtutar = _gun * odenis;

            
                string sorgu = "delete from muqavile where m_nomresi = '" + setir.Cells["m_nomresi"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand();
                metod(cmd,sorgu);
               

                //bg.Baslat();
                //string sorgu2 = "update Masin set veziyyet = 'Bos' where m_nomresi = '" + setir.Cells["m_nomresi"].Value.ToString() + "'";
                //SqlCommand cmd2 = new SqlCommand();
               

                string sorgu3 = "insert into satis(aze,adisoyadi,satis_nomre,satis_marka,satis_seria,satis_il,satis_reng,satis_gun,satis_qiymet,satis_tutar,tarix1,tarix2) values (@aze,@adisoyadi,@satis_nomre,@satis_marka,@satis_seria,@satis_il,@satis_reng,@satis_gun,@satis_qiymet,@satis_tutar,@tarix1,@tarix2)";
                SqlCommand cmd3 = new SqlCommand(sorgu3, bg.Baglanti);
                cmd3.Parameters.AddWithValue("@aze", setir.Cells["azeno"].Value.ToString());
                cmd3.Parameters.AddWithValue("@adisoyadi", setir.Cells["adsoyad"].Value.ToString());
                cmd3.Parameters.AddWithValue("@satis_nomre", setir.Cells["m_nomresi"].Value.ToString());
                cmd3.Parameters.AddWithValue("@satis_marka", setir.Cells["marka"].Value.ToString());
                cmd3.Parameters.AddWithValue("@satis_seria", setir.Cells["seria"].Value.ToString());
                cmd3.Parameters.AddWithValue("@satis_il", setir.Cells["il"].Value.ToString());
                cmd3.Parameters.AddWithValue("@satis_reng", setir.Cells["reng"].Value.ToString());
                cmd3.Parameters.AddWithValue("@satis_gun", _gun);
                cmd3.Parameters.AddWithValue("@satis_qiymet",odenis );
                cmd3.Parameters.AddWithValue("@satis_tutar",toplamtutar );
                cmd3.Parameters.AddWithValue("@tarix1",setir.Cells["cixistarixi"].Value.ToString());
                cmd3.Parameters.AddWithValue("@tarix2", DateTime.Now.ToShortDateString());
                metod(cmd3, sorgu3);

                
                MessageBox.Show("Masin Kirayeye Verildi");
                        
                combomasinlar.Items.Clear();
                combomasinlar.Text = "";
                Bos_masinlar();
                temizle();
                foreach (Control item in groupbox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in groupbox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                combomasinlar.Text = "";
                txtelaveodenis.Text = "";

            }
            else if(txtelaveodenis.Text == "")
            {
                MessageBox.Show("Xahis Edirik,Secme Edin");
            }

        }
        
        public void metod(SqlCommand komut,string sorgu)
        {
            bg.Baslat();
            komut.Connection = bg.Baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            bg.Bitir();
        }

        private void txtelaveodenis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
