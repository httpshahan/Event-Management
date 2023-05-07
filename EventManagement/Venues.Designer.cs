namespace EventManagement
{
    partial class Venues
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
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            VnManager = new TextBox();
            Vmanager = new Label();
            VnAddress = new TextBox();
            Vname = new Label();
            VnName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            btnEvent = new Button();
            btnCust = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            label1 = new Label();
            VenueDGV = new DataGridView();
            panel1 = new Panel();
            VnCapacity = new TextBox();
            label3 = new Label();
            VnMphone = new TextBox();
            Vphone = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VenueDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(973, 471);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 45);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(973, 404);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 45);
            btnEdit.TabIndex = 44;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(814, 446);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 45);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // VnManager
            // 
            VnManager.Location = new Point(590, 422);
            VnManager.Name = "VnManager";
            VnManager.Size = new Size(169, 27);
            VnManager.TabIndex = 42;
            // 
            // Vmanager
            // 
            Vmanager.AutoSize = true;
            Vmanager.Location = new Point(590, 399);
            Vmanager.Name = "Vmanager";
            Vmanager.Size = new Size(68, 20);
            Vmanager.TabIndex = 41;
            Vmanager.Text = "Manager";
            // 
            // VnAddress
            // 
            VnAddress.Location = new Point(393, 427);
            VnAddress.Multiline = true;
            VnAddress.Name = "VnAddress";
            VnAddress.Size = new Size(169, 89);
            VnAddress.TabIndex = 36;
            // 
            // Vname
            // 
            Vname.AutoSize = true;
            Vname.Location = new Point(393, 404);
            Vname.Name = "Vname";
            Vname.Size = new Size(62, 20);
            Vname.TabIndex = 35;
            Vname.Text = "Address";
            // 
            // VnName
            // 
            VnName.Location = new Point(30, 427);
            VnName.Name = "VnName";
            VnName.Size = new Size(169, 27);
            VnName.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 404);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 27;
            label2.Text = "Venue Name";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(-1, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(1187, 10);
            panel3.TabIndex = 25;
            // 
            // btnEvent
            // 
            btnEvent.Location = new Point(629, 5);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(103, 45);
            btnEvent.TabIndex = 24;
            btnEvent.Text = "Events";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
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
            // btnClose
            // 
            btnClose.Location = new Point(1056, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 29);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnEvent);
            panel2.Controls.Add(btnCust);
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(2, 533);
            panel2.Name = "panel2";
            panel2.Size = new Size(1187, 62);
            panel2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(491, 20);
            label1.Name = "label1";
            label1.Size = new Size(203, 29);
            label1.TabIndex = 0;
            label1.Text = "Manage Venues";
            // 
            // VenueDGV
            // 
            VenueDGV.AllowUserToAddRows = false;
            VenueDGV.AllowUserToDeleteRows = false;
            VenueDGV.BackgroundColor = SystemColors.ControlLightLight;
            VenueDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VenueDGV.Location = new Point(11, 58);
            VenueDGV.Name = "VenueDGV";
            VenueDGV.ReadOnly = true;
            VenueDGV.RowHeadersWidth = 51;
            VenueDGV.RowTemplate.Height = 29;
            VenueDGV.RowTemplate.ReadOnly = true;
            VenueDGV.Size = new Size(1162, 307);
            VenueDGV.TabIndex = 26;
            VenueDGV.CellContentClick += VenueDGV_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 62);
            panel1.TabIndex = 23;
            // 
            // VnCapacity
            // 
            VnCapacity.Location = new Point(227, 427);
            VnCapacity.Name = "VnCapacity";
            VnCapacity.Size = new Size(143, 27);
            VnCapacity.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 404);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 47;
            label3.Text = "Capacity";
            // 
            // VnMphone
            // 
            VnMphone.Location = new Point(590, 481);
            VnMphone.Name = "VnMphone";
            VnMphone.Size = new Size(169, 27);
            VnMphone.TabIndex = 49;
            // 
            // Vphone
            // 
            Vphone.AutoSize = true;
            Vphone.Location = new Point(590, 458);
            Vphone.Name = "Vphone";
            Vphone.Size = new Size(74, 20);
            Vphone.TabIndex = 48;
            Vphone.Text = "Phone No";
            // 
            // Venues
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 584);
            Controls.Add(VnMphone);
            Controls.Add(Vphone);
            Controls.Add(label3);
            Controls.Add(VnCapacity);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(VnManager);
            Controls.Add(Vmanager);
            Controls.Add(VnAddress);
            Controls.Add(Vname);
            Controls.Add(VnName);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(VenueDGV);
            Controls.Add(panel1);
            Name = "Venues";
            Text = "Venues";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VenueDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private TextBox VnManager;
        private Label Vmanager;
        private TextBox VnAddress;
        private Label Vname;
        private TextBox VnName;
        private Label label2;
        private Panel panel3;
        private Button btnEvent;
        private Button btnCust;
        private Button btnClose;
        private Panel panel2;
        private Label label1;
        private DataGridView VenueDGV;
        private Panel panel1;
        private TextBox VnCapacity;
        private Label label3;
        private TextBox VnMphone;
        private Label Vphone;
    }
}