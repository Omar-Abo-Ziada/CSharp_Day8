using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day8
{
    public partial class DigitalClock : Control
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.FillRectangle(Brushes.Yellow,
                0, 0, this.Width, this.Height);

            //base.OnPaint(pe);
        }

        private void DigitalClock_MouseLeave(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            g.FillRectangle(Brushes.Yellow,
                0, 0, this.Width, this.Height);
        }

        private void DigitalClock_MouseEnter(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            g.FillRectangle(Brushes.DarkRed,
                0, 0, this.Width, this.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString("HH:mm:ss");

            Graphics g = CreateGraphics();

            g.FillRectangle(Brushes.Yellow,
                0, 0, this.Width, this.Height);

            g.DrawString(s, this.Font,
                Brushes.Black, 10, 10);
        }
    }
}
