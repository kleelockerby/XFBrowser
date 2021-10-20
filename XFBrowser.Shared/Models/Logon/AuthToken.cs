using System;

namespace XFBrowser.Shared
{
    public class AuthToken
    {
        public string SHA1HashCode { get; set; }
        public string AuthSessionID { get; set; }
        public string UserName { get; set; }
        public string UserUniqueID { get; set; }
        public DateTime TimeAuthenticated { get; set; }
    }
}
