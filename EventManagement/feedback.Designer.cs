namespace EventManagement
{
    partial class feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feedback));
            fbDGV = new DataGridView();
            btnReset = new Button();
            btnSave = new Button();
            EventId = new Label();
            Ename = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            EVid = new ComboBox();
            panel1 = new Panel();
            label3 = new Label();
            fbVenue = new ComboBox();
            label4 = new Label();
            fbHost = new ComboBox();
            label5 = new Label();
            fbPunc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fbDGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // fbDGV
            // 
            fbDGV.AllowUserToAddRows = false;
            fbDGV.AllowUserToDeleteRows = false;
            fbDGV.BackgroundColor = SystemColors.ControlLightLight;
            fbDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fbDGV.Location = new Point(12, 65);
            fbDGV.Name = "fbDGV";
            fbDGV.ReadOnly = true;
            fbDGV.RowHeadersWidth = 51;
            fbDGV.RowTemplate.Height = 29;
            fbDGV.Size = new Size(1162, 307);
            fbDGV.TabIndex = 77;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(632, 493);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(103, 45);
            btnReset.TabIndex = 76;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(470, 493);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 45);
            btnSave.TabIndex = 74;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EventId
            // 
            EventId.AutoSize = true;
            EventId.Location = new Point(138, 416);
            EventId.Name = "EventId";
            EventId.Size = new Size(62, 20);
            EventId.TabIndex = 62;
            EventId.Text = "Event Id";
            // 
            // Ename
            // 
            Ename.Location = new Point(328, 439);
            Ename.Name = "Ename";
            Ename.ReadOnly = true;
            Ename.Size = new Size(169, 27);
            Ename.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 416);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 58;
            label2.Text = "Event Name";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(0, 380);
            panel3.Name = "panel3";
            panel3.Size = new Size(1187, 10);
            panel3.TabIndex = 57;
            // 
            // button4
            // 
            button4.Location = new Point(1056, 5);
            button4.Name = "button4";
            button4.Size = new Size(103, 29);
            button4.TabIndex = 23;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(3, 544);
            panel2.Name = "panel2";
            panel2.Size = new Size(1187, 118);
            panel2.TabIndex = 56;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.Custom_Icon_Design_Silky_Line_User_Users_512;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.ErrorImage = (Image)resources.GetObject("pictureBox4.ErrorImage");
            pictureBox4.Location = new Point(696, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 61);
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.eventpng;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Location = new Point(620, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 61);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.dashboard;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Location = new Point(543, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 61);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.png;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(458, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 61);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(491, 20);
            label1.Name = "label1";
            label1.Size = new Size(133, 29);
            label1.TabIndex = 0;
            label1.Text = "FeedBack";
            // 
            // EVid
            // 
            EVid.FormattingEnabled = true;
            EVid.Location = new Point(138, 438);
            EVid.Name = "EVid";
            EVid.Size = new Size(151, 28);
            EVid.TabIndex = 63;
            EVid.SelectionChangeCommitted += EVid_SelectionChangeCommitted;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 62);
            panel1.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 416);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 78;
            label3.Text = "Venue";
            // 
            // fbVenue
            // 
            fbVenue.FormattingEnabled = true;
            fbVenue.Items.AddRange(new object[] { "Bad", "Good", "Excellent" });
            fbVenue.Location = new Point(533, 438);
            fbVenue.Name = "fbVenue";
            fbVenue.Size = new Size(151, 28);
            fbVenue.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(726, 416);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 80;
            label4.Text = "Hospatality";
            // 
            // fbHost
            // 
            fbHost.FormattingEnabled = true;
            fbHost.Items.AddRange(new object[] { "Bad", "Good", "Excellent" });
            fbHost.Location = new Point(726, 438);
            fbHost.Name = "fbHost";
            fbHost.Size = new Size(151, 28);
            fbHost.TabIndex = 81;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(914, 416);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 82;
            label5.Text = "Punctuality";
            // 
            // fbPunc
            // 
            fbPunc.FormattingEnabled = true;
            fbPunc.Items.AddRange(new object[] { "Bad", "Good", "Excellent" });
            fbPunc.Location = new Point(914, 438);
            fbPunc.Name = "fbPunc";
            fbPunc.Size = new Size(151, 28);
            fbPunc.TabIndex = 83;
            // 
            // feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(label5);
            Controls.Add(fbPunc);
            Controls.Add(label4);
            Controls.Add(fbHost);
            Controls.Add(label3);
            Controls.Add(fbVenue);
            Controls.Add(fbDGV);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(EventId);
            Controls.Add(Ename);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(EVid);
            Controls.Add(panel1);
            Name = "feedback";
            Text = "feedback";
            Load += feedback_Load;
            ((System.ComponentModel.ISupportInitialize)fbDGV).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView fbDGV;
        private Button btnReset;
        private Button btnSave;
        private Label EventId;
        private TextBox Ename;
        private Label label2;
        private Panel panel3;
        private Button button4;
        private Panel panel2;
        private Label label1;
        private ComboBox EVid;
        private Panel panel1;
        private Label label3;
        private ComboBox fbVenue;
        private Label label4;
        private ComboBox fbHost;
        private Label label5;
        private ComboBox fbPunc;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}