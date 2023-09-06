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
            System.Windows.Forms.Panel PN_Type;
            System.Windows.Forms.Label LB_Type;
            System.Windows.Forms.Panel PN_Config;
            System.Windows.Forms.Label LB_Warning;
            System.Windows.Forms.GroupBox GP_ComingSoon;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
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
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.BTN_ClearData = new System.Windows.Forms.Button();
            this.RTB_User = new System.Windows.Forms.RichTextBox();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.BTN_DownloadData = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_ResetDefault = new System.Windows.Forms.Button();
            this.TB_CoursesAPI = new System.Windows.Forms.TextBox();
            this.TB_InfoAPI = new System.Windows.Forms.TextBox();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            PN_Type = new System.Windows.Forms.Panel();
            LB_Type = new System.Windows.Forms.Label();
            PN_Config = new System.Windows.Forms.Panel();
            LB_Warning = new System.Windows.Forms.Label();
            GP_ComingSoon = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            PN_Credentials.SuspendLayout();
            PN_Log.SuspendLayout();
            PN_User.SuspendLayout();
            PN_Type.SuspendLayout();
            PN_Config.SuspendLayout();
            groupBox1.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.BTN_DownloadLog.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DownloadLog.Location = new System.Drawing.Point(26, 244);
            this.BTN_DownloadLog.Name = "BTN_DownloadLog";
            this.BTN_DownloadLog.Size = new System.Drawing.Size(112, 25);
            this.BTN_DownloadLog.TabIndex = 11;
            this.BTN_DownloadLog.Text = "DOWNLOAD LOG";
            this.BTN_DownloadLog.UseVisualStyleBackColor = false;
            this.BTN_DownloadLog.Click += new System.EventHandler(this.BTN_DownloadLog_Click);
            // 
            // BTN_ClearLog
            // 
            this.BTN_ClearLog.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_ClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ClearLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_ClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClearLog.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearLog.Location = new System.Drawing.Point(154, 244);
            this.BTN_ClearLog.Name = "BTN_ClearLog";
            this.BTN_ClearLog.Size = new System.Drawing.Size(97, 25);
            this.BTN_ClearLog.TabIndex = 10;
            this.BTN_ClearLog.Text = "CLEAR LOG";
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
            PN_User.Controls.Add(this.BTN_Copy);
            PN_User.Controls.Add(LB_User);
            PN_User.Controls.Add(this.BTN_ClearData);
            PN_User.Controls.Add(this.RTB_User);
            PN_User.Location = new System.Drawing.Point(0, 0);
            PN_User.Name = "PN_User";
            PN_User.Size = new System.Drawing.Size(362, 275);
            PN_User.TabIndex = 2;
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Copy.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Copy.Location = new System.Drawing.Point(185, 226);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(125, 34);
            this.BTN_Copy.TabIndex = 13;
            this.BTN_Copy.Text = "COPY DATA";
            this.BTN_Copy.UseVisualStyleBackColor = false;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // LB_User
            // 
            LB_User.AutoSize = true;
            LB_User.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_User.Location = new System.Drawing.Point(159, 21);
            LB_User.Name = "LB_User";
            LB_User.Size = new System.Drawing.Size(46, 19);
            LB_User.TabIndex = 2;
            LB_User.Text = "User:";
            // 
            // BTN_ClearData
            // 
            this.BTN_ClearData.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_ClearData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ClearData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_ClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClearData.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearData.Location = new System.Drawing.Point(45, 226);
            this.BTN_ClearData.Name = "BTN_ClearData";
            this.BTN_ClearData.Size = new System.Drawing.Size(125, 34);
            this.BTN_ClearData.TabIndex = 12;
            this.BTN_ClearData.Text = "CLEAR DATA";
            this.BTN_ClearData.UseVisualStyleBackColor = false;
            this.BTN_ClearData.Click += new System.EventHandler(this.BTN_ClearData_Click);
            // 
            // RTB_User
            // 
            this.RTB_User.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_User.Location = new System.Drawing.Point(45, 52);
            this.RTB_User.Name = "RTB_User";
            this.RTB_User.ReadOnly = true;
            this.RTB_User.Size = new System.Drawing.Size(265, 168);
            this.RTB_User.TabIndex = 1;
            this.RTB_User.Text = "";
            // 
            // PN_Type
            // 
            PN_Type.BackColor = System.Drawing.Color.Tan;
            PN_Type.Controls.Add(LB_Type);
            PN_Type.Controls.Add(this.CB_Type);
            PN_Type.Controls.Add(this.BTN_DownloadData);
            PN_Type.Location = new System.Drawing.Point(359, 0);
            PN_Type.Name = "PN_Type";
            PN_Type.Size = new System.Drawing.Size(180, 275);
            PN_Type.TabIndex = 3;
            // 
            // LB_Type
            // 
            LB_Type.AutoSize = true;
            LB_Type.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Type.Location = new System.Drawing.Point(69, 50);
            LB_Type.Name = "LB_Type";
            LB_Type.Size = new System.Drawing.Size(46, 19);
            LB_Type.TabIndex = 12;
            LB_Type.Text = "Type:";
            // 
            // CB_Type
            // 
            this.CB_Type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "INFO",
            "COURSES",
            "TOKEN",
            "ALL"});
            this.CB_Type.Location = new System.Drawing.Point(42, 91);
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
            this.BTN_DownloadData.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DownloadData.Location = new System.Drawing.Point(42, 198);
            this.BTN_DownloadData.Name = "BTN_DownloadData";
            this.BTN_DownloadData.Size = new System.Drawing.Size(109, 46);
            this.BTN_DownloadData.TabIndex = 10;
            this.BTN_DownloadData.Text = "DOWNLOAD DATA";
            this.BTN_DownloadData.UseVisualStyleBackColor = false;
            this.BTN_DownloadData.Click += new System.EventHandler(this.BTN_DownloadData_Click);
            // 
            // PN_Config
            // 
            PN_Config.BackColor = System.Drawing.Color.SlateGray;
            PN_Config.Controls.Add(this.BTN_Save);
            PN_Config.Controls.Add(this.BTN_ResetDefault);
            PN_Config.Controls.Add(LB_Warning);
            PN_Config.Controls.Add(GP_ComingSoon);
            PN_Config.Controls.Add(groupBox1);
            PN_Config.Location = new System.Drawing.Point(0, 0);
            PN_Config.Name = "PN_Config";
            PN_Config.Size = new System.Drawing.Size(539, 275);
            PN_Config.TabIndex = 3;
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.Location = new System.Drawing.Point(383, 145);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(130, 38);
            this.BTN_Save.TabIndex = 10;
            this.BTN_Save.Text = "SAVE CONFIG";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_ResetDefault
            // 
            this.BTN_ResetDefault.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_ResetDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ResetDefault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTN_ResetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ResetDefault.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ResetDefault.Location = new System.Drawing.Point(383, 208);
            this.BTN_ResetDefault.Name = "BTN_ResetDefault";
            this.BTN_ResetDefault.Size = new System.Drawing.Size(130, 38);
            this.BTN_ResetDefault.TabIndex = 11;
            this.BTN_ResetDefault.Text = "RESET CONFIG";
            this.BTN_ResetDefault.UseVisualStyleBackColor = false;
            this.BTN_ResetDefault.Click += new System.EventHandler(this.BTN_ResetDefault_Click);
            // 
            // LB_Warning
            // 
            LB_Warning.AutoSize = true;
            LB_Warning.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Warning.ForeColor = System.Drawing.Color.Red;
            LB_Warning.Location = new System.Drawing.Point(6, 249);
            LB_Warning.Name = "LB_Warning";
            LB_Warning.Size = new System.Drawing.Size(525, 14);
            LB_Warning.TabIndex = 2;
            LB_Warning.Text = "Warning: Do not modify something if you do not know what you are doing as it coul" +
    "d cause errors";
            // 
            // GP_ComingSoon
            // 
            GP_ComingSoon.Location = new System.Drawing.Point(19, 145);
            GP_ComingSoon.Name = "GP_ComingSoon";
            GP_ComingSoon.Size = new System.Drawing.Size(336, 101);
            GP_ComingSoon.TabIndex = 1;
            GP_ComingSoon.TabStop = false;
            GP_ComingSoon.Text = "Coming Soon...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(this.TB_CoursesAPI);
            groupBox1.Controls.Add(this.TB_InfoAPI);
            groupBox1.Location = new System.Drawing.Point(19, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(494, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "API";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(15, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 19);
            label3.TabIndex = 5;
            label3.Text = "User Courses:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(15, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 19);
            label2.TabIndex = 4;
            label2.Text = "User Info:";
            // 
            // TB_CoursesAPI
            // 
            this.TB_CoursesAPI.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CoursesAPI.Location = new System.Drawing.Point(132, 69);
            this.TB_CoursesAPI.Name = "TB_CoursesAPI";
            this.TB_CoursesAPI.Size = new System.Drawing.Size(341, 23);
            this.TB_CoursesAPI.TabIndex = 3;
            // 
            // TB_InfoAPI
            // 
            this.TB_InfoAPI.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_InfoAPI.Location = new System.Drawing.Point(132, 29);
            this.TB_InfoAPI.Name = "TB_InfoAPI";
            this.TB_InfoAPI.Size = new System.Drawing.Size(341, 23);
            this.TB_InfoAPI.TabIndex = 2;
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPage1);
            this.tabControlMenu.Controls.Add(this.tabPage2);
            this.tabControlMenu.Controls.Add(this.tabPage3);
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
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(PN_Type);
            this.tabPage2.Controls.Add(PN_User);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(PN_Config);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(539, 275);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialogBrowser
            // 
            this.openFileDialogBrowser.Filter = "Archive EXE (*.exe)|*.exe";
            // 
            // errorProviderConfig
            // 
            this.errorProviderConfig.ContainerControl = this;
            // 
            // saveFileDialogData
            // 
            this.saveFileDialogData.Filter = "Archive TXT (*.txt)|*.txt";
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
            PN_Type.ResumeLayout(false);
            PN_Type.PerformLayout();
            PN_Config.ResumeLayout(false);
            PN_Config.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.tabControlMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_ResetDefault;
        private System.Windows.Forms.TextBox TB_CoursesAPI;
        private System.Windows.Forms.TextBox TB_InfoAPI;
        private System.Windows.Forms.Button BTN_Copy;
    }
}

