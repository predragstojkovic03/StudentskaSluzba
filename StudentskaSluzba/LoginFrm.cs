using BusinessLogic;

namespace StudentskaSluzba
{
    public partial class LoginFrm : Form
    {
        private UsersService _usersService;
        private int _authTries = 0;
        public LoginFrm()
        {
            _usersService = new UsersService();

            InitializeComponent();
        }

        private bool Valid()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                result = false;
                txtEmail.BackColor = Color.Red;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                result = false;
                txtPassword.BackColor = Color.Red;
            }

            return result;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validacija forme
            if (!Valid()) return;

            // Poziv login logike
            try
            {
                var user = _usersService.LoginUser(txtEmail.Text, txtPassword.Text);

                // Prebacivanje na glavnu formu
                this.Visible = false;
                new FrmGlavna(user).ShowDialog();
                this.Visible = true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Pogresan email ili lozinka.");

                if (_authTries >= 2)
                {
                    Application.Exit();
                    return;
                }

                _authTries++;
            }
        }
    }
}
