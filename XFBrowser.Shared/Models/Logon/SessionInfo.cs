
namespace XFBrowser.Shared
{
    public class SessionInfo
    {
        public int ClientModuleType { get; set; }
        public string WebServerUrlUsedByClient { get; set; }
        public AuthToken AuthToken { get; set; }
        public AppToken AppToken { get; set; }
        public string Culture { get; set; }
        public int AppServerIndexForGeneralAccess { get; set; }
        public WorkflowClusterPk WorkflowClusterPk { get; set; }
        //public PovDataCellPk PovDataCellPk { get; set; }
    }
}
