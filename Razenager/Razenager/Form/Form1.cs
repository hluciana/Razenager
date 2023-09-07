using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Threading.Tasks;
using Razenager.Web;

namespace Razenager
{
    public partial class Razenager : Form
    {
        private string bin = ConfigurationManager.AppSettings["browser"];
        public static string API_Info { get; private set; } = ConfigurationManager.AppSettings["userInfo"];
        public static string API_Courses { get; private set; } = ConfigurationManager.AppSettings["userCourses"];

        public Razenager()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(20, 22, 24);
            CB_Role.Text = "student";
            CB_Type.Text = "INFO";
            TB_Pass.PasswordChar = '*';
            TB_Browser.Text = bin;
            TB_InfoAPI.Text = API_Info;
            TB_CoursesAPI.Text = API_Courses;

            for (int i = 0; i < tabControlMenu.TabCount; i++)
            {
                tabControlMenu.TabPages[i].BackColor = Color.Gray;
                tabControlMenu.TabPages[i].BorderStyle = BorderStyle.FixedSingle;
            }
        }

        // SECTION LOGIN

        private void BTN_Browser_Click(object sender, System.EventArgs e)
        {
            if(openFileDialogBrowser.ShowDialog() == DialogResult.OK)
            {
                TB_Browser.Text = openFileDialogBrowser.FileName;
            }
        }

