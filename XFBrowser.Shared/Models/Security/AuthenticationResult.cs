
namespace XFBrowser.Shared
{
    public enum AuthenticationResult
    {
        Success = 0,
        IncompatibleClientXFVersion,
        InvalidLicense,
        ExpiredLicense,
        InvalidUserNameOrPassword,
        InvalidTrustedSI,
        UserIsDisabled,
        ExternalAuthenticationProviderNotFound,
        UnableToAccessLDAPServer,
        ExpiredPassword,
        InadequatePassword,
        ForcePasswordReset, 
        UnknownError
    }
}
