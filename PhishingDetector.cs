using System;
using System.Threading.Tasks;

namespace WinSecSentinel
{
    public class PhishingDetector
    {
        private readonly GoogleSafeBrowsing _safeBrowsing;

        public PhishingDetector()
        {
            _safeBrowsing = new GoogleSafeBrowsing();
        }

        public async Task<string> ScanUrlAsync(string urlString)
        {
            try
            {
                var result = await _safeBrowsing.CheckUrlAsync(urlString);
                return result;
            }
            catch (UriFormatException)
            {
                return $"Invalid URL format: '{urlString}'. Please enter a full URL (e.g., http://example.com).";
            }
        }
    }
}