        private void BTN_Scrap_Click(object sender, System.EventArgs e)
        {
            if (ErrorScrap()) return;

            if (CB_Role.Text == "admin")
            {
                MessageBox.Show("Administrator role is not available\n\nComing Soon...", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TB_Browser.Text != bin)
            {
                bin = TB_Browser.Text;
                ManageConfig("browser", TB_Browser.Text);
            }

            BTN_Scrap.Enabled = false;
            BTN_Scrap.Text = "Loading...";
            BTN_DownloadLog.Enabled = false;
            BTN_ClearLog.Enabled = false;

            Task.Run(()=>
            {
                using (RN_Scrapper scrapper = new RN_Scrapper(bin))
                {
                    scrapper.Login(TB_Mail.Text, TB_Pass.Text, RTB_Log);
                }

                RTB_User.BeginInvoke((MethodInvoker)(() => { RTB_User.Text = RN_Scripts.upn_dataInfo; }));
                BTN_Scrap.BeginInvoke((MethodInvoker)(() =>
                {
                    BTN_Scrap.Enabled = true;
                    BTN_Scrap.Text = "SCRAP";
                }));
                BTN_DownloadLog.BeginInvoke((MethodInvoker)(() => BTN_DownloadLog.Enabled = true));
                BTN_ClearLog.BeginInvoke((MethodInvoker)(() => BTN_ClearLog.Enabled = true));
                CB_Type.BeginInvoke((MethodInvoker)(() => CB_Type.Text = "INFO"));
            });
        }

        private void BTN_DownloadLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_Log.Text)) MessageBox.Show("Log is empty", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else SaveFileText("razeLog", "Log saved!", RTB_Log);
        }

        private void BTN_ClearLog_Click(object sender, EventArgs e)
        {
            RTB_Log.Clear();
        }

        private bool ErrorScrap()
        {
            errorProviderConfig.Clear();

            bool status = false;

            if (!TB_Mail.Text.StartsWith("n", StringComparison.OrdinalIgnoreCase) || !TB_Mail.Text.EndsWith("@upn.pe", StringComparison.OrdinalIgnoreCase) || TB_Mail.Text.Length != 16)
            {
                status = true;
                errorProviderConfig.SetError(TB_Mail, "Enter a valid email!");
            }

            if (string.IsNullOrWhiteSpace(TB_Pass.Text))
            {
                status = true;
                errorProviderConfig.SetError(TB_Pass, "Enter a valid password!");
            }

            if (string.IsNullOrWhiteSpace(TB_Browser.Text) || !File.Exists(TB_Browser.Text) || Path.GetExtension(TB_Browser.Text) != ".exe")
            {
                status = true;
                errorProviderConfig.SetError(BTN_Browser, "Enter a valid browser!");
            }

            return status;
        }

        // SECTION DATA

        private void BTN_ClearData_Click(object sender, EventArgs e)
        {
            RTB_User.Clear();
            RN_Scripts.upn_dataInfo = string.Empty;
            RN_Scripts.upn_dataCourses = string.Empty;
        }

        private void BTN_CopyData_Click(object sender, EventArgs e)
        {
            if (RTB_User.Text != "Coming Soon...") CopyDataText(RTB_User, BTN_CopyData, "COPY DATA");
        }

        private void CB_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            RTB_User.Clear();
            switch (CB_Type.SelectedIndex)
            {
                case 0:
                    RTB_User.Text += RN_Scripts.upn_dataInfo;
                    break;
                case 1:
                    RTB_User.Text += RN_Scripts.upn_dataCourses;
                    break;
                case 2:
                    RTB_User.Text += "Coming Soon...";
                    break;
                case 3:
                    if (RN_Scripts.upn_dataInfo != string.Empty)
                    {
                        RTB_User.Text += "---------------- USER INFO ----------------\n\n";
                        RTB_User.Text += RN_Scripts.upn_dataInfo + "\n\n\n";
                    }

                    if (RN_Scripts.upn_dataCourses != string.Empty)
                    {
                        RTB_User.Text += "-------------- USER COURSES --------------\n\n";
                        RTB_User.Text += RN_Scripts.upn_dataCourses;
                    }
                    break;
            }
        }

        private void BTN_DownloadData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_User.Text) || CB_Type.SelectedIndex == 2) MessageBox.Show("Data is empty", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else SaveFileText($"raze{CB_Type.Text}", "Data saved!", RTB_User);
        }

        // SECTION TOKEN

        private void BTN_PostToken_Click(object sender, EventArgs e)
        {
            errorProviderConfig.Clear();

            if (!string.IsNullOrWhiteSpace(RTB_TokenContent.Text))
            {
                BTN_PostToken.Enabled = false;
                BTN_PostToken.Text = "Authenticating...";
                string token = RTB_TokenContent.Text;

                Task.Run(async() =>
                {
                    using (RN_PostNager postNager = new RN_PostNager())
                    {
                        await postNager.AuthToken(token,RTB_TokenResult);
                    }

                    BTN_PostToken.BeginInvoke((MethodInvoker)(() =>
                    {
                        BTN_PostToken.Enabled = true;
                        BTN_PostToken.Text = "POST";
                    }));
                });
            }
            else
            {
                errorProviderConfig.SetError(RTB_TokenContent,"Please complete the field");
            }
        }

        private void BTN_CopyResult_Click(object sender, EventArgs e)
        {
            CopyDataText(RTB_TokenResult, BTN_CopyResult,"COPY RESULT");
        }

        private void BTN_ClearResult_Click(object sender, EventArgs e)
        {
            RTB_TokenResult.Clear();
        }

        private void BTN_DownloadResult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_TokenResult.Text)) MessageBox.Show("Result is empty", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else SaveFileText("razeTokenResult", "Result saved!", RTB_TokenResult);
        }

        // SECTION DECODE/ENCODE URL

        private void BTN_DecodeInput_Click(object sender, EventArgs e)
        {
            errorProviderConfig.SetError(RTB_DecodeInputContent, "");

            if (RTB_DecodeInputContent.Text.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                RTB_DecodeOutputContent.Text = Uri.UnescapeDataString(RTB_DecodeInputContent.Text);
            }
            else
            {
                errorProviderConfig.SetError(RTB_DecodeInputContent, "Enter a valid URL!");
            }
        }

        private void BTN_DecodeOutputClear_Click(object sender, EventArgs e)
        {
            RTB_DecodeInputContent.Clear();
            RTB_DecodeOutputContent.Clear();
        }

        private void BTN_DecodeOutputCopy_Click(object sender, EventArgs e)
        {
            CopyDataText(RTB_DecodeOutputContent, BTN_DecodeOutputCopy);
        }

        private void BTN_EncodeInput_Click(object sender, EventArgs e)
        {
            errorProviderConfig.SetError(RTB_EncodeInputContent,"");

            if (RTB_EncodeInputContent.Text.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                RTB_EncodeOutputContent.Text = Uri.EscapeDataString(RTB_EncodeInputContent.Text);
            }
            else
            {
                errorProviderConfig.SetError(RTB_EncodeInputContent, "Enter a valid URL!");
            }
        }

        private void BTN_EncodeOutputClear_Click(object sender, EventArgs e)
        {
            RTB_EncodeInputContent.Clear();
            RTB_EncodeOutputContent.Clear();
        }

        private void BTN_EncodeOutputCopy_Click(object sender, EventArgs e)
        {
            CopyDataText(RTB_EncodeOutputContent, BTN_EncodeOutputCopy);
        }

        // SECTION CONFIG

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (ErrorConfig()) return;

            if (API_Info == TB_InfoAPI.Text && API_Courses == TB_CoursesAPI.Text) return;

            ManageConfig("userInfo", TB_InfoAPI.Text);
            ManageConfig("userCourses", TB_CoursesAPI.Text);
            API_Info = TB_InfoAPI.Text;
            API_Courses = TB_CoursesAPI.Text;

            MessageBox.Show("Config saved!", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTN_ResetDefault_Click(object sender, EventArgs e)
        {
            string userInfoDefault = ConfigurationManager.AppSettings["userInfo-Default"];
            string userCoursesDefault = ConfigurationManager.AppSettings["userCourses-Default"];

            if (userInfoDefault == TB_InfoAPI.Text && userCoursesDefault == TB_CoursesAPI.Text) return;

            ManageConfig("userInfo", userInfoDefault);
            ManageConfig("userCourses", userCoursesDefault);

            TB_InfoAPI.Text = ConfigurationManager.AppSettings["userInfo"];
            TB_CoursesAPI.Text = ConfigurationManager.AppSettings["userCourses"];
            API_Info = TB_InfoAPI.Text;
            API_Courses = TB_CoursesAPI.Text;

            MessageBox.Show("Config reset default!", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManageConfig(string key,string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private bool ErrorConfig()
        {
            errorProviderConfig.Clear();

            bool status = false;

            if (!TB_InfoAPI.Text.StartsWith("https://",StringComparison.OrdinalIgnoreCase))
            {
                status = true;
                errorProviderConfig.SetError(TB_InfoAPI, "Enter a valid URL!");
            }
            if (!TB_CoursesAPI.Text.StartsWith("https://",StringComparison.OrdinalIgnoreCase))
            {
                status = true;
                errorProviderConfig.SetError(TB_CoursesAPI, "Enter a valid URL!");
            }

            return status;
        }

        // GLOBAL

        private void SaveFileText(string fileName,string message,RichTextBox rtb)
        {
            saveFileDialogData.FileName = $"{fileName}.txt";

            if (saveFileDialogData.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogData.FileName, rtb.Text);
                MessageBox.Show(message, "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void CopyDataText(RichTextBox rtb,Button btn,string name = "COPY")
        {
            if (rtb.Text != string.Empty)
            {
                btn.Text = "COPIED!";
                Clipboard.SetText(rtb.Text);
                await Task.Delay(400);
                btn.Text = name;
            }
        }
    }
}
