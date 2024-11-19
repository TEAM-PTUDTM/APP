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

namespace DangNhap
{
    public partial class uc_DangNhap : UserControl
    {
        private QL_NguoiDung _nguoiDung;

        public event EventHandler GetChange_DN;
        public string Conn { get; set; }
        public bool TT { get; private set; }

        public uc_DangNhap()
        {
            InitializeComponent();
            this.btn_login.Click += Btn_login_Click;
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_User.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống tài khoản!");
                this.txt_User.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Pass.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu!");
                this.txt_Pass.Focus();
                return;
            }

            _nguoiDung = new QL_NguoiDung(Conn); // Khởi tạo với chuỗi kết nối
            int configCheck = _nguoiDung.Check_Config(Conn);

            switch (configCheck)
            {
                case 0:
                    ProcessLogin();
                    break;
                case 1:
                    MessageBox.Show("Chuỗi cấu hình không tồn tại!");
                    break;
                case 2:
                    MessageBox.Show("Chuỗi cấu hình không hợp lệ!");
                    break;
            }
        }
        private void ProcessLogin()
        {
            TT = false;

            var result = _nguoiDung.Check_User(txt_User.Text, txt_Pass.Text);

            switch (result)
            {
                case LoginResult.Invalid:
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                    break;
                case LoginResult.Disabled:
                    MessageBox.Show("Tài khoản đã bị khóa!");
                    break;
                case LoginResult.Success:
                    TT = true;
                    GetChange_DN?.Invoke(this, EventArgs.Empty); // Kích hoạt sự kiện
                    break;
            }
        }
    }
    public enum LoginResult
    {
        /// <summary>
        /// Wrong username or password
        /// </summary>
        Invalid,
        /// <summary>
        /// User had been disabled
        /// </summary>
        Disabled,
        /// <summary>
        /// Loging success
        /// </summary>
        Success
    }
}
