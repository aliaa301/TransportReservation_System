﻿namespace TransportReservationSystem.Rows
{
    partial class UCDriver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            tripsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            EditBtn = new CustomControls.RJControls.RJButton();
            DeleteBtn = new CustomControls.RJControls.RJButton();
            LblLicense = new Label();
            LblUsername = new Label();
            LblPhone = new Label();
            LblSalary = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem, tripsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 70);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // tripsToolStripMenuItem
            // 
            tripsToolStripMenuItem.Name = "tripsToolStripMenuItem";
            tripsToolStripMenuItem.Size = new Size(107, 22);
            tripsToolStripMenuItem.Text = "Trips";
            tripsToolStripMenuItem.Click += tripsToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(DeleteBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(685, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 43);
            panel1.TabIndex = 5;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(255, 128, 0);
            EditBtn.BackgroundColor = Color.FromArgb(255, 128, 0);
            EditBtn.BorderColor = Color.PaleVioletRed;
            EditBtn.BorderRadius = 4;
            EditBtn.BorderSize = 0;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(33, 9);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(56, 25);
            EditBtn.TabIndex = 1;
            EditBtn.Text = "Edit";
            EditBtn.TextColor = Color.White;
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(192, 0, 0);
            DeleteBtn.BackgroundColor = Color.FromArgb(192, 0, 0);
            DeleteBtn.BorderColor = Color.PaleVioletRed;
            DeleteBtn.BorderRadius = 4;
            DeleteBtn.BorderSize = 0;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(95, 9);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(56, 25);
            DeleteBtn.TabIndex = 0;
            DeleteBtn.Text = "Delete";
            DeleteBtn.TextColor = Color.White;
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // LblLicense
            // 
            LblLicense.AutoSize = true;
            LblLicense.BackColor = Color.Transparent;
            LblLicense.Dock = DockStyle.Fill;
            LblLicense.Location = new Point(3, 0);
            LblLicense.Name = "LblLicense";
            LblLicense.Size = new Size(147, 49);
            LblLicense.TabIndex = 0;
            LblLicense.Text = "Licenece";
            LblLicense.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.BackColor = Color.Transparent;
            LblUsername.Dock = DockStyle.Fill;
            LblUsername.Location = new Point(156, 0);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(231, 49);
            LblUsername.TabIndex = 1;
            LblUsername.Text = "Username";
            LblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.BackColor = Color.Transparent;
            LblPhone.Dock = DockStyle.Fill;
            LblPhone.Location = new Point(393, 0);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(147, 49);
            LblPhone.TabIndex = 2;
            LblPhone.Text = "Phone";
            LblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblSalary
            // 
            LblSalary.AutoSize = true;
            LblSalary.BackColor = Color.Transparent;
            LblSalary.Dock = DockStyle.Fill;
            LblSalary.Location = new Point(546, 0);
            LblSalary.Name = "LblSalary";
            LblSalary.Size = new Size(133, 49);
            LblSalary.TabIndex = 4;
            LblSalary.Text = "Salary";
            LblSalary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.87086F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6274567F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.87086F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.25805F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.37278F));
            tableLayoutPanel1.Controls.Add(LblSalary, 3, 0);
            tableLayoutPanel1.Controls.Add(LblPhone, 2, 0);
            tableLayoutPanel1.Controls.Add(LblUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(LblLicense, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 4, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.ForeColor = Color.Black;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(860, 49);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // UCDriver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(tableLayoutPanel1);
            Name = "UCDriver";
            Size = new Size(860, 49);
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private CustomControls.RJControls.RJButton EditBtn;
        private CustomControls.RJControls.RJButton DeleteBtn;
        private Label LblLicense;
        private Label LblUsername;
        private Label LblPhone;
        private Label LblSalary;
        private ToolStripMenuItem tripsToolStripMenuItem;
        public Panel panel1;
        public TableLayoutPanel tableLayoutPanel1;
    }
}
