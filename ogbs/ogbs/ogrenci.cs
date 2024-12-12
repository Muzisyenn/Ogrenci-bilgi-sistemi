using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogbs
{
    public partial class ogrenci : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MÜZISYENN;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True;Encrypt=False");

        public ogrenci()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ogrenci_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciBilgiSistemiDataSet.Ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTableAdapter.Fill(this.ogrenciBilgiSistemiDataSet.Ders);

        }

        private void textdersid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textogrenciid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Ogrenci WHERE OgrenciID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", textogrenciid.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textad.Text = reader["Ad"].ToString();
                    textsoyad.Text = reader["Soyad"].ToString();
                    textgano.Text = reader["Gano"].ToString();
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı!");
                }
                reader.Close();
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

        private void btndersibul_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Ders WHERE DersID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", textdersid.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textdersadı.Text = reader["DersAdi"].ToString();
                    textderskodu.Text = reader["DersKodu"].ToString();
                    textderskredisi.Text = reader["Kredi"].ToString();
                    textderskontenjanı.Text = reader["Kontenjan"].ToString();
                }
                else
                {
                    MessageBox.Show("Ders bulunamadı!");
                }
                reader.Close();
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

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Basvuru (OgrenciID, DersID, Durum, IstekTuru) VALUES (@ogrenciID, @dersID, 'Beklemede', 'Kayıt')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ogrenciID", textogrenciid.Text);
                cmd.Parameters.AddWithValue("@dersID", textdersid.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Başvuru başarıyla eklendi!");
                }
                else
                {
                    MessageBox.Show("Başvuru eklenemedi!");
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

        private void btnsil_Click(object sender, EventArgs e)
        {

        }

        private void textgano_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogrencitablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
