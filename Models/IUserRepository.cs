using System.Collections.Generic;

namespace ArduinoXCommander.Models
{
    public interface IUserRepository
    {
        List<User> GetAll();

        User Get(string username, string password);
    }
}
