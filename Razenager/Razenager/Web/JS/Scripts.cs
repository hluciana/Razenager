namespace Razenager.Web
{
    public static class RN_Scripts
    {
        public static string upn_dataInfo = string.Empty;
        public static string upn_dataCourses = string.Empty;
        public const string url_authLaurate = @"https://auth.laureate.net";
        public const string url_blackboard = @"https://upn.blackboard.com";
        public const string url_blackboardInvalid = @"https://upn.blackboard.com/auth-saml/saml/SSO";

        public static string BlackboardRole(string roleID = "btn-link-estte") => @"
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

        public static string AuthLaurate(string mail, string pass,string userID = "userNameInput",string passID = "passwordInput", string buttonID = "submitButton") => @"
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
    }
}
