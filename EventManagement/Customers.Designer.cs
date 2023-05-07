namespace EventManagement
{
    partial class Customers
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
            label3 = new Label();
            CustPhone = new TextBox();
            custDGV = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            btnEvent = new Button();
            btnCust = new Button();
            btnClose = new Button();
            CustName = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)custDGV).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 418);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 64;
            label3.Text = "Phone No";
            // 
            // CustPhone
            // 
            CustPhone.Location = new Point(507, 441);
            CustPhone.Name = "CustPhone";
            CustPhone.Size = new Size(143, 27);
            CustPhone.TabIndex = 63;
            // 
            // custDGV
            // 
            custDGV.AllowUserToAddRows = false;
            custDGV.AllowUserToDeleteRows = false;
            custDGV.BackgroundColor = SystemColors.ControlLightLight;
            custDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custDGV.Location = new Point(11, 66);
            custDGV.Name = "custDGV";
            custDGV.ReadOnly = true;
            custDGV.RowHeadersWidth = 51;
            custDGV.RowTemplate.Height = 29;
            custDGV.Size = new Size(1162, 307);
            custDGV.TabIndex = 53;
            custDGV.CellContentClick += custDGV_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 62);
            panel1.TabIndex = 50;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(491, 20);
            label1.Name = "label1";
            label1.Size = new Size(245, 29);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(-1, 381);
            panel3.Name = "panel3";
            panel3.Size = new Size(1187, 10);
            panel3.TabIndex = 52;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnEvent);
            panel2.Controls.Add(btnCust);
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(2, 541);
            panel2.Name = "panel2";
            panel2.Size = new Size(1187, 62);
            panel2.TabIndex = 51;
            // 
            // btnEvent
            // 
            btnEvent.Location = new Point(648, 5);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(103, 45);
            btnEvent.TabIndex = 24;
            btnEvent.Text = "Events";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
            // 
            // btnCust
            // 
            btnCust.Location = new Point(399, 5);
            btnCust.Name = "btnCust";
            btnCust.Size = new Size(103, 45);
            btnCust.TabIndex = 23;
            btnCust.Text = "Venues";
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
            // CustName
            // 
            CustName.Location = new Point(239, 441);
            CustName.Name = "CustName";
            CustName.Size = new Size(169, 27);
            CustName.TabIndex = 55;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(973, 479);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 45);
            btnDelete.TabIndex = 62;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(973, 412);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 45);
            btnEdit.TabIndex = 61;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(814, 454);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 45);
            btnSave.TabIndex = 60;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 418);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 54;
            label2.Text = "Customer Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.dashboard;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(526, 505);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 67);
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 584);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(CustPhone);
            Controls.Add(custDGV);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(CustName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Name = "Customers";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)custDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox CustPhone;
        private DataGridView custDGV;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Button btnEvent;
        private Button btnCust;
        private Button btnClose;
        private TextBox CustName;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Label label2;
        private PictureBox pictureBox1;
    }
}