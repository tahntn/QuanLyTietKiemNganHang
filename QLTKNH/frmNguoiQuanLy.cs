using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTKNH
{
    public partial class frmNguoiQuanLy : Form
    {
        public frmNguoiQuanLy()
        {
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();

        private void frmNguoiQuanLy_Load(object sender, EventArgs e)
        {
            grbTTNQL.Visible = false;
            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = false;
            grbCTGD.Visible = false;
            grbLS.Visible = false;
            grbKH.Visible = false;

            btnTTNQL.Visible = false;
            btnPQL.Visible = false;
            btnTKTK.Visible = false;
            btnGD.Visible = false;
            btnCTGD.Visible = false;
            btnLaiSuat.Visible = false;
            btnKyHan.Visible = false;

            picTTNQL.Visible = false;
            picPQL.Visible = false;
            picTKTK.Visible = false;
            picGD.Visible = false;
            picCTGD.Visible = false;
            picKH.Visible = false;
            picLS.Visible = false;

        }
        //button Thông tin người quản lý

        private void btnTTNQL_Click(object sender, EventArgs e)
        {
            grbTTNQL.Visible =true;
            grbPQL.Visible = true;
            grbTKTK.Visible = false;
            grbGD.Visible = false;
            grbCTGD.Visible = false;
            grbLS.Visible = false;
            grbKH.Visible = false;

            btnTTNQL.BackColor = Color.FromArgb(26, 154, 254);
            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);


            picTTNQL.BackColor = Color.FromArgb(26, 154, 254);
            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(24, 44, 79);

            LAYBANG_TTNQL();
        }

        //button Phòng Quản Lý

        private void btnPQL_Click(object sender, EventArgs e)
        {
            grbTTNQL.Visible = false;
            grbPQL.Visible = true;
            grbTKTK.Visible = false;
            grbGD.Visible = false;
            grbCTGD.Visible = false;
            grbLS.Visible = false;
            grbKH.Visible = false;

            btnTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            btnPQL.BackColor = Color.FromArgb(26, 154, 254);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);

            picTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            picPQL.BackColor = Color.FromArgb(26, 154, 254);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(24, 44, 79);




            LAYBANG_PHONGQUANLY();
        }

        // button Tài khoán tiết kiệm

        private void btnTKTK_Click(object sender, EventArgs e)
        {
            grbTTNQL.Visible = false;
            grbPQL.Visible = false;
            grbTKTK.Visible = true;
            grbGD.Visible = false;
            grbCTGD.Visible = false;
            grbLS.Visible = false;
            grbKH.Visible = false;

            btnTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(26, 154, 254);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);

            picTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(26, 154, 254);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(24, 44, 79);


            LAYBANG_TKTK();
            LAYBANG_KH_TKTK();
        }

        //button Giao Dịch

        private void btnGD_Click(object sender, EventArgs e)
        {

            grbTTNQL.Visible = false;
            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = true;
            grbCTGD.Visible = false;
            grbLS.Visible = false;
            grbKH.Visible = false;

            btnTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(26, 154, 254);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);

            picTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(26, 154, 254);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(24, 44, 79);


            LAYBANG_GD();
            LAYBANG_KH_GD();
            LAYBANG_TKTK_GD();
        }


        //button Chi tiết giao dịch

        private void btnCTGD_Click(object sender, EventArgs e)
        {
            grbTTNQL.Visible = false;
            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = false;
            grbCTGD.Visible = true;
            grbLS.Visible = false;
            grbKH.Visible = false;

            btnTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(26, 154, 254);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);

            picTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(26, 154, 254);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(24, 44, 79);


            LAYBANG_CTGD();
            LAYBANG_KH_CTGD();
            LAYBANG_GD_CTGD();
        }

        //buttoon Lãi Suất

        private void btnLaiSuat_Click(object sender, EventArgs e)
        {
            grbTTNQL.Visible = false;
            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = false;
            grbCTGD.Visible = false;
            grbLS.Visible = true;
            grbKH.Visible = false;

            btnTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(26, 154, 254);

            picTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(26, 154, 254);

            LAYBANG_LS();
        }


        //button Kỳ Hạn
        private void btnKyHan_Click(object sender, EventArgs e)
        {
            grbTTNQL.Visible = false;
            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = false;
            grbCTGD.Visible = false;
            grbLS.Visible = false;
            grbKH.Visible = true;

            btnTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(26, 154, 254);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);


            picTTNQL.BackColor = Color.FromArgb(24, 44, 79);
            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(26, 154, 254);
            picLS.BackColor = Color.FromArgb(24, 44, 79);

            LAYBANG_KH();
            LAYBANG_TTNQL_KH();
            LAYBANG_TKTK_KH();
            LAYBANG_LS_KH();
        }

        //-------------------------------------------------//


        //Thông Tin Người Quản Lý
        private void LAYBANG_TTNQL()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * From THONGTINNGUOIQUANLY");
            dataTTNQL.DataSource = dta;
            Hienthi_Dulieu_TTNQL();

        }
        private void Hienthi_Dulieu_TTNQL()
        {
            txtMQL_TTNQL.DataBindings.Clear();
            txtMQL_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "MAQL");

            txtTQL_TTNQL.DataBindings.Clear();
            txtTQL_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "TENQL");

            txtSDT_TTNQL.DataBindings.Clear();
            txtSDT_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "SDT");

            txtEmail_TTNQL.DataBindings.Clear();
            txtEmail_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "EMAIL");

            txtDC_TTNQL.DataBindings.Clear();
            txtDC_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "DIACHIQL");

        }
        private void btnTM_TTNQL_Click(object sender, EventArgs e)
        {
            txtMQL_TTNQL.Text = "";
            txtTQL_TTNQL.Text = "";
            txtSDT_TTNQL.Text = "";
            txtEmail_TTNQL.Text = "";
            txtDC_TTNQL.Text = "";

            txtMQL_TTNQL.Focus();
        }

        private void btnSua_TTNQL_Click(object sender, EventArgs e)
        {
            kn.Execute("Update THONGTINNGUOIQUANLY SET TENQL = '" + txtTQL_TTNQL.Text + "', SDT = '" + txtSDT_TTNQL.Text + "', Email = '" + txtEmail_TTNQL.Text + "', DIACHIQL = '" + txtDC_TTNQL.Text + "' where MAQL = '" + txtMQL_TTNQL.Text + "'");

            LAYBANG_TTNQL();
        }

        private void btnLuu_TTNQL_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO THONGTINNGUOIQUANLY Values ('" + txtMQL_TTNQL.Text + "','" + txtTQL_TTNQL.Text + "','" + txtSDT_TTNQL.Text + "','" + txtEmail_TTNQL.Text + "','" + txtDC_TTNQL.Text + "')");
            LAYBANG_TTNQL();
        }

        private void btnXoa_TTNQL_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete THONGTINNGUOIQUANLY where MAQL = '" +txtMQL_TTNQL.Text + "'");
            LAYBANG_TTNQL();
        }

        //-------------------------------------------------//


        //Phòng Quản Lý
        private void LAYBANG_PHONGQUANLY()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select* From PHONG");
            dataPQL.DataSource = dta;
            Hienthi_Dulieu_PQL();

        }

        private void Hienthi_Dulieu_PQL()
        {
            txtMP_PQL.DataBindings.Clear();
            txtMP_PQL.DataBindings.Add("Text", dataPQL.DataSource, "MAPHONG");

            txtTP_PQL.DataBindings.Clear();
            txtTP_PQL.DataBindings.Add("Text", dataPQL.DataSource, "TENPHONG");
        }

        private void btnTaoMoi_PQL_Click(object sender, EventArgs e)
        {
            txtMP_PQL.Text = "";
            txtTP_PQL.Text = "";

            txtMP_PQL.Focus();
        }

        private void btnSua_PQL_Click(object sender, EventArgs e)
        {
            kn.Execute("Update PHONG SET TENPHONG = '" + txtTP_PQL.Text +"' where MAPHONG = '" + txtMP_PQL.Text + "'");
            LAYBANG_PHONGQUANLY();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete PHONG where MAPHONG = '" + txtMP_PQL.Text + "'");
            LAYBANG_PHONGQUANLY();
        }

        private void btnLuu_PQL_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO PHONG Values ('" + txtMP_PQL.Text + "','" + txtTP_PQL.Text +"')");
            LAYBANG_PHONGQUANLY();
        }



        //-------------------------------------------------//


        //Tài khoản tiết kiệm

        public void LAYBANG_TKTK()
        {

            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  TAIKHOANTIETKIEM");
            dataTKTK.DataSource = data;
            Hienthi_Dulieu_TKTK();
        }

        public void LAYBANG_KH_TKTK()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  KHACHHANG");
            txtMKH_TKTK.DataSource = data;
            txtMKH_TKTK.DisplayMember = "MAKH";
            txtMKH_TKTK.ValueMember = "MAKH";
        }

        private void Hienthi_Dulieu_TKTK()
        {
            txtMTK_TKTK.DataBindings.Clear();
            txtMTK_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "MATK");

            txtMKH_TKTK.DataBindings.Clear();
            txtMKH_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "MAKH");

            txtNMS_TKTK.DataBindings.Clear();
            txtNMS_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "NGAYMOSO");

            txtSTG_TKTK.DataBindings.Clear();
            txtSTG_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "SOTIENGOC");

            txtLT_TKTK.DataBindings.Clear();
            txtLT_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "LOAITIEN");
        }

        private void btnTM_TKTK_Click(object sender, EventArgs e)
        {
            txtMTK_TKTK.Text = "";
            txtMKH_TKTK.Text = "";
            txtNMS_TKTK.Text = "";
            txtSTG_TKTK.Text = "";
            txtLT_TKTK.Text = "";

            txtMTK_TKTK.Focus();
        }

        private void btnSua_TKTK_Click(object sender, EventArgs e)
        {
            kn.Execute("Update TAIKHOANTIETKIEM SET MAKH = '" + txtMKH_TKTK.Text +"', NGAYMOSO ='"+ txtNMS_TKTK.Value + "', SOTIENGOC = '" + txtSTG_TKTK.Text + "', LOAITIEN ='"+ txtLT_TKTK.Text + "' where MATK = '" + txtMTK_TKTK.Text + "'");
            LAYBANG_TKTK();
        }

        private void btnLuu_TKTK_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO TAIKHOANTIETKIEM  Values ('" + txtMTK_TKTK.Text + "','" + txtMKH_TKTK.Text  + "','" + txtNMS_TKTK.Value + "','"+ txtSTG_TKTK.Text + "','" + txtLT_TKTK.Text + "')");
            LAYBANG_TKTK();
        }

        private void btnXoa_TKTK_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete TAIKHOANTIETKIEM where MATK = '" + txtMTK_TKTK.Text + "'");
            LAYBANG_TKTK();
        }

        //---------------------------------------//

        //Giao dịch

        public void LAYBANG_GD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  GIAODICH");
            dataGD.DataSource = data;
            Hienthi_Dulieu_GD();
        }

        public void LAYBANG_TKTK_GD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  TAIKHOANTIETKIEM");
            txtMTK_GD.DataSource = data;
            txtMTK_GD.DisplayMember = "MATK";
            txtMTK_GD.ValueMember = "MATK";    
        }

        public void LAYBANG_KH_GD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From KYHAN");
            txtMKH_GD.DataSource = data;
            txtMKH_GD.DisplayMember = "MAKYHAN";
            txtMKH_GD.ValueMember = "MAKYHAN";
        }

        private void Hienthi_Dulieu_GD()
        {
            txtMGD_GD.DataBindings.Clear();
            txtMGD_GD.DataBindings.Add("Text", dataGD.DataSource, "MAGD");

            txtMTK_GD.DataBindings.Clear();
            txtMTK_GD.DataBindings.Add("Text", dataGD.DataSource, "MATK");

            txtNGD_GD.DataBindings.Clear();
            txtNGD_GD.DataBindings.Add("Text", dataGD.DataSource, "NGAYGD");

            txtLGD_GD.DataBindings.Clear();
            txtLGD_GD.DataBindings.Add("Text", dataGD.DataSource, "LOAIGD");


            txtST_GD.DataBindings.Clear();
            txtST_GD.DataBindings.Add("Text", dataGD.DataSource, "SOTIEN");

            txtLTK_GD.DataBindings.Clear();
            txtLTK_GD.DataBindings.Add("Text", dataGD.DataSource, "LOAITIETKIEM");

            txtMKH_GD.DataBindings.Clear();
            txtMKH_GD.DataBindings.Add("Text", dataGD.DataSource, "MAKYHAN");
        }

        private void btnTM_GD_Click(object sender, EventArgs e)
        {
            txtMGD_GD.Text = "";
            txtMTK_GD.Text = "";
            txtNGD_GD.Text = "";
            txtLGD_GD.Text = "";
            txtST_GD.Text = "";
            txtLTK_GD.Text = "";
            txtMKH_GD.Text = "";

            txtMGD_GD.Focus();
        }

        private void btnSua_GD_Click(object sender, EventArgs e)
        {
            kn.Execute("Update GIAODICH SET MATK = '" + txtMTK_GD.Text + "', NGAYGD ='" + txtNGD_GD.Value + "', LOAIGD ='" + txtLGD_GD.Text + "', SOTIEN ='" + txtST_GD.Text + "', LOAITIETKIEM ='" + txtLTK_GD.Text + "', MAKYHAN ='" + txtMKH_GD.Text + "' where MAGD = '" + txtMGD_GD.Text + "'");
            LAYBANG_GD();
        }

        private void btnLuu_GD_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO GIAODICH Values ('" + txtMGD_GD.Text + "','" + txtMTK_GD.Text + "','" + txtNGD_GD.Value + "','" + txtLGD_GD.Text + "','" + txtST_GD.Text + "','" + txtLTK_GD.Text + "','" + txtMKH_GD.Text + "')");
            LAYBANG_GD();
        }

        private void btnXoa_GD_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete GIAODICH where MAGD = '" +txtMGD_GD.Text + "'");
            LAYBANG_GD();
        }

        //------------------------------------------//


        //chi tiết giao dịch

        public void LAYBANG_CTGD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  CHITIETGIAODICH");
            dataCTGD.DataSource = data;
            Hienthi_Dulieu_CTGD();
        }

        public void LAYBANG_KH_CTGD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  KHACHHANG");
            txtMKH_CTGD.DataSource = data;
            txtMKH_CTGD.DisplayMember = "MAKH";
            txtMKH_CTGD.ValueMember = "MAKH";
        }

        public void LAYBANG_GD_CTGD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From GIAODICH");
            txtMGD_CTGD.DataSource = data;
            txtMGD_CTGD.DisplayMember = "MAGD";
            txtMGD_CTGD.ValueMember = "MAGD";
        }

        private void Hienthi_Dulieu_CTGD()
        {
            txtMCT_CTGD.DataBindings.Clear();
            txtMCT_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "MACHITIET");

            txtMKH_CTGD.DataBindings.Clear();
            txtMKH_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "MAKH");

            txtMGD_CTGD.DataBindings.Clear();
            txtMGD_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "MAGD");

            txtST_CTGD.DataBindings.Clear();
            txtST_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "SOTIEN");

            txtND_CTGD.DataBindings.Clear();
            txtND_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "NOIDUNG");
        }

        private void btnTM_CTGD_Click(object sender, EventArgs e)
        {
            txtMCT_CTGD.Text = "";
            txtMKH_CTGD.Text = "";
            txtMGD_CTGD.Text = "";
            txtST_CTGD.Text = "";
            txtND_CTGD.Text = "";

            txtMCT_CTGD.Focus();
        }

        private void btnSuaCTGD_Click(object sender, EventArgs e)
        {
            kn.Execute("Update CHITIETGIAODICH SET MAKH = '" + txtMKH_CTGD.Text + "', MAGD ='" + txtMGD_CTGD.Text + "', SOTIEN ='" + txtST_CTGD.Text + "', NOIDUNG ='" + txtND_CTGD.Text + "' where MACHITIET = '" + txtMCT_CTGD.Text + "'");
            LAYBANG_CTGD();
        }

        private void btnLuu_CTGD_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO CHITIETGIAODICH Values ('" + txtMCT_CTGD.Text + "','" + txtMKH_CTGD.Text + "','" + txtMGD_CTGD.Text + "','" + txtST_CTGD.Text + "','" + txtND_CTGD.Text  + "')");
            LAYBANG_CTGD();
        }

        private void btnXoa_CTGD_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete CHITIETGIAODICH where MACHITIET = '" + txtMCT_CTGD.Text + "'");
            LAYBANG_CTGD();
        }



        //--------------------------------------------//


        //Lãi Suất

        public void LAYBANG_LS()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  LAISUAT");
            dataLS.DataSource = data;
            Hienthi_Dulieu_LS();
        }

        private void Hienthi_Dulieu_LS()
        {
            txtMaLS_LS.DataBindings.Clear();
            txtMaLS_LS.DataBindings.Add("Text", dataLS.DataSource, "MALS");

            txtMucLS_LS.DataBindings.Clear();
            txtMucLS_LS.DataBindings.Add("Text", dataLS.DataSource, "MUCLS");
        }

        private void btnTM_LS_Click(object sender, EventArgs e)
        {
            txtMaLS_LS.Text = "";
            txtMucLS_LS.Text = "";

            txtMaLS_LS.Focus();
        }

        private void btnSua_LS_Click(object sender, EventArgs e)
        {
            kn.Execute("Update LAISUAT SET MUCLS = '" + txtMucLS_LS.Text + "' where MALS = '" + txtMaLS_LS.Text + "'");
            LAYBANG_LS();
        }

        private void btnLuu_LS_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO LAISUAT Values ('" + txtMaLS_LS.Text + "','" + txtMucLS_LS.Text + "')");
            LAYBANG_LS();
        }

        private void btnXoa_LS_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete LAISUAT where MALS = '" + txtMaLS_LS.Text + "'");
            LAYBANG_LS();
        }

        //--------------------------------------------//


        //Kỳ Hạn

        public void LAYBANG_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  KYHAN");
            dataKH.DataSource = data;
            Hienthi_Dulieu_KH();
        }
       
        public void LAYBANG_TTNQL_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From THONGTINNGUOIQUANLY");
            txtMQL_KH.DataSource = data;
            txtMQL_KH.DisplayMember = "MAQL";
            txtMQL_KH.ValueMember = "MAQL";
        }

        public void LAYBANG_TKTK_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From TAIKHOANTIETKIEM");
            txtMTK_KH.DataSource = data;
            txtMTK_KH.DisplayMember = "MATK";
            txtMTK_KH.ValueMember = "MATK";
        }

        public void LAYBANG_LS_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From LAISUAT");
            txtMLS_KH.DataSource = data;
            txtMLS_KH.DisplayMember = "MALS";
            txtMLS_KH.ValueMember = "MALS";
        }

        private void Hienthi_Dulieu_KH()
        {
            txtMKH_KH.DataBindings.Clear();
            txtMKH_KH.DataBindings.Add("Text", dataKH.DataSource, "MAKYHAN");

            txtMQL_KH.DataBindings.Clear();
            txtMQL_KH.DataBindings.Add("Text", dataKH.DataSource, "MAQL");

            txtMTK_KH.DataBindings.Clear();
            txtMTK_KH.DataBindings.Add("Text", dataKH.DataSource, "MATK");

            txtKH_KH.DataBindings.Clear();
            txtKH_KH.DataBindings.Add("Text", dataKH.DataSource, "KYHAN");

            txtMLS_KH.DataBindings.Clear();
            txtMLS_KH.DataBindings.Add("Text", dataKH.DataSource, "MALS");

            txtLT_KH.DataBindings.Clear();
            txtLT_KH.DataBindings.Add("Text", dataKH.DataSource, "LOAITIEN");
        }
        private void btnTM_KH_Click(object sender, EventArgs e)
        {
            txtMKH_KH.Text = "";
            txtMQL_KH.Text = "";
            txtMTK_KH.Text = "";
            txtKH_KH.Text = "";
            txtMLS_KH.Text = "";
            txtLT_KH.Text = "";


            txtMKH_KH.Focus();
        }

        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            kn.Execute("Update KYHAN SET MAQL = '" + txtMQL_KH.Text + "', MATK = '" + txtMTK_KH.Text+ "', KYHAN = '" + txtKH_KH.Text+ "', MALS = '" + txtMLS_KH.Text +"', LOAITIEN = '" + txtLT_KH.Text + "' where MAKYHAN = '" + txtMKH_KH.Text + "'");
            LAYBANG_KH();
        }

        private void btnLuu_KH_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO KYHAN Values ('" + txtMKH_KH.Text + "','" + txtMQL_KH.Text + "','" + txtMTK_KH.Text + "','" + txtKH_KH.Text + "','" + txtLT_KH.Text + "','" + txtMLS_KH.Text + "')");
            LAYBANG_KH();
        }

        private void btnXoa_KH_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete KYHAN where MAKYHAN = '" + txtMKH_KH.Text + "'");
            LAYBANG_KH();
        }



        //button Thoat

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Xử lí

        int btnTTCN1 = 0;
        private void btnTTCN_Click(object sender, EventArgs e)
        {
           // int btnTTCN1 = 0;
            btnTTCN1++;

            if( btnTTCN1 % 2 == 1)
            {
                btnPQL.Visible = true;
                btnTTNQL.Visible = true;
                btnTKTK.Visible = false;
                btnGD.Visible = false;
                btnCTGD.Visible = false;
                btnLaiSuat.Visible = false;
                btnKyHan.Visible = false;

                picTTNQL.Visible = true;
                picPQL.Visible = true;
                picTKTK.Visible = false;
                picGD.Visible = false;
                picCTGD.Visible = false;
                picKH.Visible = false;
                picLS.Visible = false;

               
                btnTTKH.Location = new Point(0, 355);
                btnTTLS.Location = new Point(0, 435);
            }

            else
            {
                btnPQL.Visible = false;
                btnTTNQL.Visible = false;
                btnTKTK.Visible = false;
                btnGD.Visible = false;
                btnCTGD.Visible = false;
                btnLaiSuat.Visible = false;
                btnKyHan.Visible = false;

                picTTNQL.Visible = false;
                picPQL.Visible = false;
                picTKTK.Visible = false;
                picGD.Visible = false;
                picCTGD.Visible = false;
                picKH.Visible = false;
                picLS.Visible = false;


               
                btnTTKH.Location = new Point(0, 255);
                btnTTLS.Location = new Point(0, 335);
            }
           
        }

        int btnTTKH1 = 0;

        private void btnTTKH_Click(object sender, EventArgs e)
        {
            btnTTKH1++;
            if(btnTTKH1 % 2 == 1 )
            {
                btnTTNQL.Visible = false;
                btnPQL.Visible = false;
                btnTKTK.Visible = true;
                btnGD.Visible = true;
                btnCTGD.Visible = true;
                btnLaiSuat.Visible = false;
                btnKyHan.Visible = false;

                picTTNQL.Visible = false;
                picPQL.Visible = false;
                picTKTK.Visible = true;
                picGD.Visible = true;
                picCTGD.Visible = true;
                picKH.Visible = false;
                picLS.Visible = false;


                btnTTKH.Location = new Point(0, 255);
                btnTTLS.Location = new Point(0, 485);

            }
            else
            {
                btnPQL.Visible = false;
                btnTTNQL.Visible = false;
                btnTKTK.Visible = false;
                btnGD.Visible = false;
                btnCTGD.Visible = false;
                btnLaiSuat.Visible = false;
                btnKyHan.Visible = false;

                picTTNQL.Visible = false;
                picPQL.Visible = false;
                picTKTK.Visible = false;
                picGD.Visible = false;
                picCTGD.Visible = false;
                picKH.Visible = false;
                picLS.Visible = false;


               

                btnTTKH.Location = new Point(0, 255);
                btnTTLS.Location = new Point(0, 335);
            }
        }
        int btnTTLS1 = 0;
        private void btnTTLS_Click(object sender, EventArgs e)
        {
            btnTTLS1++;
            if (btnTTLS1 % 2==1 )
            {
                btnPQL.Visible = false;
                btnTTNQL.Visible = false;
                btnTKTK.Visible = false;
                btnGD.Visible = false;
                btnCTGD.Visible = false;
                btnLaiSuat.Visible = true;
                btnKyHan.Visible = true;

                picTTNQL.Visible = false;
                picPQL.Visible = false;
                picTKTK.Visible = false;
                picGD.Visible = false;
                picCTGD.Visible = false;
                picKH.Visible = true;
                picLS.Visible = true;

                btnTTKH.Location = new Point(0, 255);
                btnTTLS.Location = new Point(0, 335);
            }
            else
            {
                btnPQL.Visible = false;
                btnTTNQL.Visible = false;
                btnTKTK.Visible = false;
                btnGD.Visible = false;
                btnCTGD.Visible = false;
                btnLaiSuat.Visible = false;
                btnKyHan.Visible = false;

                picTTNQL.Visible = false;
                picPQL.Visible = false;
                picTKTK.Visible = false;
                picGD.Visible = false;
                picCTGD.Visible = false;
                picKH.Visible = false;
                picLS.Visible = false;

                btnTTKH.Location = new Point(0, 255);
                btnTTLS.Location = new Point(0, 335);
            }
        }

        
    }
}
