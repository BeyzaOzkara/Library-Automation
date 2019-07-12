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
                        VerilisTarihi = dateVerilis.Value,
                        TeslimTarihi = dateTeslim.Value,
                        TeslimDurumu = checkBoxDurum.Checked
                    });
                }
                var message = success ? "done" : "failed";

                MessageBox.Show("Operation " + message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }

            try
            {
                using (var emanetBusiness = new EmanetBusiness())
                {
                    List<Emanet> emanet = emanetBusiness.Listele().OrderBy(x => x.BarkodNo).ToList();
                    dataGrid_Emanet.DataSource = emanet.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void txtUyeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txtBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txtUyeIDAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txtBarkodNoAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                bool success;
                using (var emanetBusiness = new EmanetBusiness())
                {
                    success = emanetBusiness.Sil(Convert.ToInt32(txtBarkodNo.Text));
                }
                var message = success ? "done" : "failed";


                try
                {
                    using (var emanetBusiness = new EmanetBusiness())
                    {
                        List<Emanet> emanet = emanetBusiness.Listele().OrderBy(x => x.EmanetID).ToList();
                        dataGrid_Emanet.DataSource = emanet.ToList();
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
            //int deleteID = Convert.ToInt32(gridControl1.GetFocusedRowCellValue("id"));
            //Emanet e = db.BorrowedBook.Where(x => x.id == deleteID).FirstOrDefault();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                using (var emanetBusiness = new EmanetBusiness())
                {
                    List<Emanet> emanet = emanetBusiness.Listele().OrderBy(x => x.BarkodNo).ToList();
                    dataGrid_Emanet.DataSource = emanet.ToList();
                    //dataGrid_Emanet.DataSource = emanet.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }
    }
}
