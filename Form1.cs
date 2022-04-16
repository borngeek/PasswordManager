namespace PasswordManager
{
    public partial class PasswordManager : Form
    {
        public PasswordManager()
        {
            InitializeComponent();
        }

        private void populateAccountPanel() {
            Graphics g = Graphics.FromHwnd(this.Handle);
            ImageList photoList = new ImageList();
            photoList.TransparentColor = Color.Blue;
            photoList.ColorDepth = ColorDepth.Depth32Bit;
            photoList.ImageSize = new Size(200, 200);
            photoList.Images.Add(Image.FromFile(@"C:\Images\Garden.jpg"));
            for (int count = 0; count < photoList.Images.Count; count++)
            {
                photoList.Draw(g, new Point(20, 20), count);
                // Paint the form and wait to load the image
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);

            }
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
            System.Threading.Thread.Sleep(4000);
            if (usernameTextbox.Text == "anirbanc" && passwordTextbox.Text == "qwerty123")
            {
                actionMessageLbl.Text = "Login Successful. Please Wait!";
            }else if (usernameTextbox.Text != "" || passwordTextbox.Text != "")
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

        private void showPassword_Leave(object sender, EventArgs e)
        {
            passwordTextbox.PasswordChar = '*';
        }

        
    }
}