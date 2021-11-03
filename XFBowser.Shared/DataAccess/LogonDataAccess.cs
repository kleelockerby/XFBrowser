using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using OneStream.Shared.Common;
using OneStream.Shared.Wcf;
using OneStreamWebUI.Shared;

namespace XFBrowser.Shared
{
    public static class LogonDataAccess
    {
        private static HttpClient Http;

        static LogonDataAccess()
        {
            Http = new HttpClient();
        }

        public static async Task<XFLogonResponseDto> LogonUserAsync(string userName, string password, string selectedApplicationName)
        {
            try
            {
                Guid xfAppGuid = new Guid(HttpClientHelper.GetSelectedApplicationStringId(selectedApplicationName));
                XFApplication selectedApplication = new XFApplication(xfAppGuid, selectedApplicationName, "", "", "");
                XFLogonRequestDto logonModel = new XFLogonRequestDto() { ClientModuleType = ClientModuleType.Web, ClientXFVersion = XFVersionInfo.XFVersion };
                logonModel.UserName = userName;
                logonModel.PasswordOrToken = password;
                logonModel.SelectedApplication = selectedApplication;

                HttpResponseMessage responseMessage = await Http?.PostAsJsonAsync<XFLogonRequestDto>(XFWebGeneralConstants.LogonUrl, logonModel);
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

        public static async Task<XFApplicationsResponseDto> GetApplicationsAsync(SessionInfo si)
        {
            try
            {
                XFBaseSiRequestDto siDto = new XFBaseSiRequestDto(si);
                HttpResponseMessage responseMessage = await Http?.PostAsJsonAsync<XFBaseSiRequestDto>(XFWebGeneralConstants.GetApplicationsUrl, siDto);
                if (responseMessage != null && responseMessage.IsSuccessStatusCode)
                {
                    XFApplicationsResponseDto applicationsResponseDto = await responseMessage?.Content?.ReadFromJsonAsync<XFApplicationsResponseDto>();
                    if ((applicationsResponseDto != null) && (applicationsResponseDto?.Applications?.Count > 0))
                    {
                        return applicationsResponseDto;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new XFException(ex);
            }
        }

        public static async Task<XFOpenApplicationResponseDto> OpenApplicationAsync(SessionInfo si, string selectedApplicationName)
        {
            try
            {
                XFOpenApplicationRequestDto openApplicationRequestDto = new XFOpenApplicationRequestDto(si, selectedApplicationName, null);
                HttpResponseMessage responseMessage = await Http?.PostAsJsonAsync<XFOpenApplicationRequestDto>(XFWebGeneralConstants.OpenApplicationUrl, openApplicationRequestDto);
                if (responseMessage != null && responseMessage.IsSuccessStatusCode)
                {
                    var jsonSerializerOptions = new System.Text.Json.JsonSerializerOptions();
                    jsonSerializerOptions.Converters.Add(new JsonNonStringKeyDictionaryConverter());
                    jsonSerializerOptions.Converters.Add(new WorkflowInfoCallbacksConverter());

                    XFOpenApplicationResponseDto openApplicationResponseDto = await responseMessage.Content?.ReadFromJsonAsync<XFOpenApplicationResponseDto>(jsonSerializerOptions);
                    if (openApplicationResponseDto != null)
                    {
                        return openApplicationResponseDto;
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
