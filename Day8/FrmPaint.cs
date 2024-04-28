using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day8
{
    public partial class FrmPaint : Form
    {
        Rectangle rectangle = new Rectangle();

        public FrmPaint()
        {
            InitializeComponent();
        }

        private void FrmPaint_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(Pens.Red, rectangle);

            //GraphicsPath path = new GraphicsPath();

            //path.AddEllipse(new Rectangle(10, 10, 200, 200));
            //path.AddEllipse(new Rectangle(300, 300, 50, 300));

            //this.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();

            rectangle = new Rectangle(50, 50, 200, 200);
            gr.DrawRectangle(Pens.Red, 50, 50, 200, 200);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
           // base.OnMouseMove(e);
        }

        private void FrmPaint_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = this.CreateGraphics();

            //if (e.Button == MouseButtons.Left)
                gr.FillRectangle(Brushes.Red, e.X, e.Y, 10, 10);
        }
    }
}
