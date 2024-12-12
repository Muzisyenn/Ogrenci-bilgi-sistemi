using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogbs
{
    public partial class memur : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MÜZISYENN;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True;Encrypt=False");

        public memur()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textogrenciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textogrencisoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textgano_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnogrencikaydet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Ogrenci (Ad, Soyad, Gano) VALUES (@ad, @soyad, @gano)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", textogrenciadi.Text);
                cmd.Parameters.AddWithValue("@soyad", textogrencisoyadi.Text);
                cmd.Parameters.AddWithValue("@gano", textgano.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Öğrenci başarıyla eklendi!");
                }
                else
                {
                    MessageBox.Show("Öğrenci eklenemedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textdersadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textderskodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textderskredisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnderskaydet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Ders (DersAdi, DersKodu, Kredi, Kontenjan) VALUES (@dersAdi, @dersKodu, @kredi, @kontenjan)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dersAdi", textdersadi.Text);
                cmd.Parameters.AddWithValue("@dersKodu", textderskodu.Text);
                cmd.Parameters.AddWithValue("@kredi", textderskredisi.Text);
                cmd.Parameters.AddWithValue("@kontenjan", textkontenjan.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Ders başarıyla eklendi!");
                }
                else
                {
                    MessageBox.Show("Ders eklenemedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ogrencitablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void derstablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textkontenjan_TextChanged(object sender, EventArgs e)
        {

        }

        private void memur_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciBilgiSistemiDataSet.Ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTableAdapter.Fill(this.ogrenciBilgiSistemiDataSet.Ders);
            // TODO: Bu kod satırı 'ogrenciBilgiSistemiDataSet.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.ogrenciBilgiSistemiDataSet.Ogrenci);

        }
    }
}