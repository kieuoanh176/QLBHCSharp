using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBHCSharp
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
        private void frmlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{tab}");
                e.Handled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection("Data Source=SONTRINH-HP\\KTQDSERVER;Initial Catalog=QLBH;Integrated Security=True");
            string sql = "Select * from tblPass where UserName='" + txtusername.Text + 
                "' and Password='" + txtpass.Text  + "'";
           // SqlCommand cmd = new SqlCommand("Select * from tblPass where UserName=@username and Password=@password", conn);
            SqlCommand cmd = new SqlCommand(sql , conn);
            //cmd.Parameters.AddWithValue("@username", txtusername.Text );
            //cmd.Parameters.AddWithValue("@password", txtpass.Text );
            
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
               adapt.Fill(ds);
               conn.Close();
                int count = ds.Tables[0].Rows.Count;
                
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
        }
    }

