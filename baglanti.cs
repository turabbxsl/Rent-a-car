using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace MasinKirayesi
{
    class baglanti
    {
        public SqlConnection Baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=MasinKirayesi;Integrated Security=True");

      
        public void Baslat()
        {
            Baglanti.Open();
            if (Baglanti.State != System.Data.ConnectionState.Closed)
            {

            }
            else
            {
                MessageBox.Show("Baglanti Xetasi");
            }
        }
        public void Bitir()
        {
            try
            {
                Baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Baglanti Xetasi" + ex);
            }

        }
    }
}
