namespace StudentskaSluzba
{
    partial class FrmNewProfessor
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
            dgvProfessors = new DataGridView();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblPrezime = new Label();
            cboxTitle = new ComboBox();
            label3 = new Label();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfessors).BeginInit();
            SuspendLayout();
            // 
            // dgvProfessors
            // 
            dgvProfessors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProfessors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfessors.Location = new Point(274, 12);
            dgvProfessors.Name = "dgvProfessors";
            dgvProfessors.ReadOnly = true;
            dgvProfessors.RowHeadersWidth = 51;
            dgvProfessors.Size = new Size(548, 536);
            dgvProfessors.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = "Ime";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(237, 27);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(237, 27);
            txtLastName.TabIndex = 4;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(12, 86);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(62, 20);
            lblPrezime.TabIndex = 3;
            lblPrezime.Text = "Prezime";
            // 
            // cboxTitle
            // 
            cboxTitle.FormattingEnabled = true;
            cboxTitle.Location = new Point(12, 190);
            cboxTitle.Name = "cboxTitle";
            cboxTitle.Size = new Size(237, 28);
            cboxTitle.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 6;
            label3.Text = "Zvanje";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 252);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(237, 39);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Kreiraj profesora";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmNewProfessor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 560);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(cboxTitle);
            Controls.Add(txtLastName);
            Controls.Add(lblPrezime);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(dgvProfessors);
            Name = "FrmNewProfessor";
            Text = "Unesi profesora";
            ((System.ComponentModel.ISupportInitialize)dgvProfessors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProfessors;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblPrezime;
        private ComboBox cboxTitle;
        private Label label3;
        private Button btnCreate;
    }
}