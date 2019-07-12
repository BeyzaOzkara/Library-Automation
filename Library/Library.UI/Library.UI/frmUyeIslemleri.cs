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
using System.ComponentModel.DataAnnotations;

namespace Library.UI
{
    public partial class frmUyeIslemleri : Form
    {
        public frmUyeIslemleri()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUyeIsim.Text) || string.IsNullOrEmpty(txtUyeSoyisim.Text))
            {
                throw new ValidationException("Kullanıcı Adı veya Şifre Boş Geçilemez !");
            }
            else
            {
                try
                {
                    bool success;
                    using (var uyeBusiness = new UyeBusiness())
                    {
                        success = uyeBusiness.Ekle(new Uye()
                        {
                            Isim = txtUyeIsim.Text,
                            Soyisim = txtUyeSoyisim.Text,
                            TcNo = Convert.ToInt64(txtUyeTcNo.Text)
                        });
                    }
                    var message = success ? "done" : "failed";


                    try
                    {
                        using (var uyeBusiness = new UyeBusiness())
                        {
                            List<Uye> customers = uyeBusiness.Listele().OrderBy(x => x.UyeID).ToList();
                            dataGrid_TumUye.DataSource = customers.ToList();
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
            try
            {
                bool success;
                using (var uyeBusiness = new UyeBusiness())
                {
                    success = uyeBusiness.Ekle(new Uye()
                    {
                        Isim = txtUyeIsim.Text,
                        Soyisim = txtUyeSoyisim.Text,
                        TcNo = Convert.ToInt64(txtUyeTcNo.Text)
                    });
                }
                var message = success ? "done" : "failed";

                
                try
                {
                    using (var uyeBusiness = new UyeBusiness())
                    {
                        List<Uye> customers = uyeBusiness.Listele().OrderBy(x => x.UyeID).ToList();
                        dataGrid_TumUye.DataSource = customers.ToList();
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
                using (var uyeBusiness = new UyeBusiness())
                {
                    List<Uye> customers = uyeBusiness.Listele().OrderBy(x => x.UyeID).ToList();
                    dataGrid_TumUye.DataSource = customers.ToList();
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
            string kayit = "SELECT * FROM Uyes WHERE TcNo=@TcNo";
            SqlCommand com = new SqlCommand(kayit, con);
            com.Parameters.AddWithValue("@TcNo", Convert.ToInt64(txtTC.Text));

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid_TumUye.DataSource = dt;
            con.Close();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                bool success;
                using (var uyeBusiness = new UyeBusiness())
                {
                    success = uyeBusiness.Sil(Convert.ToInt32(txtUyeID.Text));
                }
                var message = success ? "done" : "failed";
                

                try
                {
                    using (var uyeBusiness = new UyeBusiness())
                    {
                        List<Uye> customers = uyeBusiness.Listele().OrderBy(x => x.UyeID).ToList();
                        dataGrid_TumUye.DataSource = customers.ToList();
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

        private void txtUyeIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceHarf(sender, e);
        }

        private void txtUyeSoyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceHarf(sender, e);
        }

        private void txtUyeTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txtUyeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }
    }
}
