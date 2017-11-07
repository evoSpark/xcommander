using System.Collections.Generic;

namespace ArduinoXCommander.Models
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public List<string> DeviceTokens { get; set; }

        public bool IsActive { get; set; }

    }
}