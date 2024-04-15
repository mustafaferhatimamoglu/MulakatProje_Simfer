namespace MulakatProje_Simfer
{
    partial class Form_Education
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            TB_SchoolName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            TB_SchoolCity = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            TB_StartYear = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            TB_EndYear = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            TB_Type = new TextBox();
            label5 = new Label();
            Button_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 364);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(TB_SchoolName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 29);
            panel1.TabIndex = 1;
            // 
            // TB_SchoolName
            // 
            TB_SchoolName.Location = new Point(91, 3);
            TB_SchoolName.MaxLength = 20;
            TB_SchoolName.Name = "TB_SchoolName";
            TB_SchoolName.Size = new Size(134, 23);
            TB_SchoolName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "School Name:";
            // 
            // panel2
            // 
            panel2.Controls.Add(TB_SchoolCity);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 29);
            panel2.TabIndex = 2;
            // 
            // TB_SchoolCity
            // 
            TB_SchoolCity.Location = new Point(91, 3);
            TB_SchoolCity.MaxLength = 20;
            TB_SchoolCity.Name = "TB_SchoolCity";
            TB_SchoolCity.Size = new Size(134, 23);
            TB_SchoolCity.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 0;
            label2.Text = "School City:";
            // 
            // panel3
            // 
            panel3.Controls.Add(TB_StartYear);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(251, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 29);
            panel3.TabIndex = 2;
            // 
            // TB_StartYear
            // 
            TB_StartYear.Location = new Point(91, 3);
            TB_StartYear.Name = "TB_StartYear";
            TB_StartYear.Size = new Size(134, 23);
            TB_StartYear.TabIndex = 1;
            TB_StartYear.KeyPress += TB_StartYear_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Start Year:";
            // 
            // panel4
            // 
            panel4.Controls.Add(TB_EndYear);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(251, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 29);
            panel4.TabIndex = 2;
            // 
            // TB_EndYear
            // 
            TB_EndYear.Location = new Point(91, 3);
            TB_EndYear.Name = "TB_EndYear";
            TB_EndYear.Size = new Size(134, 23);
            TB_EndYear.TabIndex = 1;
            TB_EndYear.KeyPress += TB_EndYear_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 0;
            label4.Text = "End Year";
            // 
            // panel5
            // 
            panel5.Controls.Add(TB_Type);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(485, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(228, 29);
            panel5.TabIndex = 3;
            // 
            // TB_Type
            // 
            TB_Type.Location = new Point(91, 3);
            TB_Type.MaxLength = 20;
            TB_Type.Name = "TB_Type";
            TB_Type.Size = new Size(134, 23);
            TB_Type.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 0;
            label5.Text = "Type:";
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(486, 47);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(227, 29);
            Button_Add.TabIndex = 4;
            Button_Add.Text = "Add";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // Form_Education
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Add);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form_Education";
            Text = "Form_Education";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox TB_SchoolName;
        private Label label1;
        private Panel panel2;
        private TextBox TB_SchoolCity;
        private Label label2;
        private Panel panel3;
        private TextBox TB_StartYear;
        private Label label3;
        private Panel panel4;
        private TextBox TB_EndYear;
        private Label label4;
        private Panel panel5;
        private TextBox TB_Type;
        private Label label5;
        private Button Button_Add;
    }
}