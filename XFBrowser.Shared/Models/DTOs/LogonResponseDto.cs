using OneStreamWebUI.Shared;

namespace XFBrowser.Shared
{
    public class LogonResponseDto
    {
        public SessionInfo SI { get; set; }
        public UserPreferences UserPreferences { get; set; }
        public string ServerErrorMsg { get; set; }
        public AuthenticationResult AuthenticationResult { get; set; }
    }
}
