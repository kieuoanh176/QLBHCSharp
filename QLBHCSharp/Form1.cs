using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHCSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form truc = new frmlogin();
            truc.ShowDialog();
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f = new frmDMHH();
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
