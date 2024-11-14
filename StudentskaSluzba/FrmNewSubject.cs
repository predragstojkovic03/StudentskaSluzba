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
    public partial class FrmNewSubject : Form
    {
        ProfessorsService _professorsService;
        SubjectsService _subjectsService;

        BindingList<Professor> _professors;
        BindingList<Subject> _subjects;

        public FrmNewSubject()
        {
            _professorsService = new ProfessorsService();
            _subjectsService = new SubjectsService();

            InitializeComponent();

            _professors = new BindingList<Professor>(_professorsService.FindAll());

            cboxProfessor.DataSource = _professors;
            cboxProfessor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxProfessor.DisplayMember = "FullName";
            cboxProfessor.ValueMember = "Id";

            LoadSubjects();
            dgvSubjects.Columns["Professor"].Visible = false;
        }

        private bool IsValid()
        {
            var result = true;

            int temp;
            if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out temp))
            {
                result = false;
                txtId.BackColor = Color.Red;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                result = false;
                txtName.BackColor = Color.Red;
            }

            if (string.IsNullOrEmpty(txtCode.Text))
            {
                result = false;
                txtCode.BackColor = Color.Red;
            }

            return result;
        }

        private void LoadSubjects()
        {
            Professor selected = (Professor)cboxProfessor.SelectedItem;
            _subjects = new BindingList<Subject>(_subjectsService.FindByProfessor(selected.Id));
            dgvSubjects.DataSource = _subjects;

            button1.Enabled = _subjects.Count < 3;
        }

        private void cboxProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professor selected = (Professor)cboxProfessor.SelectedItem;

            Subject subject = _subjectsService.CreateSubject(
                long.Parse(txtId.Text), txtName.Text, txtCode.Text, (int)numEspb.Value, selected);

            LoadSubjects();

            button1.Enabled = _subjects.Count < 3;
        }

        private void dgvSubjects_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            long selected = (long)dgvSubjects.SelectedRows[0].Cells[0].Value;
            _subjectsService.Remove(selected);

            LoadSubjects();
        }
    }
}
