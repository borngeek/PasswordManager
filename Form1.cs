namespace PasswordManager
{
    public partial class PasswordManager : Form
    {
        public PasswordManager()
        {
            InitializeComponent();
            loginGroupbox.Visible = true;
        }

        private void ShowPassword_Leave(object sender, EventArgs e)
        {
            passwordTextbox.PasswordChar = '*';
        }

        private void ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextbox.PasswordChar = '\0';

        }

        private void ShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextbox.PasswordChar = '*';
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            loginBtn.Enabled = false;
            System.Threading.Thread.Sleep(4000);
            if (usernameTextbox.Text == "anirbanc" && passwordTextbox.Text == "qwerty123")
            {
                actionMessageLbl.Text = "Login Successful. Please Wait!";
                loginGroupbox.Visible=false;
            }
            else if (usernameTextbox.Text != "" || passwordTextbox.Text != "")
            {   
                actionMessageLbl.Text = "Access Denied. Try Again.";
                usernameTextbox.Text = "";
                passwordTextbox.Text = "";
                loginBtn.Enabled = true;
                usernameTextbox.Focus();
            } else if (usernameTextbox.Text == "" || usernameTextbox.Text == "")
            {
                actionMessageLbl.Text = "Invalid Credentials. Try Again.";
                usernameTextbox.Text = "";
                passwordTextbox.Text = "";
                loginBtn.Enabled = true;
                usernameTextbox.Focus();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutDialog = new();
            AboutDialog.Size = new Size(400, 500);
            AboutDialog.Text = "About PasswordManager";
            Label AboutLbl = new Label();
            AboutLbl.Dock = DockStyle.Fill;
            AboutLbl.Text = "A Product of\nRamakrishna Mission Vidyamandira, Belurmath";
            AboutLbl.TextAlign = ContentAlignment.MiddleCenter;
            Button AboutOkBtn = new Button();
            AboutOkBtn.Dock = DockStyle.Bottom;
            AboutOkBtn.Text = "OK";
            AboutDialog.Controls.Add(AboutLbl);
            AboutDialog.Controls.Add(AboutOkBtn);
            
            AboutDialog.Visible = true;
            AboutDialog.Show();
        }
    }
}