namespace StudentskaSluzba
{
    partial class FrmGlavna
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
            menuStrip1 = new MenuStrip();
            profesorToolStripMenuItem = new ToolStripMenuItem();
            noviProfesorToolStripMenuItem = new ToolStripMenuItem();
            predmetiToolStripMenuItem = new ToolStripMenuItem();
            prikaziPredmeteToolStripMenuItem = new ToolStripMenuItem();
            noviPredmetToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profesorToolStripMenuItem, predmetiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // profesorToolStripMenuItem
            // 
            profesorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noviProfesorToolStripMenuItem });
            profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            profesorToolStripMenuItem.Size = new Size(78, 24);
            profesorToolStripMenuItem.Text = "Profesor";
            profesorToolStripMenuItem.Click += profesorToolStripMenuItem_Click;
            // 
            // noviProfesorToolStripMenuItem
            // 
            noviProfesorToolStripMenuItem.Name = "noviProfesorToolStripMenuItem";
            noviProfesorToolStripMenuItem.Size = new Size(224, 26);
            noviProfesorToolStripMenuItem.Text = "Novi profesor";
            noviProfesorToolStripMenuItem.Click += noviProfesorToolStripMenuItem_Click;
            // 
            // predmetiToolStripMenuItem
            // 
            predmetiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prikaziPredmeteToolStripMenuItem, noviPredmetToolStripMenuItem });
            predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            predmetiToolStripMenuItem.Size = new Size(83, 24);
            predmetiToolStripMenuItem.Text = "Predmeti";
            // 
            // prikaziPredmeteToolStripMenuItem
            // 
            prikaziPredmeteToolStripMenuItem.Name = "prikaziPredmeteToolStripMenuItem";
            prikaziPredmeteToolStripMenuItem.Size = new Size(224, 26);
            prikaziPredmeteToolStripMenuItem.Text = "Prikazi predmete";
            // 
            // noviPredmetToolStripMenuItem
            // 
            noviPredmetToolStripMenuItem.Name = "noviPredmetToolStripMenuItem";
            noviPredmetToolStripMenuItem.Size = new Size(224, 26);
            noviPredmetToolStripMenuItem.Text = "Novi predmet";
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmGlavna";
            Text = "FrmGlavna";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem profesorToolStripMenuItem;
        private ToolStripMenuItem noviProfesorToolStripMenuItem;
        private ToolStripMenuItem predmetiToolStripMenuItem;
        private ToolStripMenuItem prikaziPredmeteToolStripMenuItem;
        private ToolStripMenuItem noviPredmetToolStripMenuItem;
    }
}