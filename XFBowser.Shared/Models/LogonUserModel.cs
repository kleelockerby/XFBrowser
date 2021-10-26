using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneStream.Shared.Common;
using OneStream.Shared.Wcf;

namespace XFBowser.Shared.Models
{
    public class LogonUserModel
    {
        public SessionInfo SI { get; set; }
        public UserPreferences UserPreferences { get; set; }
        public string ServerErrorMsg { get; set; }
        public AuthenticationResult AuthenticationResult { get; set; }
    }
}
