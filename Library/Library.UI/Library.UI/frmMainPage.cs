using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UI
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void btnKitapİslemleri_Click(object sender, EventArgs e)
        {
            frmKitapIslemleri ki = new frmKitapIslemleri();
            ki.Show();
        }

        private void btnUyeIslemleri_Click(object sender, EventArgs e)
        {
            frmUyeIslemleri ui = new frmUyeIslemleri();
            ui.Show();
        }

        private void btnEmanetİslemleri_Click(object sender, EventArgs e)
        {
            frmEmanetIslemleri ei = new frmEmanetIslemleri();
            ei.Show();
        }
    }
}
