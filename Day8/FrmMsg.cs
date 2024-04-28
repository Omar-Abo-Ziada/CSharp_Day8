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
    public partial class FrmMsg : Form
    {
        public event EventHandler<string> MsgChanged;

        public string Msg
        {
            get { return txtMsg.Text; }
            set { txtMsg.Text = value; }
        }

        public FrmMsg()//string msg)
        {
            InitializeComponent();

            //txtMsg.Text = msg;
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {
            if (MsgChanged == null)
                return;

            MsgChanged(this, txtMsg.Text);
        }
    }
}
