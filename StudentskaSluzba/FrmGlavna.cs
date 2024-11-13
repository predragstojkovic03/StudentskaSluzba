using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzba
{
    public partial class FrmGlavna : Form
    {
        private User _user;

        public FrmGlavna(User user)
        {
            InitializeComponent();

            _user = user;
            Text = user.FirstName + " " + user.LastName;
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void noviProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FrmNewProfessor(_user).ShowDialog();
            Visible = true;
        }
    }
}
