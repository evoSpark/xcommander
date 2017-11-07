using System.Collections.Generic;

namespace ArduinoXCommander.Models.UnitOfWork
{
    public interface IAuthorizationUnitOfWork
    {
        User Authorize(string username, string password);

        List<string> GetDeviceTokens(string username);
    }
}