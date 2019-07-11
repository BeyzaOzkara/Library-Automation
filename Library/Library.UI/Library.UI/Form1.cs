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
using System.Security.Authentication;

namespace Library.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtKullaniciAdi.Text;
            string pass = txtSifre.Text;
            con = new SqlConnection("server=LAPTOP-8MFVGEHG\\SQLEXPRESS; Initial Catalog=Library; Integrated Security= SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Yoneticis where KullaniciAdi='" + txtKullaniciAdi.Text + "' AND Sifre='" + txtSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(Convert.ToString(txtKullaniciAdi.Text)) && string.IsNullOrEmpty(txtSifre.Text))
            {
                throw new AuthenticationException("Kullanici Verileri Boş Geçilemez !");
            }
            else if (dr.Read())
            {
                MessageBox.Show("Welcome");
                frmMainPage mp = new frmMainPage();
                mp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlis Bilgi Girdiniz!");
            }
            con.Close();
        }
    }
}
