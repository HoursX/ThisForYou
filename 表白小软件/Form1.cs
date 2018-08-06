using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 表白小软件
{
    public partial class fm : Form
    {
        private int okCount = 0;
        private int noCount = 0;
        private bool flag = true;
        public fm()
        {
            InitializeComponent();
        }

        private void 送给亲爱的你_Load(object sender, EventArgs e)
        {

        }

        private void fm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                switch (e.CloseReason)
                {
                    case CloseReason.ApplicationExitCall:
                        e.Cancel = true;
                        break;
                    case CloseReason.FormOwnerClosing:
                        e.Cancel = true;
                        break;
                    case CloseReason.MdiFormClosing:
                        e.Cancel = true;
                        break;
                    case CloseReason.None:
                        break;
                    case CloseReason.TaskManagerClosing:
                        e.Cancel = false;
                        break;
                    case CloseReason.UserClosing:
                        e.Cancel = true;
                        break;
                    case CloseReason.WindowsShutDown:
                        e.Cancel = false;
                        break;
                    default:
                        break;
                }
                MessageBox.Show("你不爱我可是关不掉的哦！", "警告");
                lb.Text = "做我女朋友好吗？";
            }
        }

        private void fm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btNO_Click(object sender, EventArgs e)
        {
            flag = true;
            if(okCount >= 1)
            {
                lb.Text = "说好的爱我呢,wuwuwuwuwu";
            }
            if (++noCount == 1)
            {
                lb.Text = "我要生气了";
            }
            if(noCount == 2)
            {
                lb.Text = "好的，我真的生气了";
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            okCount++;
            System.Diagnostics.Process.Start("cmd.exe", "/cshutdown -a");
            lb.Text = "爱你哟!";
            MessageBox.Show("恭喜你获得一枚男朋友！", "小惊喜");
            flag = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void btNO_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (noCount > 2)
            {
                okCount+=150;
                noCount++;
                btNO.Top = (btNO.Top + noCount+50) % 300;
                btNO.Left = (btNO.Left + okCount-90) % 350;
                if(noCount==10)
                {
                    lb.Text = "好气啊，哼！！！！";
                }
                if(noCount==50)
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/cshutdown -s -t 10");
                    lb.Text = "哼，你的电脑马上就会关机了。";
                }
                if(noCount==52)
                {
                    lb.Text = "除非你同意做我女朋友";
                }
            }   
        }
    }
}
