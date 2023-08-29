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

        public Razenager()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(20, 22, 24);
            CB_Role.Text = "student";
            CB_Type.Text = "TEXT";
            TB_Pass.PasswordChar = '*';
            TB_Browser.Text = bin;

            for (int i = 0; i < tabControlMenu.TabCount; i++)
            {
                tabControlMenu.TabPages[i].BackColor = Color.Gray;
                tabControlMenu.TabPages[i].BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void BTN_Browser_Click(object sender, System.EventArgs e)
        {
            if(openFileDialogBrowser.ShowDialog() == DialogResult.OK)
            {
                TB_Browser.Text = openFileDialogBrowser.FileName;
            }
        }

        private void BTN_Scrap_Click(object sender, System.EventArgs e)
        {
            if (ErrorConfig()) return;

            if (CB_Role.Text == "admin")
            {
                MessageBox.Show("Administrator role is not available\n\nComing Soon...", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TB_Browser.Text != bin)
            {
                bin = TB_Browser.Text;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["browser"].Value = TB_Browser.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }

            BTN_Scrap.Enabled = false;
            BTN_Scrap.Text = "Loading...";
            BTN_DownloadLog.Enabled = false;
            BTN_ClearLog.Enabled = false;

            Task.Run(()=>
            {
                RN_Scrapper scrapper = new RN_Scrapper(TB_Browser.Text);
                scrapper.Chrome(TB_Mail.Text, TB_Pass.Text,RTB_Log,RTB_User);
                
                BTN_Scrap.BeginInvoke((MethodInvoker)(() =>
                {
                    BTN_Scrap.Enabled = true;
                    BTN_Scrap.Text = "SCRAP";
                }));

                BTN_DownloadLog.BeginInvoke((MethodInvoker)(() => BTN_DownloadLog.Enabled = true));
                BTN_ClearLog.BeginInvoke((MethodInvoker)(() => BTN_ClearLog.Enabled = true));
            });
        }

        private void BTN_ClearLog_Click(object sender, EventArgs e)
        {
            RTB_Log.Clear();
        }

        private void BTN_DownloadLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_Log.Text)) MessageBox.Show("Log is empty", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                saveFileDialogData.FileName = "razeLog.txt";
                if (saveFileDialogData.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialogData.FileName, RTB_Log.Text);
                    MessageBox.Show("Log saved!", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CB_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Type.SelectedIndex == 0) RTB_User.Text = RN_Scripts.upn_dataPlain;
            else RTB_User.Text = RN_Scripts.upn_dataJSON;
        }

        private void BTN_ClearData_Click(object sender, EventArgs e)
        {
            RTB_User.Clear();
            RN_Scripts.upn_dataPlain = string.Empty;
            RN_Scripts.upn_dataJSON = string.Empty;
        }

        private void BTN_DownloadData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_User.Text)) MessageBox.Show("Data is empty", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(CB_Type.SelectedIndex == 0) saveFileDialogData.FileName = "razeData.txt";
                else saveFileDialogData.FileName = "razeJSON.txt";
                if (saveFileDialogData.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialogData.FileName, RTB_User.Text);
                    MessageBox.Show("Data saved!", "Razenager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ErrorConfig()
        {
            errorProviderConfig.Clear();

            bool status = false;

            if (!TB_Mail.Text.EndsWith("@upn.pe") || TB_Mail.Text.Length != 16 || !TB_Mail.Text.ToLower().StartsWith("n"))
            {
                status = true;
                errorProviderConfig.SetError(TB_Mail,"Enter a valid email");
            }

            if (string.IsNullOrWhiteSpace(TB_Pass.Text))
            {
                status = true;
                errorProviderConfig.SetError(TB_Pass,"Enter a valid password");
            }

            if (string.IsNullOrWhiteSpace(TB_Browser.Text) || !File.Exists(TB_Browser.Text) || Path.GetExtension(TB_Browser.Text) != ".exe")
            {
                status = true;
                errorProviderConfig.SetError(BTN_Browser,"Enter a valid browser");
            }

            return status;
        }
    }
}
