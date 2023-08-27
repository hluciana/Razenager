using System;
using OpenQA.Selenium;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;

namespace Razenager.Web
{
    internal static class RN_Script
    {
        internal static string dataPlain = String.Empty;
        internal static string dataJSON = String.Empty;
        private const string url = @"https://upn.blackboard.com/";
        private const string auth = @"https://auth.laureate.net/";
        private const string invalid = @"https://upn.blackboard.com/auth-saml/saml/SSO";

        internal static void Chrome(string mail, string pass, string bin, RichTextBox rtb_log,RichTextBox rtb_user)
        {
            rtb_log.BeginInvoke((MethodInvoker) (()=>
            {
                rtb_log.AppendText("------------------------\n");
                rtb_log.AppendText($"Reg -> {DateTime.Now}\n");
                rtb_log.AppendText($"Data -> {mail}:{pass}\n");
                rtb_log.AppendText("Starting...\n");
                rtb_log.AppendText("Loading service...\n");
            }));

            ChromeDriverService chromeService = ChromeDriverService.CreateDefaultService();
            chromeService.EnableVerboseLogging = false;
            chromeService.SuppressInitialDiagnosticInformation = true;
            chromeService.HideCommandPromptWindow = true;

            rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("Loading options...\n");  }));

            ChromeOptions chromeOptions = new ChromeOptions() { BinaryLocation = bin };
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

            try
            {
                using (IWebDriver driver = new ChromeDriver(chromeService, chromeOptions))
                {
                    rtb_log.BeginInvoke((MethodInvoker)(() => {
                        rtb_log.AppendText("Config and service loaded!\n");
                        rtb_log.AppendText("Navigating to blackboard student...\n");
                    }));
                    
                    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    driver.Navigate().GoToUrl(url);

                    rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("Loading student script...\n"); }));
                    js.ExecuteScript(@"
                        (() => {
                           const studentButtton = document.getElementById('btn-link-estte');
                           if (studentButtton !== null) studentButtton.click();
                        })();
                        ");
                    rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("Student script OK!\n"); }));

                    if (driver.Url.Contains(auth))
                    {
                        rtb_log.BeginInvoke((MethodInvoker)(() => {
                            rtb_log.AppendText("Loading auth.laureate.net...\n");
                            rtb_log.AppendText("Loading email and password...\n");
                            rtb_log.AppendText("Loading login script...\n");
                        }));
                        js.ExecuteScript(@"
                            (() => {
                              const mailInput = document.getElementById('userNameInput');
                              const passInput = document.getElementById('passwordInput');
                              const loginButton = document.getElementById('submitButton');
                              if (mailInput !== null && passInput !== null && loginButton !== null) {" +
                                 $"mailInput.value = '{mail}';" +
                                 $"passInput.value = '{pass}';" +
                                 @"loginButton.click();
                              }
                            })();
                            ");
                        rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("Login script OK!\n"); }));

                        if (driver.Url.Contains(invalid)) rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("Student not registered in UPN...\n"); }));
                        else if (driver.Url.Contains(url))
                        {
                            rtb_log.BeginInvoke((MethodInvoker)(() => {
                                rtb_log.AppendText("Email and password OK!\n");
                                rtb_log.AppendText("Loading upn.blackboard.com...\n");
                                rtb_log.AppendText("Loading data script...\n");
                            }));
                            dataPlain = js.ExecuteScript(@"
                                           const res = (() => {
                                             if (window.__initialContext?.user) {
                                               const user = window.__initialContext.user;
                                               if (user !== null) {
                                                 const data = [];
                                                 function loadData(user, prefix = '') {
                                                   for (let info in user) {
                                                     if (typeof user[info] === 'object') {
                                                       loadData(user[info], `${prefix}${info}.`);
                                                     } else {
                                                       data.push(`${prefix}${info} -> ${user[info]}`);
                                                     }
                                                   }
                                                 }
                                                 loadData(user);
                                                 return data.toString();
                                               }
                                             }
                                             return '';
                                           })();
                                           return res;
                                           ") as string;
                            dataPlain = dataPlain.Replace(",", "\n");
                            rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("Data plain script OK!\n"); }));

                            if (dataPlain != String.Empty)
                            {
                                dataJSON = js.ExecuteScript(@"
                                           const res = (() => {
                                             if (window.__initialContext?.user) {
                                               const user = window.__initialContext.user;
                                               if (user !== null) return JSON.stringify(user);
                                             }
                                             return '';
                                           })();
                                           return res;
                                           ") as string;

                                rtb_log.BeginInvoke((MethodInvoker)(() => {
                                    rtb_log.AppendText("Data JSON script OK!\n");
                                    rtb_log.AppendText("Downloaded data OK!\n");
                                }));

                                rtb_user.BeginInvoke((MethodInvoker)(() => { rtb_user.Text = dataPlain; }));
                            }
                            else rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("Sorry data is empty...\n"); }));
                        }
                        else if (driver.Url.Contains(auth)) rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("ERROR: Email or password invalid!\n"); }));
                        else rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("ERROR: It seems that there was a problem loading the page...\n"); }));
                    }
                    else rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("ERROR: It seems that there was a problem loading the page...\n"); }));

                    driver.Manage().Cookies.DeleteAllCookies();
                    driver.Close();
                }
            }
            catch (Exception err)
            {
                rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText($"ERROR CRITICAL: {err}\n"); }));
            }

            rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("End!\n"); }));
            rtb_log.BeginInvoke((MethodInvoker)(() => { rtb_log.AppendText("------------------------\n"); }));
        }
    }
}
