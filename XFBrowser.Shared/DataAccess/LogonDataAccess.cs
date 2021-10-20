using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using OneStream.Shared.Common;
using OneStream.Shared.Wcf;
using OneStreamWebUI.Shared;

namespace XFBrowser.Shared
{
    public class LogonDataAccess
    {
        private HttpClient Http;

        public LogonDataAccess(HttpClient httpClient)
        {
            this.Http = httpClient;
        }

        public async Task<XFLogonResponseDto> LogonUserAsync(string userName, string password, string selectedApplicationName)
        {
            try
            {
                Guid xfAppGuid = new Guid(HttpClientHelper.GetSelectedApplicationStringId(selectedApplicationName));
                XFApplication selectedApplication = new XFApplication(xfAppGuid, selectedApplicationName, "", "", "");
                XFLogonRequestDto logonModel = new XFLogonRequestDto() { ClientModuleType = ClientModuleType.Web, ClientXFVersion = XFVersionInfo.XFVersion };
                logonModel.UserName = userName;
                logonModel.PasswordOrToken = password;
                logonModel.SelectedApplication = selectedApplication;

                HttpResponseMessage responseMessage = await this.Http?.PostAsJsonAsync<XFLogonRequestDto>(XFWebGeneralConstants.LogonUrl, logonModel);
                if (responseMessage != null && responseMessage.IsSuccessStatusCode)
                {
                    XFLogonResponseDto logonResponseDto = await responseMessage?.Content?.ReadFromJsonAsync<XFLogonResponseDto>();
                    if (logonResponseDto != null)
                    {
                        return logonResponseDto;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new XFException(ex);
            }
        }
    }
}
