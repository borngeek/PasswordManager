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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("google");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("yahoo");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("facebook");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("microsoft");
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginGroupbox = new System.Windows.Forms.GroupBox();
            this.showPassword = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.accountTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.actionMessageLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.loginGroupbox.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextbox.Location = new System.Drawing.Point(304, 22);
            this.usernameTextbox.MaxLength = 63;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PlaceholderText = "Username";
            this.usernameTextbox.Size = new System.Drawing.Size(176, 39);
            this.usernameTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextbox.Location = new System.Drawing.Point(304, 71);
            this.passwordTextbox.MaxLength = 63;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.PlaceholderText = "Password";
            this.passwordTextbox.Size = new System.Drawing.Size(176, 39);
            this.passwordTextbox.TabIndex = 1;
            // 
            // loginGroupbox
            // 
            this.loginGroupbox.Controls.Add(this.showPassword);
            this.loginGroupbox.Controls.Add(this.loginBtn);
            this.loginGroupbox.Controls.Add(this.usernameTextbox);
            this.loginGroupbox.Controls.Add(this.passwordTextbox);
            this.loginGroupbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginGroupbox.Location = new System.Drawing.Point(0, 0);
            this.loginGroupbox.Name = "loginGroupbox";
            this.loginGroupbox.Size = new System.Drawing.Size(768, 168);
            this.loginGroupbox.TabIndex = 0;
            this.loginGroupbox.TabStop = false;
            this.loginGroupbox.Text = "Login";
            // 
            // showPassword
            // 
            this.showPassword.Image = global::PasswordManager.Properties.Resources.eyecon_32;
            this.showPassword.Location = new System.Drawing.Point(483, 70);
            this.showPassword.Margin = new System.Windows.Forms.Padding(0);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(40, 40);
            this.showPassword.TabIndex = 3;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Leave += new System.EventHandler(this.showPassword_Leave);
            this.showPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassword_MouseDown);
            this.showPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPassword_MouseUp);
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(304, 116);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(176, 40);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
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
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 446);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(768, 27);
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
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 168);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(768, 278);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.LargeImageList = this.accountTypeImageList;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 473);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.loginGroupbox);
            this.Name = "PasswordManager";
            this.Text = "PasswordManager";
            this.loginGroupbox.ResumeLayout(false);
            this.loginGroupbox.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private GroupBox loginGroupbox;
        private Button loginBtn;
        private Button showPassword;
        private ImageList accountTypeImageList;
        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel actionMessageLbl;
        private ToolStripProgressBar StatusStripProgressBar;
        private SplitContainer splitContainer1;
        private ListView listView1;
    }
}