namespace EventManagement
{
    partial class EventMange
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnVenue = new Button();
            btnCust = new Button();
            button4 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            Ename = new TextBox();
            Edate = new Label();
            EDatenTime = new DateTimePicker();
            VenueId = new Label();
            EVid = new ComboBox();
            ECid = new ComboBox();
            Custid = new Label();
            EVname = new TextBox();
            Vname = new Label();
            ECname = new TextBox();
            Cname = new Label();
            Estatus = new ComboBox();
            status = new Label();
            Eduration = new TextBox();
            duration = new Label();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            eventDGV = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(491, 20);
            label1.Name = "label1";
            label1.Size = new Size(195, 29);
            label1.TabIndex = 0;
            label1.Text = "Manage Events";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnVenue);
            panel2.Controls.Add(btnCust);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(3, 547);
            panel2.Name = "panel2";
            panel2.Size = new Size(1187, 118);
            panel2.TabIndex = 1;
            // 
            // btnVenue
            // 
            btnVenue.Location = new Point(629, 5);
            btnVenue.Name = "btnVenue";
            btnVenue.Size = new Size(103, 45);
            btnVenue.TabIndex = 24;
            btnVenue.Text = "Venue";
            btnVenue.UseVisualStyleBackColor = true;
            btnVenue.Click += btnVenue_Click;
            // 
            // btnCust
            // 
            btnCust.Location = new Point(491, 5);
            btnCust.Name = "btnCust";
            btnCust.Size = new Size(103, 45);
            btnCust.TabIndex = 23;
            btnCust.Text = "Customer";
            btnCust.UseVisualStyleBackColor = true;
            btnCust.Click += btnCust_Click;
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
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(0, 383);
            panel3.Name = "panel3";
            panel3.Size = new Size(1187, 10);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 414);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "Event Name";
            // 
            // Ename
            // 
            Ename.Location = new Point(31, 437);
            Ename.Name = "Ename";
            Ename.Size = new Size(169, 27);
            Ename.TabIndex = 5;
            // 
            // Edate
            // 
            Edate.AutoSize = true;
            Edate.Location = new Point(240, 414);
            Edate.Name = "Edate";
            Edate.Size = new Size(81, 20);
            Edate.TabIndex = 6;
            Edate.Text = "Event Date";
            // 
            // EDatenTime
            // 
            EDatenTime.Format = DateTimePickerFormat.Short;
            EDatenTime.Location = new Point(240, 437);
            EDatenTime.Name = "EDatenTime";
            EDatenTime.Size = new Size(123, 27);
            EDatenTime.TabIndex = 7;
            // 
            // VenueId
            // 
            VenueId.AutoSize = true;
            VenueId.Location = new Point(403, 414);
            VenueId.Name = "VenueId";
            VenueId.Size = new Size(66, 20);
            VenueId.TabIndex = 8;
            VenueId.Text = "Venue Id";
            // 
            // EVid
            // 
            EVid.FormattingEnabled = true;
            EVid.Location = new Point(403, 436);
            EVid.Name = "EVid";
            EVid.Size = new Size(151, 28);
            EVid.TabIndex = 9;
            EVid.SelectionChangeCommitted += EVid_SelectionChangeCommitted;
            // 
            // ECid
            // 
            ECid.FormattingEnabled = true;
            ECid.Location = new Point(31, 503);
            ECid.Name = "ECid";
            ECid.Size = new Size(151, 28);
            ECid.TabIndex = 11;
            ECid.SelectionChangeCommitted += ECid_SelectionChangeCommitted;
            // 
            // Custid
            // 
            Custid.AutoSize = true;
            Custid.Location = new Point(31, 481);
            Custid.Name = "Custid";
            Custid.Size = new Size(89, 20);
            Custid.TabIndex = 10;
            Custid.Text = "Customer Id";
            // 
            // EVname
            // 
            EVname.Enabled = false;
            EVname.Location = new Point(576, 437);
            EVname.Name = "EVname";
            EVname.Size = new Size(169, 27);
            EVname.TabIndex = 13;
            // 
            // Vname
            // 
            Vname.AutoSize = true;
            Vname.Location = new Point(576, 414);
            Vname.Name = "Vname";
            Vname.Size = new Size(93, 20);
            Vname.TabIndex = 12;
            Vname.Text = "Venue Name";
            // 
            // ECname
            // 
            ECname.Enabled = false;
            ECname.Location = new Point(240, 504);
            ECname.Name = "ECname";
            ECname.Size = new Size(169, 27);
            ECname.TabIndex = 15;
            // 
            // Cname
            // 
            Cname.AutoSize = true;
            Cname.Location = new Point(240, 481);
            Cname.Name = "Cname";
            Cname.Size = new Size(116, 20);
            Cname.TabIndex = 14;
            Cname.Text = "Customer Name";
            // 
            // Estatus
            // 
            Estatus.FormattingEnabled = true;
            Estatus.Items.AddRange(new object[] { "Waiting", "Pending", "Complete" });
            Estatus.Location = new Point(437, 503);
            Estatus.Name = "Estatus";
            Estatus.Size = new Size(117, 28);
            Estatus.TabIndex = 17;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(437, 481);
            status.Name = "status";
            status.Size = new Size(49, 20);
            status.TabIndex = 16;
            status.Text = "Status";
            // 
            // Eduration
            // 
            Eduration.Location = new Point(576, 504);
            Eduration.Name = "Eduration";
            Eduration.Size = new Size(169, 27);
            Eduration.TabIndex = 19;
            // 
            // duration
            // 
            duration.AutoSize = true;
            duration.Location = new Point(576, 481);
            duration.Name = "duration";
            duration.Size = new Size(67, 20);
            duration.TabIndex = 18;
            duration.Text = "Duration";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(815, 456);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 45);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(974, 414);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 45);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(974, 481);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 45);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // eventDGV
            // 
            eventDGV.AllowUserToAddRows = false;
            eventDGV.AllowUserToDeleteRows = false;
            eventDGV.BackgroundColor = SystemColors.ControlLightLight;
            eventDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventDGV.Location = new Point(12, 68);
            eventDGV.Name = "eventDGV";
            eventDGV.ReadOnly = true;
            eventDGV.RowHeadersWidth = 51;
            eventDGV.RowTemplate.Height = 29;
            eventDGV.Size = new Size(1162, 307);
            eventDGV.TabIndex = 54;
            eventDGV.CellContentClick += eventDGV_CellContentClick;
            // 
            // EventMange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 640);
            Controls.Add(eventDGV);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(Eduration);
            Controls.Add(duration);
            Controls.Add(Estatus);
            Controls.Add(status);
            Controls.Add(ECname);
            Controls.Add(Cname);
            Controls.Add(EVname);
            Controls.Add(Vname);
            Controls.Add(ECid);
            Controls.Add(Custid);
            Controls.Add(EVid);
            Controls.Add(VenueId);
            Controls.Add(EDatenTime);
            Controls.Add(Edate);
            Controls.Add(Ename);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EventMange";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eventDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private TextBox Ename;
        private Label Edate;
        private DateTimePicker EDatenTime;
        private Label VenueId;
        private ComboBox EVid;
        private ComboBox ECid;
        private Label Custid;
        private TextBox EVname;
        private Label Vname;
        private TextBox ECname;
        private Label Cname;
        private ComboBox Estatus;
        private Label status;
        private TextBox Eduration;
        private Label duration;
        private Button button4;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnVenue;
        private Button btnCust;
        private DataGridView eventDGV;
    }
}