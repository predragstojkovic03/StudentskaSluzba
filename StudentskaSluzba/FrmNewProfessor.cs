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

            _professors = new BindingList<Professor>(_professorsService.FindAll());

            cboxTitle.DataSource = Enum.GetValues(typeof(ProfessorTitle));
            dgvProfessors.DataSource = _professors;
            dgvProfessors.Columns["Id"].Visible = false;
            cboxTitle.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool IsValid()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                isValid = false;
                txtFirstName.BackColor = Color.Red;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            { 
               isValid = false; 
                txtLastName.BackColor = Color.Red;
            }

            return isValid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            var professor = _professorsService.CreateProfessor(
                txtFirstName.Text,
                txtLastName.Text,
                (ProfessorTitle) cboxTitle.SelectedValue,
                _user.Email
             );

            ClearForm();
            
            _professors.Add(professor);
        }

        private void ClearForm()
        {
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
        }
    }
}
