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



        private void frmNguoiQuanLy_Load(object sender, EventArgs e)
        {




            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = false;
        }

        private void pnlPQL_Paint(object sender, PaintEventArgs e)
        {
            //grbPQL.Visible = true;
           // grbTKTK.Visible = false;
        }

        private void pnlTKTK_Paint(object sender, PaintEventArgs e)
        {
            //grbPQL.Visible = false;
           // grbTKTK.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {


           
        }

        private void lblTKTT_Click(object sender, EventArgs e)
        {
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTaoMoi_PQL_Click(object sender, EventArgs e)
        {
            txtMP_PQL.Text = "";
            txtTP_PQL.Text = "";

            txtMP_PQL.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

        private void btnPQL_Click(object sender, EventArgs e)
        {
            grbPQL.Visible = true;
            grbTKTK.Visible = false;
            grbGD.Visible = false;


            btnPQL.BackColor = Color.FromArgb(26, 154, 254);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);

            picPQL.BackColor = Color.FromArgb(26, 154, 254);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(24, 44, 79);




            LAYBANG_PHONGQUANLY();
        }

        private void btnTKTK_Click(object sender, EventArgs e)
        {
            grbPQL.Visible = false;
            grbTKTK.Visible = true;
            grbGD.Visible = false;


            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(26, 154, 254);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);

            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(26, 154, 254);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(24, 44, 79);


            LAYBANG_TKTK();
            LAYBANG_KH_TKTK();
        }

        private void btnGD_Click(object sender, EventArgs e)
        {

            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = true;


            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(26, 154, 254);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);

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

        private void btnCTGD_Click(object sender, EventArgs e)
        {
            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = false;


            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(26, 154, 254);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);

            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(26, 154, 254);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(24, 44, 79);
        }

        private void btnLaiSuat_Click(object sender, EventArgs e)
        {
            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = false;


            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.BackColor = Color.FromArgb(26, 154, 254);

            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(24, 44, 79);
            picLS.BackColor = Color.FromArgb(26, 154, 254);
        }

        private void btnKyHan_Click(object sender, EventArgs e)
        {
            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbGD.Visible = false;


            btnPQL.BackColor = Color.FromArgb(24, 44, 79);
            btnTKTK.BackColor = Color.FromArgb(24, 44, 79);
            btnGD.BackColor = Color.FromArgb(24, 44, 79);
            btnCTGD.BackColor = Color.FromArgb(24, 44, 79);
            btnKyHan.BackColor = Color.FromArgb(26, 154, 254);
            btnLaiSuat.BackColor = Color.FromArgb(24, 44, 79);


            picPQL.BackColor = Color.FromArgb(24, 44, 79);
            picTKTK.BackColor = Color.FromArgb(24, 44, 79);
            picGD.BackColor = Color.FromArgb(24, 44, 79);
            picCTGD.BackColor = Color.FromArgb(24, 44, 79);
            picKH.BackColor = Color.FromArgb(26, 154, 254);
            picLS.BackColor = Color.FromArgb(24, 44, 79);
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
    }
}
