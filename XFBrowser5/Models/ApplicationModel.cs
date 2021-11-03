using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFBrowser5
{
    public class ApplicationModel
    {
        public Guid UniqueID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DatabaseServerConnectionName { get; set; }
        public string DatabaseSchemaName { get; set; }
    }
}
