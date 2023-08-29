namespace Razenager.Web
{
    internal static class RN_Scripts
    {
        internal static string upn_dataPlain = string.Empty;
        internal static string upn_dataJSON = string.Empty;
        internal const string url_authLaurate = @"https://auth.laureate.net";
        internal const string url_blackboard = @"https://upn.blackboard.com";
        internal const string url_blackboardInvalid = @"https://upn.blackboard.com/auth-saml/saml/SSO";

        internal static string BlackboardRole(string roleID = "btn-link-estte") => @"
                        const res = (() => {
                           const studentButtton = document.getElementById('" + roleID + @"');
                           if (studentButtton !== null) {
                              studentButtton.click();
                              return true;
                           }
                           return false;
                        })();
                        return res;
                        ";

        internal static string AuthLaurate(string mail, string pass,string userID = "userNameInput",string passID = "passwordInput", string buttonID = "submitButton") => @"
                        const res = (() => {
                          const mailInput = document.getElementById('"+ userID +@"');
                          const passInput = document.getElementById('"+ passID + @"');
                          const loginButton = document.getElementById('"+ buttonID + @"');
                          if (mailInput !== null && passInput !== null && loginButton !== null) {" +
                             $"mailInput.value = '{mail}';" +
                             $"passInput.value = '{pass}';" +
                             @"loginButton.click();
                             return true;
                          }
                          return false;
                        })();
                        return res;                        
                        ";

        internal static string DataPlain(string property) => @"
                        const res = (() => {
                          if (window.__initialContext?." + property + @") {
                            const content = window.__initialContext." + property + @";
                            if (content !== null) {
                              const data = [];
                              function loadData(content, prefix = '') {
                                for (let info in content) {
                                  if (typeof content[info] === 'object') {
                                    loadData(content[info], `${prefix}${info}.`);
                                  } else {
                                    data.push(`${prefix}${info} -> ${content[info]}`);
                                  }
                                }
                              }
                              loadData(content);
                              return data.toString();
                            }
                          }
                          return '';
                        })();
                        return res;
                        ";

        internal static string DataJSON(string property) => @"
                        const res = (() => {
                          if (window.__initialContext?." + property + @") {
                            const content = window.__initialContext." + property + @";
                            if (content !== null) return JSON.stringify(content);
                          }
                          return '';
                        })();
                        return res;
                        ";
    }
}
