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
using CrystalDecisions.CrystalReports.Engine;


namespace QLBHCSharp
{
   
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        Boolean addnewFlag = false;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=SONTRINH-HP\\KTQDSERVER;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * From tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
            //conn.Close();
        }

        public void NapLai()
        {
            
            //constr = "Data Source=(local);Initial Catalog=BanHang;Integrated Security=True";
            //conn.ConnectionString = constr;
            //conn.Open();
            sql = "Select * From tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
            
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
            int j = Convert.ToInt16(grdData.RowCount.ToString());
            MessageBox.Show(grdData.Rows[i].Cells["SanXuat"].Value.ToString());
        }

       

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.ClearSelection();

            grdData.Rows[0].Selected = true;

        }

        private void btnprv_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
            grdData.CurrentCell = grdData[i - 1, 1];
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dt.Clear();
            sql = "Select * From tblDMHH where " + comTruong.Text + "='" + comGT.Text  + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string mahang;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
                mahang = grdData.Rows[i].Cells[1].Value.ToString();
                sql = "Delete from tblDMHH where maHH='" + mahang + "'";
                //cmd = new SqlCommand(sql,conn);
                //cmd.CommandText = sql;
                //cmd.ExecuteNonQuery();
                clsMain.DoSQL(sql);
                dt.Clear();
                sql = "Select * From tblDMHH";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                grdData.DataSource = dt;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string tManhom, tTenHH, TDonGia, tSanXuat, tMaHang,tdvt;
            //int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
            int i, n;
            if (addnewFlag == false)
            {
                n = Convert.ToInt16(grdData.RowCount.ToString());
                for (i = 0; i < n - 1; i++)
                {
                    tManhom = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
                    tTenHH = grdData.Rows[i].Cells["TenHH"].Value.ToString();
                    TDonGia = grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
                    tSanXuat = grdData.Rows[i].Cells["SanXuat"].Value.ToString();
                    tMaHang = grdData.Rows[i].Cells["MaHH"].Value.ToString();
                    sql = "Update tblDMHH set MaNhom='" + tManhom + "',TenHH=N'" + tTenHH + "',Dgvnd='" + TDonGia
                           + "',SanXuat=N'" + tSanXuat + "' where Mahh='" + tMaHang + "'";
                    clsMain.DoSQL(sql);
                }

                MessageBox.Show("Đã cập nhật thành công!");
            }
            else
            {
                tManhom = txtMaNhom.Text;
                tTenHH = txtTenHang.Text;
                TDonGia = txtDonGia.Text;
                tSanXuat = txtNuocSX.Text;
                tMaHang = txtMaHang.Text;
                tdvt = txtDonVi.Text;

                sql = "Insert into tblDMHH (MaNhom, MaHH, TenHH, Dvt, Dgvnd, SanXuat) Values ('" + tManhom + "',N'" + tMaHang + "',N'" + tTenHH + "','" + tdvt + "'," + TDonGia + ",N'" + tSanXuat + "')";
                      
                clsMain.DoSQL(sql);
                NapLai();
                addnewFlag = false;
            }
        }
        public void NapCT()
        {
               int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
                txtMaNhom.Text   = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
              txtTenHang.Text  = grdData.Rows[i].Cells["TenHH"].Value.ToString();
              txtDonVi.Text = grdData.Rows[i].Cells["Dvt"].Value.ToString();
               txtDonGia.Text  = grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
               txtNuocSX.Text  = grdData.Rows[i].Cells["SanXuat"].Value.ToString();
              txtMaHang.Text  = grdData.Rows[i].Cells["MaHH"].Value.ToString();
         }

        public void NewR()
        {
            btnupdate.PerformClick();
            txtMaNhom.Text = "";
            txtTenHang.Text = "";
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtNuocSX.Text = "";
            txtMaHang.Text = "";
            addnewFlag = true;
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void grdData_KeyUp(object sender, KeyEventArgs e)
        {
            NapCT();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            //btnupdate.PerformClick();
            txtMaNhom.Text = "";
            txtTenHang.Text = "";
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtNuocSX.Text = "";
            txtMaHang.Text = "";
            txtMaNhom.Focus();
            addnewFlag = true;
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comTruong.Text + " From tblDmHH ";
            DataTable comtb = new DataTable();    
            
            da = new SqlDataAdapter(sql, conn);
            da.Fill(comtb);
            comGT.DataSource = comtb;
            comGT.DisplayMember = comTruong.Text;
            comGT.ValueMember = comTruong.Text;
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rptDMHH rpt = new rptDMHH();
            sql = "Select MaHH, TenHH, Dvt, Dgvnd, SanXuat From tblDMHH where MaNhom='" + comGT.Text + "'";
            DataTable rpdata = new DataTable();
            //rpdata.Clear();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(rpdata);
           rpt.DataDefinition.FormulaFields["TenNhom"].Text  = "'" + comGT.Text  + "'";
            rpt.SetDataSource(rpdata);
            frmPreviewRP rp = new frmPreviewRP(rpt);
            rp.Show(); 
               
        }                              
    }
}