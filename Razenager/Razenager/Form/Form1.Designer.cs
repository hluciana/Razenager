namespace Razenager
{
    partial class Razenager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label LB_Raze;
            System.Windows.Forms.Label LB_Mail;
            System.Windows.Forms.Label LB_Pass;
            System.Windows.Forms.Label LB_Browser;
            System.Windows.Forms.Label LB_Role;
            System.Windows.Forms.Panel PN_Credentials;
            System.Windows.Forms.Panel PN_Log;
            System.Windows.Forms.Label LB_Log;
            System.Windows.Forms.Panel PN_User;
            System.Windows.Forms.Label LB_User;
            System.Windows.Forms.Panel PN_ComingSoon;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Razenager));
            this.BTN_Browser = new System.Windows.Forms.Button();
            this.TB_Browser = new System.Windows.Forms.TextBox();
            this.BTN_Scrap = new System.Windows.Forms.Button();
            this.CB_Role = new System.Windows.Forms.ComboBox();
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.TB_Mail = new System.Windows.Forms.TextBox();
            this.BTN_DownloadLog = new System.Windows.Forms.Button();
            this.BTN_ClearLog = new System.Windows.Forms.Button();
            this.RTB_Log = new System.Windows.Forms.RichTextBox();
            this.BTN_ClearData = new System.Windows.Forms.Button();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.BTN_DownloadData = new System.Windows.Forms.Button();
            this.RTB_User = new System.Windows.Forms.RichTextBox();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialogBrowser = new System.Windows.Forms.OpenFileDialog();
            this.errorProviderConfig = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialogData = new System.Windows.Forms.SaveFileDialog();
            LB_Raze = new System.Windows.Forms.Label();
            LB_Mail = new System.Windows.Forms.Label();
            LB_Pass = new System.Windows.Forms.Label();
            LB_Browser = new System.Windows.Forms.Label();
            LB_Role = new System.Windows.Forms.Label();
            PN_Credentials = new System.Windows.Forms.Panel();
            PN_Log = new System.Windows.Forms.Panel();
            LB_Log = new System.Windows.Forms.Label();
            PN_User = new System.Windows.Forms.Panel();
            LB_User = new System.Windows.Forms.Label();
            PN_ComingSoon = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            PN_Credentials.SuspendLayout();
            PN_Log.SuspendLayout();
            PN_User.SuspendLayout();
            PN_ComingSoon.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Raze
            // 
            LB_Raze.AutoSize = true;
            LB_Raze.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Raze.ForeColor = System.Drawing.Color.White;
            LB_Raze.Location = new System.Drawing.Point(178, 3);
            LB_Raze.Name = "LB_Raze";
            LB_Raze.Size = new System.Drawing.Size(259, 77);
            LB_Raze.TabIndex = 0;
            LB_Raze.Text = "Razenager";
            // 
            // LB_Mail
            // 
            LB_Mail.AutoSize = true;
            LB_Mail.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Mail.Location = new System.Drawing.Point(17, 31);
            LB_Mail.Name = "LB_Mail";
            LB_Mail.Size = new System.Drawing.Size(55, 19);
            LB_Mail.TabIndex = 0;
            LB_Mail.Text = "Email:";
            // 
            // LB_Pass
            // 
            LB_Pass.AutoSize = true;
            LB_Pass.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Pass.Location = new System.Drawing.Point(17, 74);
            LB_Pass.Name = "LB_Pass";
            LB_Pass.Size = new System.Drawing.Size(48, 19);
            LB_Pass.TabIndex = 4;
            LB_Pass.Text = "Pass:";
            // 
            // LB_Browser
            // 
            LB_Browser.AutoSize = true;
            LB_Browser.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Browser.Location = new System.Drawing.Point(17, 160);
            LB_Browser.Name = "LB_Browser";
            LB_Browser.Size = new System.Drawing.Size(74, 19);
            LB_Browser.TabIndex = 5;
            LB_Browser.Text = "Browser:";
            // 
            // LB_Role
            // 
            LB_Role.AutoSize = true;
            LB_Role.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Role.Location = new System.Drawing.Point(17, 118);
            LB_Role.Name = "LB_Role";
            LB_Role.Size = new System.Drawing.Size(46, 19);
            LB_Role.TabIndex = 6;
            LB_Role.Text = "Role:";
            // 
            // PN_Credentials
            // 
            PN_Credentials.BackColor = System.Drawing.Color.WhiteSmoke;
            PN_Credentials.Controls.Add(this.BTN_Browser);
            PN_Credentials.Controls.Add(this.TB_Browser);
            PN_Credentials.Controls.Add(this.BTN_Scrap);
            PN_Credentials.Controls.Add(this.CB_Role);
            PN_Credentials.Controls.Add(LB_Role);
            PN_Credentials.Controls.Add(LB_Browser);
            PN_Credentials.Controls.Add(LB_Pass);
            PN_Credentials.Controls.Add(this.TB_Pass);
            PN_Credentials.Controls.Add(this.TB_Mail);
            PN_Credentials.Controls.Add(LB_Mail);
            PN_Credentials.Cursor = System.Windows.Forms.Cursors.Default;
            PN_Credentials.Location = new System.Drawing.Point(0, 0);
            PN_Credentials.Name = "PN_Credentials";
            PN_Credentials.Size = new System.Drawing.Size(272, 276);
            PN_Credentials.TabIndex = 1;
            // 
            // BTN_Browser
            // 
            this.BTN_Browser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Browser.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Browser.Location = new System.Drawing.Point(210, 161);
            this.BTN_Browser.Name = "BTN_Browser";
            this.BTN_Browser.Size = new System.Drawing.Size(32, 23);
            this.BTN_Browser.TabIndex = 10;
            this.BTN_Browser.Text = "...";
            this.BTN_Browser.UseVisualStyleBackColor = true;
            this.BTN_Browser.Click += new System.EventHandler(this.BTN_Browser_Click);
            // 
            // TB_Browser
            // 
            this.TB_Browser.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Browser.Location = new System.Drawing.Point(110, 161);
            this.TB_Browser.Name = "TB_Browser";
            this.TB_Browser.Size = new System.Drawing.Size(94, 23);
            this.TB_Browser.TabIndex = 8;
            // 
            // BTN_Scrap
            // 
            this.BTN_Scrap.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_Scrap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Scrap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_Scrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Scrap.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Scrap.Location = new System.Drawing.Point(21, 205);
            this.BTN_Scrap.Name = "BTN_Scrap";
            this.BTN_Scrap.Size = new System.Drawing.Size(221, 54);
            this.BTN_Scrap.TabIndex = 9;
            this.BTN_Scrap.Text = "SCRAP";
            this.BTN_Scrap.UseVisualStyleBackColor = false;
            this.BTN_Scrap.Click += new System.EventHandler(this.BTN_Scrap_Click);
            // 
            // CB_Role
            // 
            this.CB_Role.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Role.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Role.FormattingEnabled = true;
            this.CB_Role.Items.AddRange(new object[] {
            "student",
            "admin"});
            this.CB_Role.Location = new System.Drawing.Point(110, 116);
            this.CB_Role.Name = "CB_Role";
            this.CB_Role.Size = new System.Drawing.Size(132, 26);
            this.CB_Role.TabIndex = 7;
            // 
            // TB_Pass
            // 
            this.TB_Pass.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Pass.Location = new System.Drawing.Point(110, 72);
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.Size = new System.Drawing.Size(132, 23);
            this.TB_Pass.TabIndex = 2;
            // 
            // TB_Mail
            // 
            this.TB_Mail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Mail.Location = new System.Drawing.Point(110, 31);
            this.TB_Mail.Name = "TB_Mail";
            this.TB_Mail.Size = new System.Drawing.Size(132, 23);
            this.TB_Mail.TabIndex = 1;
            // 
            // PN_Log
            // 
            PN_Log.BackColor = System.Drawing.Color.DarkGray;
            PN_Log.Controls.Add(this.BTN_DownloadLog);
            PN_Log.Controls.Add(this.BTN_ClearLog);
            PN_Log.Controls.Add(LB_Log);
            PN_Log.Controls.Add(this.RTB_Log);
            PN_Log.Cursor = System.Windows.Forms.Cursors.Default;
            PN_Log.Location = new System.Drawing.Point(269, 0);
            PN_Log.Name = "PN_Log";
            PN_Log.Size = new System.Drawing.Size(274, 279);
            PN_Log.TabIndex = 2;
            // 
            // BTN_DownloadLog
            // 
            this.BTN_DownloadLog.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_DownloadLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DownloadLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_DownloadLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DownloadLog.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DownloadLog.Location = new System.Drawing.Point(26, 244);
            this.BTN_DownloadLog.Name = "BTN_DownloadLog";
            this.BTN_DownloadLog.Size = new System.Drawing.Size(112, 25);
            this.BTN_DownloadLog.TabIndex = 11;
            this.BTN_DownloadLog.Text = "download log";
            this.BTN_DownloadLog.UseVisualStyleBackColor = false;
            this.BTN_DownloadLog.Click += new System.EventHandler(this.BTN_DownloadLog_Click);
            // 
            // BTN_ClearLog
            // 
            this.BTN_ClearLog.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_ClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ClearLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_ClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClearLog.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearLog.Location = new System.Drawing.Point(154, 244);
            this.BTN_ClearLog.Name = "BTN_ClearLog";
            this.BTN_ClearLog.Size = new System.Drawing.Size(97, 25);
            this.BTN_ClearLog.TabIndex = 10;
            this.BTN_ClearLog.Text = "clear";
            this.BTN_ClearLog.UseVisualStyleBackColor = false;
            this.BTN_ClearLog.Click += new System.EventHandler(this.BTN_ClearLog_Click);
            // 
            // LB_Log
            // 
            LB_Log.AutoSize = true;
            LB_Log.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Log.Location = new System.Drawing.Point(122, 20);
            LB_Log.Name = "LB_Log";
            LB_Log.Size = new System.Drawing.Size(40, 19);
            LB_Log.TabIndex = 1;
            LB_Log.Text = "Log:";
            // 
            // RTB_Log
            // 
            this.RTB_Log.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Log.Location = new System.Drawing.Point(26, 51);
            this.RTB_Log.Name = "RTB_Log";
            this.RTB_Log.ReadOnly = true;
            this.RTB_Log.Size = new System.Drawing.Size(225, 187);
            this.RTB_Log.TabIndex = 0;
            this.RTB_Log.Text = "";
            // 
            // PN_User
            // 
            PN_User.BackColor = System.Drawing.Color.DarkSeaGreen;
            PN_User.Controls.Add(this.BTN_ClearData);
            PN_User.Controls.Add(this.CB_Type);
            PN_User.Controls.Add(this.BTN_DownloadData);
            PN_User.Controls.Add(LB_User);
            PN_User.Controls.Add(this.RTB_User);
            PN_User.Location = new System.Drawing.Point(0, 0);
            PN_User.Name = "PN_User";
            PN_User.Size = new System.Drawing.Size(421, 275);
            PN_User.TabIndex = 2;
            // 
            // BTN_ClearData
            // 
            this.BTN_ClearData.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_ClearData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ClearData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_ClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClearData.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearData.Location = new System.Drawing.Point(297, 52);
            this.BTN_ClearData.Name = "BTN_ClearData";
            this.BTN_ClearData.Size = new System.Drawing.Size(109, 43);
            this.BTN_ClearData.TabIndex = 12;
            this.BTN_ClearData.Text = "CLEAR";
            this.BTN_ClearData.UseVisualStyleBackColor = false;
            this.BTN_ClearData.Click += new System.EventHandler(this.BTN_ClearData_Click);
            // 
            // CB_Type
            // 
            this.CB_Type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "TEXT",
            "JSON"});
            this.CB_Type.Location = new System.Drawing.Point(297, 164);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(109, 26);
            this.CB_Type.TabIndex = 11;
            this.CB_Type.SelectedIndexChanged += new System.EventHandler(this.CB_Type_SelectedIndexChanged);
            // 
            // BTN_DownloadData
            // 
            this.BTN_DownloadData.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_DownloadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DownloadData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_DownloadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DownloadData.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DownloadData.Location = new System.Drawing.Point(297, 206);
            this.BTN_DownloadData.Name = "BTN_DownloadData";
            this.BTN_DownloadData.Size = new System.Drawing.Size(109, 54);
            this.BTN_DownloadData.TabIndex = 10;
            this.BTN_DownloadData.Text = "DOWNLOAD DATA";
            this.BTN_DownloadData.UseVisualStyleBackColor = false;
            this.BTN_DownloadData.Click += new System.EventHandler(this.BTN_DownloadData_Click);
            // 
            // LB_User
            // 
            LB_User.AutoSize = true;
            LB_User.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_User.Location = new System.Drawing.Point(129, 21);
            LB_User.Name = "LB_User";
            LB_User.Size = new System.Drawing.Size(46, 19);
            LB_User.TabIndex = 2;
            LB_User.Text = "User:";
            // 
            // RTB_User
            // 
            this.RTB_User.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_User.Location = new System.Drawing.Point(15, 52);
            this.RTB_User.Name = "RTB_User";
            this.RTB_User.ReadOnly = true;
            this.RTB_User.Size = new System.Drawing.Size(265, 208);
            this.RTB_User.TabIndex = 1;
            this.RTB_User.Text = "";
            // 
            // PN_ComingSoon
            // 
            PN_ComingSoon.BackColor = System.Drawing.Color.Silver;
            PN_ComingSoon.Controls.Add(label1);
            PN_ComingSoon.Location = new System.Drawing.Point(412, 0);
            PN_ComingSoon.Name = "PN_ComingSoon";
            PN_ComingSoon.Size = new System.Drawing.Size(127, 275);
            PN_ComingSoon.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(10, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 152);
            label1.TabIndex = 12;
            label1.Text = "Upcoming features:\r\n\r\n-Token\r\n-Proxies\r\n-Courses\r\n-Curriculum\r\n-Admin role\r\n-Mult" +
    "i accounts";
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPage1);
            this.tabControlMenu.Controls.Add(this.tabPage2);
            this.tabControlMenu.ItemSize = new System.Drawing.Size(120, 23);
            this.tabControlMenu.Location = new System.Drawing.Point(12, 83);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(547, 306);
            this.tabControlMenu.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(PN_Log);
            this.tabPage1.Controls.Add(PN_Credentials);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(PN_ComingSoon);
            this.tabPage2.Controls.Add(PN_User);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialogBrowser
            // 
            this.openFileDialogBrowser.Filter = "Archive EXE (*.exe)|*.exe";
            // 
            // errorProviderConfig
            // 
            this.errorProviderConfig.ContainerControl = this;
            // 
            // Razenager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(576, 401);
            this.Controls.Add(this.tabControlMenu);
            this.Controls.Add(LB_Raze);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Razenager";
            this.Text = "github.com/hluciana | Proyect Razenager";
            PN_Credentials.ResumeLayout(false);
            PN_Credentials.PerformLayout();
            PN_Log.ResumeLayout(false);
            PN_Log.PerformLayout();
            PN_User.ResumeLayout(false);
            PN_User.PerformLayout();
            PN_ComingSoon.ResumeLayout(false);
            PN_ComingSoon.PerformLayout();
            this.tabControlMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.TextBox TB_Mail;
        private System.Windows.Forms.ComboBox CB_Role;
        private System.Windows.Forms.Button BTN_Scrap;
        private System.Windows.Forms.TextBox TB_Browser;
        private System.Windows.Forms.Button BTN_Browser;
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowser;
        private System.Windows.Forms.ErrorProvider errorProviderConfig;
        private System.Windows.Forms.RichTextBox RTB_Log;
        private System.Windows.Forms.RichTextBox RTB_User;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.Button BTN_DownloadData;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData;
        private System.Windows.Forms.Button BTN_DownloadLog;
        private System.Windows.Forms.Button BTN_ClearLog;
        private System.Windows.Forms.Button BTN_ClearData;
    }
}

