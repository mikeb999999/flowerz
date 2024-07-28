namespace FlowerzZWinform
{
    public partial class FlowerzBackground : Form
    {
        public FlowerzBackground()
        {
            InitializeComponent();
            Text = "Some Flowerz";
        }
        private void FlowerzBackground_Click(object sender, EventArgs e)
        {
            //var f = new FlowerzZ();
            //f.Show();
            Close();
        }

    }
}
