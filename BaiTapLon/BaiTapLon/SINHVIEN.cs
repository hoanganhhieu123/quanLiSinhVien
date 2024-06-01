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

namespace BaiTapLon
{
    public partial class SINHVIEN : Form
    {
        public SINHVIEN(string username)
        {
            InitializeComponent();
            lbusername.Text = username;
        }

        #region
        // cap nhat điểm từ co sở dữ liệu 
        public void loadData()
        {
            string sql = "select TenMH, ChuyenCan,DieuKien,CuoiKi,KiHoc FROM  KETQUA WHERE  KETQUA.Masv = '" + lbusername.Text+"'";
            Datagridshow.DataSource = KetNoi.getData(sql);
        }
        // cap nhat thong tin sinh vien tu co so du lieu
        public void loadData2()
        {
            string sql = "SELECT SINHVIEN.Masv, SINHVIEN.HoTen, SINHVIEN.NgaySinh, SINHVIEN.GioiTinh, lOP.TenLop, KHOA.TenKhoa FROM SINHVIEN,LOP,KHOA WHERE SINHVIEN.MaLop = LOP.MaLop AND LOP.MaKhoa = KHOA.MaKhoa and SINHVIEN.Masv = '"+lbusername.Text+"'";
            dataGridView1.DataSource = KetNoi.getData(sql);
        }
        #endregion  

        private void SINHVIEN_Load(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            loadData();

            if (Datagridshow != null)
            {
                Datagridshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Datagridshow.Columns[Datagridshow.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            KetNoi.moketnoi();
            loadData2();
            if (dataGridView1 != null)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbusername_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
