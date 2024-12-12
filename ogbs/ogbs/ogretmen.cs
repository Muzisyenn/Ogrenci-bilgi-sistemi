using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogbs
{
    public partial class ogretmen : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MÜZISYENN;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True;Encrypt=False");

        public ogretmen()
        {
            InitializeComponent();
        }

        private void textogrenciid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdersid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdurumu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbasvuruid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT OgrenciID, DersID, Durum FROM Basvuru WHERE BasvuruID = @basvuruid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@basvuruid", textbasvuruid.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textogrenciid.Text = reader["OgrenciID"].ToString();
                    textdersid.Text = reader["DersID"].ToString();
                    textdurumu.Text = reader["Durum"].ToString();
                }
                else
                {
                    MessageBox.Show("Başvuru bulunamadı!");
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

        private void btnonayla_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Basvuru SET Durum = 'Onaylandı' WHERE BasvuruID = @basvuruid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@basvuruid", textbasvuruid.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Başvuru onaylandı!");
                    textdurumu.Text = "Onaylandı";
                }
                else
                {
                    MessageBox.Show("Başvuru onaylanamadı!");
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

        private void btnreddet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Basvuru SET Durum = 'Reddedildi' WHERE BasvuruID = @basvuruid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@basvuruid", textbasvuruid.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Başvuru reddedildi!");
                    textdurumu.Text = "Reddedildi";
                }
                else
                {
                    MessageBox.Show("Başvuru reddedilemedi!");
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

        private void basvurutablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ogretmen_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciBilgiSistemiDataSet.Basvuru' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.basvuruTableAdapter.Fill(this.ogrenciBilgiSistemiDataSet.Basvuru);

        }
    }
}
