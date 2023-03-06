using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ThongTinDangNhap
    {
        private static string userName, userChucVu, maNV;
        public static string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public static string UserChucVu
        {
            get { return userChucVu; }
            set { userChucVu = value; }
        }
    }
}
