namespace PasswordManager
{
    public partial class PasswordManager : Form
    {
        public PasswordManager()
        {
            InitializeComponent();
        }

        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextbox.PasswordChar = '\0';

        }

        private void showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextbox.PasswordChar = '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginBtn.Enabled = false;
            if (usernameTextbox.Text == "anirbanc" && passwordTextbox.Text == "qwerty123")
            {
                System.Threading.Thread.Sleep(4000);
                actionMessageLbl.Text = "Login Successful. Please Wait!";
            }else if (usernameTextbox.Text != "" || passwordTextbox.Text != "")
            {
                System.Threading.Thread.Sleep(4000);
                actionMessageLbl.Text = "Access Denied. Try Again.";
                usernameTextbox.Text = "";
                passwordTextbox.Text = "";
                loginBtn.Enabled = true;
                usernameTextbox.Focus();
            } else if (usernameTextbox.Text == "" || usernameTextbox.Text == "")
            {
                System.Threading.Thread.Sleep(4000);
                actionMessageLbl.Text = "Invalid Credentials. Try Again.";
                usernameTextbox.Text = "";
                passwordTextbox.Text = "";
                loginBtn.Enabled = true;
                usernameTextbox.Focus();
            }
        }
    }
}