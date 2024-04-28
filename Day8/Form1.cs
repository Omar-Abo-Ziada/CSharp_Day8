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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            lblMsg.ForeColor = colorDialog1.Color;
        }

        private void bntSetImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            //lblMsg.Text = openFileDialog1.FileName;
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            string msg = txtInfo.Text;

            FrmMsg frm = new FrmMsg();//(msg);
            //frm.Msg = msg;
            frm.MsgChanged += Frm_MsgChanged;
            frm.Show();
        }

        private void Frm_MsgChanged(object sender, string msg)
        {
            txtInfo.Text = msg;
        }
    }
}
