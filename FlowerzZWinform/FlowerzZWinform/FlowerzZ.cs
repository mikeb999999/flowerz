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
using Model;

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
            // Code First development targeting a new database
            // https://learn.microsoft.com/en-gb/ef/ef6/modeling/code-first/workflows/new-database?redirectedfrom=MSDN
            var log = "";
            log += LineOfText("Log of EF processing");
            log += LineOfText("-----------------");
            log += LineOfText("");
            log += LineOfText(".");

            // ref. https://learn.microsoft.com/en-gb/ef/ef6/modeling/code-first/workflows/new-database?redirectedfrom=MSDN
            // // Reading & writing data
            using (var db = new FlowerzContext())
            {
                // Create and save a new Bloom
                //   Console.Write("Enter a name for a new Bloom: ");
                //var name = Console.ReadLine();
                var name = "Sunflower";

                var bloom = new Bloom { Name = name };
                db.Blooms.Add(bloom);
                db.SaveChanges();

                // Display all Blooms from the database
                var query = from b in db.Blooms
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
