namespace StudentskaSluzba
{
    partial class FrmNewSubject
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
            dgvSubjects = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtCode = new TextBox();
            label3 = new Label();
            cboxProfessor = new ComboBox();
            label4 = new Label();
            numEspb = new NumericUpDown();
            button1 = new Button();
            txtName = new TextBox();
            label5 = new Label();
            txtId = new TextBox();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEspb).BeginInit();
            SuspendLayout();
            // 
            // dgvSubjects
            // 
            dgvSubjects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(282, 12);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.ReadOnly = true;
            dgvSubjects.RowHeadersWidth = 51;
            dgvSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubjects.Size = new Size(546, 488);
            dgvSubjects.TabIndex = 0;
            dgvSubjects.SelectionChanged += dgvSubjects_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 152);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 217);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 4;
            label2.Text = "Kod";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(12, 240);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(247, 27);
            txtCode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 288);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "ESPB";
            // 
            // cboxProfessor
            // 
            cboxProfessor.FormattingEnabled = true;
            cboxProfessor.Location = new Point(12, 57);
            cboxProfessor.Name = "cboxProfessor";
            cboxProfessor.Size = new Size(247, 28);
            cboxProfessor.TabIndex = 7;
            cboxProfessor.SelectedIndexChanged += cboxProfessor_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 34);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 8;
            label4.Text = "Profesor";
            // 
            // numEspb
            // 
            numEspb.Location = new Point(12, 311);
            numEspb.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numEspb.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numEspb.Name = "numEspb";
            numEspb.Size = new Size(247, 27);
            numEspb.TabIndex = 9;
            numEspb.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(12, 364);
            button1.Name = "button1";
            button1.Size = new Size(247, 40);
            button1.TabIndex = 10;
            button1.Text = "Kreiraj predmet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 175);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 27);
            txtName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 91);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 12;
            label5.Text = "Sifra";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 114);
            txtId.Name = "txtId";
            txtId.Size = new Size(247, 27);
            txtId.TabIndex = 13;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 128, 128);
            btnRemove.ForeColor = SystemColors.ControlText;
            btnRemove.Location = new Point(12, 459);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(247, 41);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Ukloni predmet";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // FrmNewSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 512);
            Controls.Add(btnRemove);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(button1);
            Controls.Add(numEspb);
            Controls.Add(label4);
            Controls.Add(cboxProfessor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Controls.Add(dgvSubjects);
            Name = "FrmNewSubject";
            Text = "FrmNewSubject";
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEspb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSubjects;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox txtCode;
        private Label label3;
        private TextBox textBox3;
        private ComboBox cboxProfessor;
        private Label label4;
        private NumericUpDown numEspb;
        private Button button1;
        private TextBox txtName;
        private Label label5;
        private TextBox txtId;
        private Button btnRemove;
    }
}