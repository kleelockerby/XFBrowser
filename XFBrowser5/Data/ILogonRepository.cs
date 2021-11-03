using System.Collections.Generic;
using OneStream.Shared.Wcf;

namespace XFBrowser5
{
    public interface ILogonRepository
    {
        bool LogonUser();
        IEnumerable<ApplicationModel> GetApplications();
        void OpenApplication();
    }
}
