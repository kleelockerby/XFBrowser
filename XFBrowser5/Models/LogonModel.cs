using System.Collections.Generic;
using OneStream.Shared.Common;
using OneStream.Shared.Wcf;
using OneStreamWebUI.Shared;

namespace XFBrowser5
{
    public class LogonModel
    {
        public SessionInfo SI { get; set; }
        public IEnumerable<XFApplication> Applications { get; set; }
    }
}
