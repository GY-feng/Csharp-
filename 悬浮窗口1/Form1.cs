using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace 悬浮窗口1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //取消边框最大化和最小化的按钮
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //将窗体设置为透明
            this.BackColor = Color.FromArgb(0, 0, 1);
            this.TransparencyKey = this.BackColor;

            //设置窗体大小
            this.Top = 20;
            this.Left = Screen.PrimaryScreen.Bounds.Width - 80;
            this.Width = 1400;
            this.Height = 600;

            this.lab_time.Text="现在时间"+ DateTime.Now.ToString();
            this.lab_Word.Text = "于高山之巅，方见大河奔涌；于群峰之上，更觉长风浩荡。";
            this.lab_distance_time.Text="距离高考："+ GatDatTimeDistance();
        }
        public string GatDatTimeDistance()
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2023, 6, 7);
            TimeSpan d3 = d2.Subtract(d1); 

            return d3.Days.ToString();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color FColor = Color.Red;
            Color TColor = Color.Yellow;
            Brush b = new LinearGradientBrush(this.ClientRectangle, FColor, TColor, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, this.ClientRectangle);
        }

        //实现鼠标拖动悬浮窗体，
        const int WM_NCHITTEST = 0x0084;
        const int HTCLIENT = 0x0001;
        const int HTCAPTION = 0x0002;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if (m.Result == (IntPtr)HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lab_Word.Text = "会当凌绝顶，一看众山小";
        }
    }
}
