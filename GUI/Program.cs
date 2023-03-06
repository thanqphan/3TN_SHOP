using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new frmKhachhang());*/

            frmMain work = new frmMain();
            int check = 0;
            //
            frmDangNhap dn = new frmDangNhap();
            Application.Run(dn);
            if (dn.DialogResult == DialogResult.OK)
            {
                work = new frmMain(dn.username);
                Application.Run(work);
            }
            //
            /*do
            {
                frmDangNhap dn = new frmDangNhap();
                Application.Run(dn);
                if (dn.DialogResult == DialogResult.OK)
                {
                    work = new frmMain(dn.username);
                    Application.Run(work);
                }
                else
                {
                    if (dn.DialogResult == DialogResult.Yes)
                    {
                        frmKhachhang kh = new frmKhachhang(dn.username);
                        Application.Run(kh);
                        if (kh.DialogResult == DialogResult.OK)
                            work.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        check = 1;
                    }
                }
            }
            while (work.DialogResult == DialogResult.OK && check == 0);*/
        }
    }
}
