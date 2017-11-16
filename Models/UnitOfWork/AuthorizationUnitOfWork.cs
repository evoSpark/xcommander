using System;
using System.Collections.Generic;

namespace ArduinoXCommander.Models.UnitOfWork
{
    public class AuthorizationUnitOfWork : IAuthorizationUnitOfWork
    {
        private UserRepository _repository = new UserRepository();
        public User Authorize(string username, string password)
        {
            return _repository.Get(username, password);
        }

        public List<string> GetDeviceTokens(string username)
        {
            throw new NotImplementedException();
        }
    }
}