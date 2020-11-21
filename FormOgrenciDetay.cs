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

namespace notkayit
{
    public partial class FormOgrenciDetay : Form
    {
        public FormOgrenciDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0FUVJAO;Initial Catalog=DBnotkayit;Integrated Security=True");
        public String numara;
        //Data Source=DESKTOP-0FUVJAO;Initial Catalog=DBnotkayit;Integrated Security=True


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_ders WHERE OGRNUMARA = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                while (dr.Read())
                {
                    LblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                    LblSınav1.Text = dr[4].ToString();
                    LblSınav2.Text = dr[5].ToString();
                    LblSınav3.Text = dr[6].ToString();
                    LblOrtalama.Text = dr[7].ToString();
                    LblDurum.Text = dr[8].ToString();
                }
            }
            baglanti.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
