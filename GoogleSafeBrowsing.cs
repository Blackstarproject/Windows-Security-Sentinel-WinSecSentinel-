using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinSecSentinel
{
    public class GoogleSafeBrowsing
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string ApiKey = "AIzaSyDAfqcn1KKbf_JzVBUlanQWO60yijNkYMs"; // Replace with your API key
        private const string ApiUrl = "https://safebrowsing.googleapis.com/v4/threatMatches:find?key=" + ApiKey;

        public async Task<string> CheckUrlAsync(string url)
        {
            var request = new
            {
                client = new { clientId = "WinSecSentinel", clientVersion = "1.0.0" },
                threatInfo = new
                {
                    threatTypes = new[] { "MALWARE", "SOCIAL_ENGINEERING", "UNWANTED_SOFTWARE", "POTENTIALLY_HARMFUL_APPLICATION" },
                    platformTypes = new[] { "WINDOWS" },
                    threatEntryTypes = new[] { "URL" },
                    threatEntries = new[] { new { url } }
                }
            };

            var jsonRequest = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync(ApiUrl, content);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(jsonResponse);

                if (result.matches != null)
                {
                    return $"[CRITICAL] The URL '{url}' is flagged as malicious by Google Safe Browsing.";
                }

                return $"[SAFE] The URL '{url}' is not flagged as malicious by Google Safe Browsing.";
            }
            catch (Exception ex)
            {
                return $"[ERROR] Could not scan the URL: {ex.Message}";
            }
        }
    }
}