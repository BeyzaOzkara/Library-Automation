using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BLL;
using Library.Models;

namespace Library.UI
{
    public partial class frmEmanetIslemleri : Form
    {
        public frmEmanetIslemleri()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bool success;
                using (var emanetBusiness = new EmanetBusiness())
                {
                    success = emanetBusiness.Ekle(new Emanet()
                    {
                        UyeID = Convert.ToInt16(txtUyeID.Text),
                        BarkodNo = Convert.ToInt16(txtBarkodNo.Text),
                        VerilisTarihi = ,
                        TeslimTarihi = Convert.ToInt32(txtSayfaSayisi.Text),
                        TeslimDurumu = Convert.ToInt32(txtBasimYili.Text)
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
    }
}
