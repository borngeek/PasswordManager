namespace PasswordManager
{
    partial class PasswordManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loginGroupbox = new System.Windows.Forms.GroupBox();
            this.showPassword = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.accountTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.actionMessageLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDomainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginGroupbox.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupbox
            // 
            this.loginGroupbox.Controls.Add(this.showPassword);
            this.loginGroupbox.Controls.Add(this.loginBtn);
            this.loginGroupbox.Controls.Add(this.usernameTextbox);
            this.loginGroupbox.Controls.Add(this.passwordTextbox);
            this.loginGroupbox.Location = new System.Drawing.Point(260, 120);
            this.loginGroupbox.Name = "loginGroupbox";
            this.loginGroupbox.Size = new System.Drawing.Size(240, 160);
            this.loginGroupbox.TabIndex = 0;
            this.loginGroupbox.TabStop = false;
            this.loginGroupbox.Text = "Login";
            // 
            // showPassword
            // 
            this.showPassword.Image = global::PasswordManager.Properties.Resources.eyecon_32;
            this.showPassword.Location = new System.Drawing.Point(195, 67);
            this.showPassword.Margin = new System.Windows.Forms.Padding(0);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(40, 40);
            this.showPassword.TabIndex = 7;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseDown);
            this.showPassword.MouseLeave += new System.EventHandler(this.ShowPassword_Leave);
            this.showPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseUp);
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(12, 112);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(180, 40);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            this.loginBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginBtn_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextbox.Location = new System.Drawing.Point(12, 22);
            this.usernameTextbox.MaxLength = 63;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PlaceholderText = "Username";
            this.usernameTextbox.Size = new System.Drawing.Size(180, 39);
            this.usernameTextbox.TabIndex = 4;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextbox.Location = new System.Drawing.Point(12, 67);
            this.passwordTextbox.MaxLength = 63;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.PlaceholderText = "Password";
            this.passwordTextbox.Size = new System.Drawing.Size(180, 39);
            this.passwordTextbox.TabIndex = 5;
            // 
            // accountTypeImageList
            // 
            this.accountTypeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.accountTypeImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.accountTypeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionMessageLbl,
            this.StatusStripProgressBar});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 434);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(784, 27);
            this.MainStatusStrip.TabIndex = 4;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // actionMessageLbl
            // 
            this.actionMessageLbl.Margin = new System.Windows.Forms.Padding(3);
            this.actionMessageLbl.Name = "actionMessageLbl";
            this.actionMessageLbl.Padding = new System.Windows.Forms.Padding(3);
            this.actionMessageLbl.Size = new System.Drawing.Size(180, 21);
            this.actionMessageLbl.Text = "Welcome to PasswordManager!";
            // 
            // StatusStripProgressBar
            // 
            this.StatusStripProgressBar.Name = "StatusStripProgressBar";
            this.StatusStripProgressBar.Size = new System.Drawing.Size(100, 21);
            this.StatusStripProgressBar.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(781, 392);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(254, 379);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.VisibleChanged += new System.EventHandler(this.ListView1_VisibleChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(509, 379);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDomainToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addDomainToolStripMenuItem
            // 
            this.addDomainToolStripMenuItem.Name = "addDomainToolStripMenuItem";
            this.addDomainToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addDomainToolStripMenuItem.Text = "Add Domain";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedbackToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.loginGroupbox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PasswordManager";
            this.Text = "PasswordManager";
            this.loginGroupbox.ResumeLayout(false);
            this.loginGroupbox.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox loginGroupbox;
        private ImageList accountTypeImageList;
        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel actionMessageLbl;
        private ToolStripProgressBar StatusStripProgressBar;
        private Button showPassword;
        private Button loginBtn;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private SplitContainer splitContainer1;
        private ListView listView1;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addDomainToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem feedbackToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}