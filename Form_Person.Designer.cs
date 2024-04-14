namespace MulakatProje_Simfer
{
    partial class Form_Person
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Button_EditEducations = new Button();
            Button_Partner = new Button();
            LB_Educations = new ListBox();
            Button_Selected = new Button();
            Button_Parent2 = new Button();
            Button_Parent1 = new Button();
            LB_Children = new ListBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(Button_EditEducations, 6, 2);
            tableLayoutPanel1.Controls.Add(Button_Partner, 2, 2);
            tableLayoutPanel1.Controls.Add(LB_Educations, 6, 3);
            tableLayoutPanel1.Controls.Add(Button_Selected, 4, 2);
            tableLayoutPanel1.Controls.Add(Button_Parent2, 7, 1);
            tableLayoutPanel1.Controls.Add(Button_Parent1, 1, 1);
            tableLayoutPanel1.Controls.Add(LB_Children, 2, 3);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Button_EditEducations
            // 
            tableLayoutPanel1.SetColumnSpan(Button_EditEducations, 2);
            Button_EditEducations.Dock = DockStyle.Fill;
            Button_EditEducations.Location = new Point(498, 74);
            Button_EditEducations.Name = "Button_EditEducations";
            Button_EditEducations.Size = new Size(184, 45);
            Button_EditEducations.TabIndex = 6;
            Button_EditEducations.Text = "Edit Educations";
            Button_EditEducations.UseVisualStyleBackColor = true;
            Button_EditEducations.Click += Button_EditEducations_Click;
            // 
            // Button_Partner
            // 
            tableLayoutPanel1.SetColumnSpan(Button_Partner, 2);
            Button_Partner.Dock = DockStyle.Fill;
            Button_Partner.Location = new Point(118, 74);
            Button_Partner.Name = "Button_Partner";
            Button_Partner.Size = new Size(184, 45);
            Button_Partner.TabIndex = 5;
            Button_Partner.Text = "Partner";
            Button_Partner.UseVisualStyleBackColor = true;
            Button_Partner.Click += Button_Partner_Click;
            // 
            // LB_Educations
            // 
            tableLayoutPanel1.SetColumnSpan(LB_Educations, 3);
            LB_Educations.Dock = DockStyle.Fill;
            LB_Educations.FormattingEnabled = true;
            LB_Educations.ItemHeight = 15;
            LB_Educations.Location = new Point(498, 125);
            LB_Educations.Name = "LB_Educations";
            tableLayoutPanel1.SetRowSpan(LB_Educations, 3);
            LB_Educations.Size = new Size(279, 147);
            LB_Educations.TabIndex = 4;
            LB_Educations.SelectedIndexChanged += LB_Educations_SelectedIndexChanged;
            // 
            // Button_Selected
            // 
            tableLayoutPanel1.SetColumnSpan(Button_Selected, 2);
            Button_Selected.Dock = DockStyle.Fill;
            Button_Selected.Location = new Point(308, 74);
            Button_Selected.Name = "Button_Selected";
            Button_Selected.Size = new Size(184, 45);
            Button_Selected.TabIndex = 2;
            Button_Selected.UseVisualStyleBackColor = true;
            // 
            // Button_Parent2
            // 
            tableLayoutPanel1.SetColumnSpan(Button_Parent2, 2);
            Button_Parent2.Dock = DockStyle.Fill;
            Button_Parent2.Location = new Point(593, 23);
            Button_Parent2.Name = "Button_Parent2";
            Button_Parent2.Size = new Size(184, 45);
            Button_Parent2.TabIndex = 1;
            Button_Parent2.Text = "Parent2";
            Button_Parent2.UseVisualStyleBackColor = true;
            Button_Parent2.Click += Button_Parent2_Click;
            // 
            // Button_Parent1
            // 
            tableLayoutPanel1.SetColumnSpan(Button_Parent1, 2);
            Button_Parent1.Dock = DockStyle.Fill;
            Button_Parent1.Location = new Point(23, 23);
            Button_Parent1.Name = "Button_Parent1";
            Button_Parent1.Size = new Size(184, 45);
            Button_Parent1.TabIndex = 0;
            Button_Parent1.Text = "Parent1";
            Button_Parent1.UseVisualStyleBackColor = true;
            Button_Parent1.Click += Button_Parent1_Click;
            // 
            // LB_Children
            // 
            tableLayoutPanel1.SetColumnSpan(LB_Children, 3);
            LB_Children.Dock = DockStyle.Fill;
            LB_Children.FormattingEnabled = true;
            LB_Children.ItemHeight = 15;
            LB_Children.Location = new Point(118, 125);
            LB_Children.Name = "LB_Children";
            tableLayoutPanel1.SetRowSpan(LB_Children, 3);
            LB_Children.Size = new Size(279, 147);
            LB_Children.TabIndex = 3;
            LB_Children.SelectedIndexChanged += LB_Children_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 8);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(23, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 4);
            dataGridView1.Size = new Size(754, 169);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Form_Person
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form_Person";
            Text = "Form_Person";
            FormClosed += Form_Person_FormClosed;
            Load += Form_Person_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Button_Parent2;
        private Button Button_Parent1;
        private Button Button_Selected;
        private ListBox LB_Children;
        private Button Button_EditEducations;
        private Button Button_Partner;
        private ListBox LB_Educations;
        private DataGridView dataGridView1;
    }
}