using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoXCommander.Models
{
    public interface IUserRepository
    {
        List<User> GetAll();

        User Get(string username, string password);
    }
}
