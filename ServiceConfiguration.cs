using Newtonsoft.Json;

namespace ArduinoXCommander
{
    public class ServiceConfiguration
    {
        public const string SERVICE_NAME = "X-ArduinoCommander";
        public static object ServiceInfo
        {

            get
            {
                return new
                {
                    Name = SERVICE_NAME
                };
            }
        }

        public static string AsJson
        {
            get
            {
                return JsonConvert.SerializeObject(ServiceInfo);
            }
        }
    }
}