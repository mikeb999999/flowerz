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

            }

            return log;
        }

        /// <summary> P i n e w o o d HQ1 </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = LineOfText("1) What does the \"new\" keyword in a method signature do and how might it change behaviour?");
            textBox1.Text += LineOfText("2. Hiding Members\r\n\r\nThe `new` keyword can be used to hide a member inherited from a base class. When a member (method, property, indexer, or event) in a derived class has the same name as one in the base class, you can use the `new` keyword to explicitly hide the base class member. This is called \"method hiding\" or \"member hiding.\"\r\n");

            var demoNewMethod = new AllAboutNewMethodSiggie();
            textBox1.Text += LineOfText("******") + LineOfText(demoNewMethod.DoPart1()) + LineOfText("******");
        }



        static public string LineOfText(string line)
        {
            return line + Environment.NewLine;
        }
    }
}
