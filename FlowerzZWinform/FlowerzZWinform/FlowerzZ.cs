using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlowerzZWinform
{
    public partial class FlowerzZ : Form
    {
        public FlowerzZ()
        {
            InitializeComponent();
        }

        private void showFlowerzBackground_Click(object sender, EventArgs e)
        {
            var f = new FlowerzBackground();
            f.Show();
        }
        private void doSomeDBStuff_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            textBox1.Text = doSomeDBStuf();

            this.Cursor = Cursors.Default;
        }
        private string doSomeDBStuf()
        {
            Thread.Sleep(3000);
            return @"Doing
some
DB
stuff
............................................";
        }

    }
}
