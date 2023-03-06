using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usctrlNoti : UserControl
    {
        Timer time = new Timer();
        public usctrlNoti()
        {
            InitializeComponent();
            time.Interval = 2000;
            time.Tick += new EventHandler(TimerOnTick);
            time.Enabled = true;
        }
        public usctrlNoti(string NotiType, string message)
        {
            InitializeComponent();
            time.Interval = 2000;
            time.Tick += new EventHandler(TimerOnTick);
            time.Enabled = true;
            switch (NotiType)
            {
                case "Error":
                    BackColor = Color.Red;
                    break;
                case "Success":
                    BackColor = Color.Green;
                    break;
                case "Normal":
                    BackColor = Color.Yellow;
                    break;
                case "Warning":
                    BackColor = Color.Red;
                    break;
            }
            lblNoti.Text = message;

        }
        public void ShowNoti()
        {
            int loca_x = (this.Width - lblNoti.Width) / 2;
            int loca_y = (this.Height - lblNoti.Height) / 2;
            lblNoti.Location = new Point(loca_x, loca_y);
            lblNoti.ForeColor = Color.Black;
        }
        public void TimerOnTick(object obj, EventArgs e)
        {
            this.Hide();
        }
    }
}
