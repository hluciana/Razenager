using System;
using System.IO;
using Razenager.Web;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using System.Configuration;
using System.Threading.Tasks;

namespace Razenager
{
    public partial class Razenager : Form
    {
        private readonly string API_UserInfoDefault = ConfigurationManager.AppSettings["userInfo-Default"];
        private readonly string API_UserHistoricalGradesDefault = ConfigurationManager.AppSettings["userHistoricalGrades-Default"];
        private readonly string API_UserCoursesDefault = ConfigurationManager.AppSettings["userCourses-Default"];
        private readonly string API_UserCoursesGradesDefault = ConfigurationManager.AppSettings["userCoursesGrades-Default"];

        private string API_UserInfo = ConfigurationManager.AppSettings["userInfo"];
        private string API_UserHistoricalGrades = ConfigurationManager.AppSettings["userHistoricalGrades"];
        private string API_UserCourses = ConfigurationManager.AppSettings["userCourses"];
        private string API_UserCoursesGrades = ConfigurationManager.AppSettings["userCoursesGrades"];

        public Razenager()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(20, 22, 24);
            TB_Login_Pass.PasswordChar = '*';
            TB_Config_UserInfo.Text = API_UserInfo;
            TB_Config_UserHistoricalGrades.Text = API_UserHistoricalGrades;
            TB_Config_UserCourses.Text = API_UserCourses;
            TB_Config_UserCoursesGrades.Text = API_UserCoursesGrades;
            RB_Info_Personal.Checked = true;
            // coming soon...
            BTN_Login_GetToken.Enabled = false;
            RTB_Login_ContentResult.Text = "Coming Soon Get Token...";
            // coming soon...

            for (int i = 0; i < tabControlMenu.TabCount; i++)
            {
                tabControlMenu.TabPages[i].BorderStyle = BorderStyle.FixedSingle;
            }
        }

        // SECTION LOGIN

        private void BTN_Login_GetToken_Click(object sender, EventArgs e)
        {
            if (CheckLogin()) return;

            // coming soon code...
        }

        private void BTN_Login_CopyToken_Click(object sender, EventArgs e)
        {
            CopyDataText(RTB_Login_ContentResult.Text,BTN_Login_CopyResult);
        }

        private void BTN_Login_ClearToken_Click(object sender, EventArgs e)
        {
            RTB_Login_ContentResult.Clear();
        }

        private bool CheckLogin()
        {
            errorProviderData.Clear();

            bool valid = false;

            if (!TB_Login_Mail.Text.StartsWith("n", StringComparison.OrdinalIgnoreCase) || !TB_Login_Mail.Text.EndsWith("@upn.pe", StringComparison.OrdinalIgnoreCase) || TB_Login_Mail.Text.Length != 16)
            {
                valid = true;
                errorProviderData.SetError(TB_Login_Mail, "Enter a valid email!");
            }

            if (string.IsNullOrWhiteSpace(TB_Login_Pass.Text))
            {
                valid = true;
                errorProviderData.SetError(TB_Login_Pass, "Enter a valid password!");
            }

            return valid;
        }

        // SECTION INFO

        private void BTN_Info_GetInfoToken_Click(object sender, EventArgs e)
        {
            if (CheckData(RTB_Info_ContentToken)) return;

            if (RB_Info_Personal.Checked)
            {
                ExtractData(RTB_Info_ContentToken.Text, new Uri(API_UserInfo), HttpMethod.Post, BTN_Info_GetInfoToken, RTB_Info_ContentResult, "GET INFO/GRADES");
                return;
            }

            ExtractData(RTB_Info_ContentToken.Text, new Uri(API_UserHistoricalGrades), HttpMethod.Post, BTN_Info_GetInfoToken, RTB_Info_ContentResult, "GET INFO/GRADES");
        }

        private void BTN_Info_CopyResult_Click(object sender, EventArgs e)
        {
            CopyDataText(RTB_Info_ContentResult.Text,BTN_Info_CopyResult);
        }

        private void BTN_Info_ClearResult_Click(object sender, EventArgs e)
        {
            RTB_Info_ContentResult.Clear();
        }

        private void BTN_Info_DownloadResult_Click(object sender, EventArgs e)
        {
            SaveFileText("razeInfo", "Info saved!", "Info empty!",RTB_Info_ContentResult.Text);
        }

        // SECTION COURSES

        private void BTN_Courses_GetCoursesToken_Click(object sender, EventArgs e)
        {
            if (CheckData(RTB_Courses_ContentToken)) return;

            ExtractData(RTB_Courses_ContentToken.Text,new Uri(API_UserCourses), HttpMethod.Post, BTN_Courses_GetCoursesToken, RTB_Courses_ContentResult, "GET COURSES DATA");
        }

