using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArduinoXCommander.Models
{
    public class UserRepository : IUserRepository
    {
        private const string DATA_FILE = @"C:\PROJECTS\ArduinoXCommander\ArduinoXCommander\ArduinoXCommander\MockData\Users.json";

        private readonly List<User> _users;

        public UserRepository()
        {
            try
            {
                var jsonInFile = File.ReadAllText(DATA_FILE);

                _users = JsonConvert.DeserializeObject<List<User>>(jsonInFile);
            }
            catch (Exception ex)
            {
                throw new Exception(
                   String.Format("Failed to initialize ReviewerRepository from {0}", DATA_FILE)
               );
            }
        }

        public User Get(string username, string password)
        {
            return _users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }

        public List<User> GetAll()
        {
            return _users;
        }
    }
}