using System;
using System.Collections.Generic;
using OneStream.Shared.Wcf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFBrowser5
{
    public class LogonRepository : ILogonRepository
    {
        public bool LogonUser()
        {
            return false;
        }

        public IEnumerable<ApplicationModel> GetApplications()
        {
            return null;
        }

        public void OpenApplication()
        {

        }

    }
}
