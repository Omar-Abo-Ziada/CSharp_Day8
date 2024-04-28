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
    public partial class FrmControls : Form
    {
        public FrmControls()
        {
            InitializeComponent();

            colorMixer1.ColorChanged += ColorMixer1_ColorChanged;
        }
        private void ColorMixer1_ColorChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = colorMixer1.Color;
        }
    }
}
