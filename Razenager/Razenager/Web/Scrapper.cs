using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Razenager.Web
{
    internal class RN_Scrapper
    {
        private readonly ChromeDriverService chromeService;
        private readonly ChromeOptions chromeOptions;

        internal RN_Scrapper(string browserBin) {
            chromeService = ChromeDriverService.CreateDefaultService();
            chromeService.EnableVerboseLogging = false;
            chromeService.SuppressInitialDiagnosticInformation = true;
            chromeService.HideCommandPromptWindow = true;

            chromeOptions = new ChromeOptions() { BinaryLocation = browserBin };
            chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--no-sandbox");
            chromeOptions.AddArgument("--log-level=3");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--disable-logging");
            chromeOptions.AddArgument("--output=/dev/null");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-dev-shm-usage");
            chromeOptions.AddArgument("--disable-notifications");
            chromeOptions.AddArgument("--disable-crash-reporter");
            chromeOptions.AddArgument("--disable-in-process-stack-traces");
            chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
        }

        internal void Chrome(string mail, string pass, RichTextBox rtb_log, RichTextBox rtb_user)
        {
            LogDebug(rtb_log, $"------------------------\nReg -> {DateTime.Now}\nData -> {mail}:{pass}\nStarting...\nLoading service...\nLoading options...\n");

            try
            {
                using (IWebDriver driver = new ChromeDriver(chromeService, chromeOptions))
                {
                    LogDebug(rtb_log, "Config and service loaded!\nNavigating to blackboard student...\n");
                    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    driver.Navigate().GoToUrl(RN_Scripts.url_blackboard);

                    LogDebug(rtb_log, "Loading Blackboard role script...\n");
                    var checkRole = (bool)js.ExecuteScript(RN_Scripts.BlackboardRole());
                    LogDebug(rtb_log, "Blackboard role script OK!\n");

                    if (driver.Url.Contains(RN_Scripts.url_authLaurate) && checkRole)
                    {
                        LogDebug(rtb_log, "Loading auth.laureate.net...\nLoading email and password...\nLoading Auth Laurate script...\n");
                        var checkAuth = (bool)js.ExecuteScript(RN_Scripts.AuthLaurate(mail, pass));
                        LogDebug(rtb_log, "Auth Laurate script OK!\n");

                        if (driver.Url.Contains(RN_Scripts.url_blackboardInvalid)) LogDebug(rtb_log, "Student not registered in UPN...\n");
                        else if (driver.Url.Contains(RN_Scripts.url_blackboard) && checkAuth)
                        {
                            LogDebug(rtb_log, "Email and password OK!\nLoading upn.blackboard.com...\nLoading data extract script...\n");
                            
                            driver.Navigate().GoToUrl(Razenager.API_Info);
                            string infoJSON = driver.FindElement(By.TagName("pre")).Text;
                            RN_Scripts.upn_dataInfo = JObject.Parse(infoJSON).ToString();
                            LogDebug(rtb_log, "User info script OK!\n");

                            driver.Navigate().GoToUrl(Razenager.API_Courses);
                            string coursesJSON = driver.FindElement(By.TagName("pre")).Text;
                            RN_Scripts.upn_dataCourses = JObject.Parse(coursesJSON).ToString();
                            LogDebug(rtb_log, "User courses script OK!\nDownloaded data OK!\n");

                            rtb_user.BeginInvoke((MethodInvoker)(() => { rtb_user.Text = RN_Scripts.upn_dataInfo; }));
                        }
                        else if (driver.Url.Contains(RN_Scripts.url_authLaurate)) LogDebug(rtb_log, "ERROR: Email or password invalid!\n");
                        else LogDebug(rtb_log, "ERROR: It seems that there was a problem loading the page...\n");
                    }
                    else LogDebug(rtb_log, "ERROR: It seems that there was a problem loading the page...\n");

                    driver.Manage().Cookies.DeleteAllCookies();
                    driver.Close();
                }
            }
            catch (Exception err)
            {
                LogDebug(rtb_log, $"ERROR CRITICAL: {err}\n");
            }

            LogDebug(rtb_log, "End!\n------------------------\n\n");
        }

        private void LogDebug(RichTextBox rtb,string log)
        {
            rtb.BeginInvoke((MethodInvoker)(() => rtb.AppendText(log)));
        }
    }
}