        private void BTN_Courses_GetCoursesGradesSubToken_Click(object sender, EventArgs e)
        {
            if (CheckData(RTB_Courses_ContentToken) || CheckData(RTB_CoursesGrades_ContentSubToken)) return;

            ExtractData(RTB_Courses_ContentToken.Text, RTB_CoursesGrades_ContentSubToken.Text, new Uri(API_UserCoursesGrades), HttpMethod.Post, BTN_Courses_GetCoursesToken, BTN_Courses_GetCoursesGradesSubToken, RTB_Courses_ContentResult, "GET COURSES DATA", "GET COURSE GRADES");
        }

        private void BTN_Courses_CopyResult_Click(object sender, EventArgs e)
        {
            CopyDataText(RTB_Courses_ContentResult.Text,BTN_Courses_CopyResult);
        }

        private void BTN_Courses_ClearResult_Click(object sender, EventArgs e)
        {
            RTB_Courses_ContentResult.Clear();
        }

        private void BTN_Courses_DownloadResult_Click(object sender, EventArgs e)
        {
            SaveFileText("razeCourses","Courses saved!", "Courses empty!", RTB_Courses_ContentResult.Text);
        }

        // INFO - COURSES

        private bool CheckData(RichTextBox rtb,string msg = "Complete the field!")
        {
            errorProviderData.Clear();

            if (string.IsNullOrWhiteSpace(rtb.Text))
            {
                errorProviderData.SetError(rtb, msg);
                return true;
            }

            return false;
        }

        private void ExtractData(string mooToken,Uri url,HttpMethod httpMethod,Button btn_token,RichTextBox rtb_result,string btn_name_token)
        {
            btn_token.Enabled = false;
            btn_token.Text = "Loading...";
            string result = "";

            Task.Run(async () =>
            {
                using (PostNager postNager = new PostNager())
                {
                    result = await postNager.AuthToken(mooToken, url, httpMethod);
                }

                rtb_result.BeginInvoke((MethodInvoker)(() => rtb_result.Text = result));
                btn_token.BeginInvoke((MethodInvoker)(() =>
                {
                    btn_token.Enabled = true;
                    btn_token.Text = btn_name_token;
                }));
            });
        }

        private void ExtractData(string mooToken,string subToken, Uri url, HttpMethod httpMethod, Button btn_token,Button btn_subToken, RichTextBox rtb_result, string btn_name_token,string btn_name_subToken)
        {
            btn_token.Enabled = false;
            btn_token.Text = "Loading...";
            btn_subToken.Enabled = false;
            btn_subToken.Text = "Loading...";
            string result = "";

            Task.Run(async () =>
            {
                using (PostNager postNager = new PostNager())
                {
                    result = await postNager.AuthToken(mooToken, url, httpMethod,subToken);
                }

                rtb_result.BeginInvoke((MethodInvoker)(() => rtb_result.Text = result));
                btn_token.BeginInvoke((MethodInvoker)(() =>
                {
                    btn_token.Enabled = true;
                    btn_token.Text = btn_name_token;
                }));
                btn_subToken.BeginInvoke((MethodInvoker)(() =>
                {
                    btn_subToken.Enabled = true;
                    btn_subToken.Text = btn_name_subToken;
                }));
            });
        }

        // SECTION ENCODE URL

        private void BTN_Decode_SendInput_Click(object sender, EventArgs e)
        {
            if (CheckURL(RTB_Decode_ContentInput, "Enter a valid URL!")) return;

            RTB_Decode_ContentOutput.Text = Uri.UnescapeDataString(RTB_Decode_ContentInput.Text);
        }

        private void BTN_Decode_CopyOutput_Click(object sender, EventArgs e)
        {
            CopyDataText(RTB_Decode_ContentOutput.Text,BTN_Decode_CopyOutput);
        }

        private void BTN_Decode_ClearOutput_Click(object sender, EventArgs e)
        {
            RTB_Decode_ContentInput.Clear();
            RTB_Decode_ContentOutput.Clear();
        }

        private void BTN_Encode_SendInput_Click(object sender, EventArgs e)
        {
            if (CheckURL(RTB_Encode_ContentInput, "Enter a valid URL!")) return;

            RTB_Encode_ContentOutput.Text = Uri.EscapeDataString(RTB_Encode_ContentInput.Text);
        }

        private void BTN_Encode_CopyOutput_Click(object sender, EventArgs e)
        {
            CopyDataText(RTB_Encode_ContentOutput.Text,BTN_Encode_CopyOutput);
        }

        private void BTN_Encode_ClearOutput_Click(object sender, EventArgs e)
        {
            RTB_Encode_ContentInput.Clear();
            RTB_Encode_ContentOutput.Clear();
        }

