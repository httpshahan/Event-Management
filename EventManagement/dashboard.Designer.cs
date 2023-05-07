namespace EventManagement
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel1 = new Panel();
            veneueCount = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            eventCount = new Label();
            label3 = new Label();
            panel4 = new Panel();
            custCount = new Label();
            label4 = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(veneueCount);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(175, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // veneueCount
            // 
            veneueCount.AutoSize = true;
            veneueCount.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            veneueCount.Location = new Point(81, 59);
            veneueCount.Name = "veneueCount";
            veneueCount.Size = new Size(34, 27);
            veneueCount.TabIndex = 1;
            veneueCount.Text = "11";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(26, 12);
            label2.Name = "label2";
            label2.Size = new Size(90, 27);
            label2.TabIndex = 0;
            label2.Text = "Venues";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1187, 75);
            panel2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(491, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 29);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(eventCount);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(746, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // eventCount
            // 
            eventCount.AutoSize = true;
            eventCount.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            eventCount.Location = new Point(64, 59);
            eventCount.Name = "eventCount";
            eventCount.Size = new Size(34, 27);
            eventCount.TabIndex = 2;
            eventCount.Text = "11";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(28, 12);
            label3.Name = "label3";
            label3.Size = new Size(85, 27);
            label3.TabIndex = 1;
            label3.Text = "Events";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.AppWorkspace;
            panel4.Controls.Add(custCount);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(455, 336);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 1;
            // 
            // custCount
            // 
            custCount.AutoSize = true;
            custCount.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            custCount.Location = new Point(71, 59);
            custCount.Name = "custCount";
            custCount.Size = new Size(34, 27);
            custCount.TabIndex = 3;
            custCount.Text = "11";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(18, 13);
            label4.Name = "label4";
            label4.Size = new Size(127, 27);
            label4.TabIndex = 2;
            label4.Text = "Customers";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(button4);
            panel5.Location = new Point(0, 553);
            panel5.Name = "panel5";
            panel5.Size = new Size(1187, 118);
            panel5.TabIndex = 57;
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
            pictureBox2.BackgroundImage = Properties.Resources.feedback;
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
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 640);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "dashboard";
            Text = "dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label veneueCount;
        private Label eventCount;
        private Label custCount;
    }
}