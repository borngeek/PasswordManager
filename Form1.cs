using System.Xml;

namespace PasswordManager
{
    public partial class PasswordManager : Form
    {
        readonly string secretKey = "RpP6YWfduAzRY9gwDOuxOLD03e6ijANcvHElTRvvv6YsSE5wKVaWdyl2SkeWaWx"; //To be Changed.
        public PasswordManager()
        {
            InitializeComponent();
            menuStrip1.Visible = false;
            splitContainer1.Visible = false;
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
                loginGroupbox.Visible = false;
                menuStrip1.Visible = true;
                splitContainer1.Visible = true;
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutDialog = new();
            AboutDialog.Size = new Size(400, 500);
            AboutDialog.Text = "About PasswordManager";
            Label AboutLbl = new();
            AboutLbl.Dock = DockStyle.Fill;
            AboutLbl.Text = "A Product of\nRamakrishna Mission Vidyamandira, Belurmath";
            AboutLbl.TextAlign = ContentAlignment.MiddleCenter;
            AboutDialog.Controls.Add(AboutLbl); 
            AboutDialog.Visible = true;
            AboutDialog.Show();
        }

        private void ListView1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) {
                XmlReader xReader = XmlReader.Create("C:\\Users\\FIST Lab - 09\\source\\repos\\PasswordManager\\Properties\\DataSources\\PasswordManagerDB.xml");
                String LastElement = "";
                while (xReader.Read())
                {   
                    if (xReader.NodeType == XmlNodeType.Element) 
                    {
                    } else if (xReader.NodeType == XmlNodeType.Text && LastElement == "site-name")
                    {
                        listView1.Items.Add(xReader.Value);
                    } else if (xReader.NodeType == XmlNodeType.EndElement) 
                    { 
                    }
                    LastElement = xReader.Name;
                }
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                actionMessageLbl.Text = listView1.SelectedItems[0].Text;
                listBox1.Items.Clear();
                XmlReader xReader = XmlReader.Create("C:\\Users\\FIST Lab - 09\\source\\repos\\PasswordManager\\Properties\\DataSources\\PasswordManagerDB.xml");
                String LastElement = "";
                while (xReader.Read())
                {
                    if (xReader.NodeType == XmlNodeType.Element)
                    {
                    }
                    else if (xReader.NodeType == XmlNodeType.Text && LastElement == "site-logo" && xReader.Value == listView1.SelectedItems[0].Text)
                    {
                        listBox1.Items.Add(xReader.Value);
                    }
                    else if (xReader.NodeType == XmlNodeType.EndElement)
                    {
                    }
                    LastElement = xReader.Name;
                }
            }
        }
    }
}