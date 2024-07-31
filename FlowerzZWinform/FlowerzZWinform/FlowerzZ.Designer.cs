namespace FlowerzZWinform
{
    partial class FlowerzZ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowerzZ));
            showFlowerzBackground = new Button();
            populateDatabase = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // showFlowerzBackground
            // 
            showFlowerzBackground.Location = new Point(12, 395);
            showFlowerzBackground.Name = "showFlowerzBackground";
            showFlowerzBackground.Size = new Size(290, 23);
            showFlowerzBackground.TabIndex = 0;
            showFlowerzBackground.Text = "Show Flowerz Background (in Separate Window)";
            showFlowerzBackground.UseVisualStyleBackColor = true;
            showFlowerzBackground.Click += ShowFlowerzBackground_Click;
            // 
            // doSomeDBStuff
            // 
            populateDatabase.Location = new Point(12, 12);
            populateDatabase.Name = "doSomeDBStuff";
            populateDatabase.Size = new Size(177, 23);
            populateDatabase.TabIndex = 1;
            populateDatabase.Text = "Populate the Database";
            populateDatabase.UseVisualStyleBackColor = true;
            populateDatabase.Click += PopulateDatabase_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(12, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(672, 337);
            textBox1.TabIndex = 2;
            textBox1.Text = "-- EF log will appear here --";
            // 
            // FlowerzZ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(populateDatabase);
            Controls.Add(showFlowerzBackground);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FlowerzZ";
            Text = "Flowerz Z";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button showFlowerzBackground;
        private Button populateDatabase;
        private TextBox textBox1;
    }
}