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
    public partial class FormOgretmenDetay : Form
    {
        public FormOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0FUVJAO;Initial Catalog=DBnotkayit;Integrated Security=True");

       
        private void FormOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBnotkayitDataSet.tbl_ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_dersTableAdapter.Fill(this.dBnotkayitDataSet.tbl_ders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_ders (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", mskNumara.Text);
            komut.Parameters.AddWithValue("@P2", txtAd.Text);
            komut.Parameters.AddWithValue("@P3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tbl_dersTableAdapter.Fill(this.dBnotkayitDataSet.tbl_ders);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            sinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            sinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            sinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();


        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            String durum;

            s1 = Convert.ToDouble(sinav1.Text);
            s2 = Convert.ToDouble(sinav2.Text); 
            s3 = Convert.ToDouble(sinav3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString();
            if(ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_ders set OGRS1 = @P1, OGRS2 = @P2, OGRS3 = @P3, ORTALAMA =@P4,DURUM= @P5 WHERE OGRNUMARA = @P6", baglanti);
            komut.Parameters.AddWithValue("@P1", sinav1.Text);
            komut.Parameters.AddWithValue("@P2", sinav2.Text);
            komut.Parameters.AddWithValue("@P3", sinav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Güncellendi");
            this.tbl_dersTableAdapter.Fill(this.dBnotkayitDataSet.tbl_ders);


        }
    }
}
