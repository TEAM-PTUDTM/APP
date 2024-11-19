using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DangNhap
{
    public class QL_NguoiDung
    {
        private readonly QLSHOPDataContext _context;

        public QL_NguoiDung(string connectionString)
        {
            _context = new QLSHOPDataContext(connectionString);
        }

        // Kiểm tra cấu hình
        public int Check_Config(string pcnn)
        {
            try
            {
                using (var context = new QLSHOPDataContext(pcnn))
                {
                    context.Connection.Open();
                    return 0; // Kết nối thành công
                }
            }
            catch
            {
                return 2; // Chuỗi cấu hình không hợp lệ
            }
        }

        // Kiểm tra tài khoản người dùng
        public LoginResult Check_User(string pUser, string pPass)
        {
            // Truy vấn bảng `users`
            var user = _context.users.FirstOrDefault(u => u.email == pUser && u.password == pPass);

            if (user == null)
                return LoginResult.Invalid; // Sai tên đăng nhập hoặc mật khẩu

            //if (user.is_active == false)
            //    return LoginResult.Disabled; // Tài khoản bị khóa

            return LoginResult.Success; // Đăng nhập thành công
        }
    }
}
