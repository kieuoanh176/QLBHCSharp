namespace QLBHCSharp
{
    partial class frmDMHH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comTruong = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(1332, 703);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(147, 48);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(800, 703);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(147, 48);
            this.btnnew.TabIndex = 6;
            this.btnnew.Text = "Thêm mới";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(956, 703);
            this.btndel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(147, 48);
            this.btndel.TabIndex = 7;
            this.btndel.Text = "Xóa";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(1112, 703);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(177, 48);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1424, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1052, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lọc dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1059, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên trường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1263, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giá trị";
            // 
            // comTruong
            // 
            this.comTruong.FormattingEnabled = true;
            this.comTruong.Items.AddRange(new object[] {
            "MaNhom",
            "MaHH",
            "SanXuat"});
            this.comTruong.Location = new System.Drawing.Point(1038, 108);
            this.comTruong.Name = "comTruong";
            this.comTruong.Size = new System.Drawing.Size(181, 28);
            this.comTruong.TabIndex = 13;
            this.comTruong.SelectedIndexChanged += new System.EventHandler(this.comTruong_SelectedIndexChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLoc.Location = new System.Drawing.Point(1152, 188);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(234, 45);
            this.btnLoc.TabIndex = 15;
            this.btnLoc.Text = "Lọc dữ liệu";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.MaHH,
            this.TenHH,
            this.Dvt,
            this.Dgvnd,
            this.SanXuat});
            this.grdData.Location = new System.Drawing.Point(12, 25);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 62;
            this.grdData.RowTemplate.Height = 33;
            this.grdData.Size = new System.Drawing.Size(1002, 629);
            this.grdData.TabIndex = 16;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick);
            this.grdData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdData_KeyUp);
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã nhóm";
            this.MaNhom.MinimumWidth = 8;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Width = 111;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã hàng";
            this.MaHH.MinimumWidth = 8;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 107;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên hàng";
            this.TenHH.MinimumWidth = 8;
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 112;
            // 
            // Dvt
            // 
            this.Dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dvt.DataPropertyName = "Dvt";
            this.Dvt.HeaderText = "Đơn vị";
            this.Dvt.MinimumWidth = 8;
            this.Dvt.Name = "Dvt";
            this.Dvt.Width = 89;
            // 
            // Dgvnd
            // 
            this.Dgvnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dgvnd.DataPropertyName = "Dgvnd";
            this.Dgvnd.HeaderText = "Đơn giá";
            this.Dgvnd.MinimumWidth = 8;
            this.Dgvnd.Name = "Dgvnd";
            // 
            // SanXuat
            // 
            this.SanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SanXuat.DataPropertyName = "SanXuat";
            this.SanXuat.HeaderText = "Nước SX";
            this.SanXuat.MinimumWidth = 8;
            this.SanXuat.Name = "SanXuat";
            this.SanXuat.Width = 108;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtMaHang);
            this.gb1.Controls.Add(this.label9);
            this.gb1.Controls.Add(this.txtNuocSX);
            this.gb1.Controls.Add(this.txtDonGia);
            this.gb1.Controls.Add(this.txtDonVi);
            this.gb1.Controls.Add(this.txtTenHang);
            this.gb1.Controls.Add(this.txtMaNhom);
            this.gb1.Controls.Add(this.label8);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Location = new System.Drawing.Point(1029, 265);
            this.gb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb1.Size = new System.Drawing.Size(450, 388);
            this.gb1.TabIndex = 17;
            this.gb1.TabStop = false;
            this.gb1.Text = "Chi tiết";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(123, 91);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(310, 26);
            this.txtMaHang.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mã Hàng";
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(123, 294);
            this.txtNuocSX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(310, 26);
            this.txtNuocSX.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(123, 240);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(310, 26);
            this.txtDonGia.TabIndex = 9;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(123, 186);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(310, 26);
            this.txtDonVi.TabIndex = 8;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(123, 137);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(310, 26);
            this.txtTenHang.TabIndex = 7;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(123, 35);
            this.txtMaNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(310, 26);
            this.txtMaNhom.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 294);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nước SX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đơn vị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Nhóm";
            // 
            // comGT
            // 
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(1268, 106);
            this.comGT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(182, 28);
            this.comGT.TabIndex = 18;
            // 
            // btnIn
            // 
            this.btnIn.ForeColor = System.Drawing.Color.Red;
            this.btnIn.Image = global::QLBHCSharp.Properties.Resources.filequickprint;
            this.btnIn.Location = new System.Drawing.Point(40, 688);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(256, 45);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In danh sách theo nhóm hàng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmDMHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1492, 769);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.comTruong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnEnd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDMHH";
            this.Text = "Danh mục hàng hóa";
            this.Load += new System.EventHandler(this.frmDMHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comTruong;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanXuat;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.Button btnIn;
    }
}