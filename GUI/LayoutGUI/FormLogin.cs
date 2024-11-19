using DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Configuration;

namespace GUI.LayoutGUI
{
    public partial class FormLogin : Form
    {
        QLSHOPDataContext sql = new QLSHOPDataContext();
        public FormLogin()
        {
            InitializeComponent();
            this.Load += FormLogin_Load;
            uc_DangNhap1.GetChange_DN += Uc_DangNhap1_GetChange_DN;
        }

        private void Uc_DangNhap1_GetChange_DN(object sender, EventArgs e)
        {
            if (uc_DangNhap1.TT)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Program.mainForm == null || Program.mainForm.IsDisposed)
                {
                    Program.mainForm = new FormMain();
                }

                this.Hide(); // Ẩn FormLogin
                Program.mainForm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Chuỗi kết nối không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                uc_DangNhap1.Conn = connectionString; // Truyền chuỗi kết nối vào `uc_DangNhap`
            }
        }
    }
}
