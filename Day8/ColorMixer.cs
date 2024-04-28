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
    public partial class ColorMixer : UserControl
    {
        public event EventHandler ColorChanged;

        public ColorMixer()
        {
            InitializeComponent();
        }

        public Color Color
        {
            get
            {
                return Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            lblPreview.ForeColor =
                Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);

            if (ColorChanged == null)
                return;

            ColorChanged(this, new EventArgs()); 
        }
    }
}
