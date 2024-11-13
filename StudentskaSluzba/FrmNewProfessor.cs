using BusinessLogic;
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
    public partial class FrmNewProfessor : Form
    {
        private User _user;
        private ProfessorsService _professorsService;
        private BindingList<Professor> _professors;

        public FrmNewProfessor(User user)
        {
            InitializeComponent();

            _user = user;
            _professorsService = new ProfessorsService();

            _professors = _professorsService.FindAll();

            cboxTitle.DataSource = Enum.GetValues(typeof(ProfessorTitle));
            dgvProfessors.DataSource = _professors;
        }

        private bool IsValid()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            { 
               isValid = false; 
            }

            return isValid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var professor = _professorsService.CreateProfessor(
                txtFirstName.Text,
                txtLastName.Text,
                (ProfessorTitle) cboxTitle.SelectedValue,
                _user.Email
             );
            
            _professors.Add(professor);
        }
    }
}
