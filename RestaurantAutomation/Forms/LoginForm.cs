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

        public bool LoginSuccessful { get; private set; } = false;

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

                    LoginSuccessful = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password or Role is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Check if selected role is "admin"
                var selectedRole = _roleService.GetByID((Guid)cmbRoles.SelectedValue);

                if (selectedRole.Name == "admin" && _userService.IfEntityExists(x => x.RoleID == selectedRole.ID))
                {
                    MessageBox.Show("Admin accounts can only be created by an existing admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // clear the fields
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    cmbRoles.SelectedIndex = -1;
                    return;
                }

                // Create new user 
                var newUser = new User
                {
                    ID = Guid.NewGuid(),
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    RoleID = (Guid)cmbRoles.SelectedValue
                };

                _userService.Create(newUser);


                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Store the logged-in user
                SessionManager.LoggedInUser = user;
                LoginSuccessful = true;
                this.Close();
            }
        }



    }
}
