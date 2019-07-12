using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.DAL.Repositories.Concretes;
using Library.BLL;
using System.Data.SqlClient;

namespace Library.UI
{
    public partial class frmKitapIslemleri : Form
    {
        public frmKitapIslemleri()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                bool success;
                using (var kitapBusiness = new KitapBusiness())
                {
                    success = kitapBusiness.Ekle(new Kitap()
                    {
                        KitapAdi = txtKitapAdi.Text,
                        Yazar = txtYazar.Text,
                        Yayinevi = txtYayinevi.Text,
                        SayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text),
                        BasimYili = Convert.ToInt32(txtBasimYili.Text)
                    });
                }
                var message = success ? "done" : "failed";

                try
                {
                    using (var kitapBusiness = new KitapBusiness())
                    {
                        List<Kitap> kitap = kitapBusiness.Listele().OrderBy(x => x.BarkodNo).ToList();
                        dataGridKitap.DataSource = kitap.ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error happened: " + ex.Message);
                }
                MessageBox.Show("Operation " + message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                using (var kitapBusiness = new KitapBusiness())
                {
                    List<Kitap> customers = kitapBusiness.Listele().OrderBy(x => x.BarkodNo).ToList();
                    dataGridKitap.DataSource = customers.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        static string conString = "server=LAPTOP-8MFVGEHG\\SQLEXPRESS; Initial Catalog=Library; Integrated Security= SSPI";
        SqlConnection con = new SqlConnection(conString);
        private void btnArama_Click(object sender, EventArgs e)
        {
            con.Open();
            string kayit = "SELECT * FROM Kitaps WHERE KitapAdi=@KitapAdi";
            SqlCommand com = new SqlCommand(kayit, con);
            com.Parameters.AddWithValue("@KitapAdi", txtKitap.Text);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridKitap.DataSource = dt;
            con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                bool success;
                using (var kitapBusiness = new KitapBusiness())
                {
                    success = kitapBusiness.Sil(Convert.ToInt32(txtBarkodNo.Text));
                }
                var message = success ? "done" : "failed";


                try
                {
                    using (var kitapBusiness = new KitapBusiness())
                    {
                        List<Kitap> kitap = kitapBusiness.Listele().OrderBy(x => x.BarkodNo).ToList();
                        dataGridKitap.DataSource = kitap.ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error happened: " + ex.Message);
                }
                MessageBox.Show("Operation " + message);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void txtSayfaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txtBasimYili_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txtBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }
    }
}
