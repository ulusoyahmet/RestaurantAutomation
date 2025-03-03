using RestaurantAutomation.Business.Services;
using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.UI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext _context;

        private readonly RoleRepository _roleRepository;
        private readonly UserRepository _userRepository;

        private readonly RoleService _roleService;
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            _context = new AppDbContext();

            _roleRepository = new RoleRepository(_context);
            _userRepository = new UserRepository(_context);

            _roleService = new RoleService(_roleRepository);
            _userService = new UserService(_userRepository);
        }

        public static class SessionManager
        {
            public static User? LoggedInUser { get; set; }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            GetAllRoles();
        }

        private void GetAllRoles()
        {
            var data = _roleService.GetAll();

            if (data != null)
            {
                cmbRoles.DataSource = data;
                cmbRoles.DisplayMember = "Name";
                cmbRoles.ValueMember = "ID";
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var user = _userService.GetByUserName(txtUsername.Text);

            if (user != null)
            {
                if (user.Password == txtPassword.Text
                    && user.RoleID == (Guid)cmbRoles?.SelectedValue)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Store the logged-in user
                    SessionManager.LoggedInUser = user;

                    MainForm mainForm = new();
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Password or Role is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Check if the selected role is "Admin"
                var selectedRole = _roleService.GetByID((Guid)cmbRoles.SelectedValue);

                if (selectedRole.Name == "Admin")
                {
                    MessageBox.Show("Admin accounts can only be created by an existing admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create new user with non-admin role
                var newUser = new Entities.Models.User
                {
                    ID = Guid.NewGuid(),
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    RoleID = (Guid)cmbRoles.SelectedValue
                };

                _userService.Create(newUser);

                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // login
                MainForm mainForm = new();
                this.Hide();
                mainForm.Show();
            }
        }



    }
}
