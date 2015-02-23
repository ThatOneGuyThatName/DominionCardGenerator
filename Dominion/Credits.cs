using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominion
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void ButtonLink_Click(object sender, EventArgs e)
        {System.Diagnostics.Process.Start("http://dominionstrategy.com/");}

        private void Credits_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            ButtonLink.BackColor = Color.Transparent;
            ButtonLink.FlatStyle = FlatStyle.Flat;
            ButtonLink.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonLink.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}
