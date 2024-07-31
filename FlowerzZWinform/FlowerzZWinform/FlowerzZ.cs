namespace FlowerzZWinform
{
    public partial class FlowerzZ : Form
    {
        public FlowerzZ()
        {
            InitializeComponent();
        }

        private void ShowFlowerzBackground_Click(object sender, EventArgs e)
        {
            var f = new FlowerzBackground();
            f.Show();
        }
        private void PopulateDatabase_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            textBox1.Text = PopulateDatabase();
            this.Cursor = Cursors.Default;
        }
        private string PopulateDatabase()
        {
            // Code First development targeting a new database
            // https://learn.microsoft.com/en-gb/ef/ef6/modeling/code-first/workflows/new-database?redirectedfrom=MSDN
            var log = "";
            log += LineOfText("Log of EF processing");
            log += LineOfText("");

            // ref. https://learn.microsoft.com/en-gb/ef/ef6/modeling/code-first/workflows/new-database?redirectedfrom=MSDN
            // // Reading & writing data
            using (var db = new FlowerzContext())
            {
                // Creates the database if not exists
                db.Database.EnsureCreated();

                // Create and save a new Bloom
                var name = "Sunflower" + " " + Guid.NewGuid();

                var bloom = new Bloom { Name = name };
                db.Bloom.Add(bloom);
                db.SaveChanges();

                // Display all Blooms from the database
                var query = from b in db.Bloom
                            orderby b.Name
                            select b;

                log += LineOfText("All blooms in the database:");
                foreach (var item in query)
                {
                    log += LineOfText(item.Name);
                }

                //Console.WriteLine("Press any key to exit...");
                //Console.ReadKey();
            }

            return log;
        }
        private string LineOfText(string line)
        {
            return line + Environment.NewLine;
        }
    }
}
