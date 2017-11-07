using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace ArduinoXCommander.Helpers
{
    public static class HttpHelpers
    {
        public static HttpContent ToHttpContent(dynamic data, string mimeType = "application/json")
        {
            return new StringContent(JsonConvert.SerializeObject(data), Encoding.Default, mimeType);
        }

    }
}