        private bool CheckURL(RichTextBox rtb,string msg)
        {
            errorProviderData.SetError(rtb, "");

            if (!rtb.Text.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                errorProviderData.SetError(rtb, msg);
                return true;
            }

            return false;
        }

        // SECTION CONFIG

        private void BTN_Config_Save_Click(object sender, EventArgs e)
        {
            if (CheckConfig()) return;

            string[] keys = { "userInfo", "userHistoricalGrades", "userCourses", "userCoursesGrades" };
            string[] values = { TB_Config_UserInfo.Text , TB_Config_UserHistoricalGrades.Text , TB_Config_UserCourses.Text , TB_Config_UserCoursesGrades.Text };
            
            ManageConfig(keys,values);
            API_UserInfo = TB_Config_UserInfo.Text;
            API_UserHistoricalGrades = TB_Config_UserHistoricalGrades.Text;
            API_UserCourses = TB_Config_UserCourses.Text;
            API_UserCoursesGrades = TB_Config_UserCoursesGrades.Text;

            MessageBox.Show("Config saved!", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTN_Config_Reset_Click(object sender, EventArgs e)
        {
            errorProviderData.Clear();
            if (API_UserInfoDefault == TB_Config_UserInfo.Text && API_UserHistoricalGradesDefault == TB_Config_UserHistoricalGrades.Text  && API_UserCoursesDefault == TB_Config_UserCourses.Text && API_UserCoursesGradesDefault == TB_Config_UserCoursesGrades.Text) return;

            string[] keys = { "userInfo", "userHistoricalGrades", "userCourses", "userCoursesGrades" };
            string[] values = { API_UserInfoDefault , API_UserHistoricalGradesDefault, API_UserCoursesDefault , API_UserCoursesGradesDefault };

            ManageConfig(keys,values);
            TB_Config_UserInfo.Text = API_UserInfoDefault;
            TB_Config_UserHistoricalGrades.Text = API_UserHistoricalGradesDefault;
            TB_Config_UserCourses.Text = API_UserCoursesDefault;
            TB_Config_UserCoursesGrades.Text = API_UserCoursesGradesDefault;

            API_UserInfo = API_UserInfoDefault;
            API_UserHistoricalGrades = API_UserHistoricalGradesDefault;
            API_UserCourses = API_UserCoursesDefault;
            API_UserCoursesGrades = API_UserCoursesGradesDefault;

            MessageBox.Show("Config reset!", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckConfig(string check_url = "https://mimundo.upn.edu.pe/api", string msg = "Enter a valid URL!")
        {
            errorProviderData.Clear();

            bool valid = false;

            if (!TB_Config_UserInfo.Text.StartsWith(check_url, StringComparison.OrdinalIgnoreCase))
            {
                valid = true;
                errorProviderData.SetError(TB_Config_UserInfo, msg);
            }

            if (!TB_Config_UserHistoricalGrades.Text.StartsWith(check_url, StringComparison.OrdinalIgnoreCase))
            {
                valid = true;
                errorProviderData.SetError(TB_Config_UserHistoricalGrades, msg);
            }

            if (!TB_Config_UserCourses.Text.StartsWith(check_url, StringComparison.OrdinalIgnoreCase))
            {
                valid = true;
                errorProviderData.SetError(TB_Config_UserCourses, msg);
            }

            if (!TB_Config_UserCoursesGrades.Text.StartsWith(check_url, StringComparison.OrdinalIgnoreCase))
            {
                valid = true;
                errorProviderData.SetError(TB_Config_UserCoursesGrades, msg);
            }

            if (TB_Config_UserInfo.Text == API_UserInfo && TB_Config_UserCourses.Text == API_UserCourses && TB_Config_UserHistoricalGrades.Text == API_UserHistoricalGrades)
            {
                valid = true;
            }

            return valid;
        }

        private void ManageConfig(string[] keys, string[] values)
        {
            if (keys.Length != values.Length) return;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            for (int i = 0; i < keys.Length; i++)
            {
                if (ConfigurationManager.AppSettings[keys[i]] != null)
                {
                    config.AppSettings.Settings[keys[i]].Value = values[i];
                }
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        // GLOBAL

        private async void CopyDataText(string content, Button btn, string name = "COPY")
        {
            if (!string.IsNullOrWhiteSpace(content))
            {
                btn.Text = "COPIED!";
                Clipboard.SetText(content);
                await Task.Delay(400);
                btn.Text = name;
            }
        }

        private void SaveFileText(string fileName, string msg_OK, string msg_ERROR,string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show(msg_ERROR, "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialogData.FileName = $"{fileName}.txt";

            if (saveFileDialogData.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogData.FileName, content);
                MessageBox.Show(msg_OK, "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
