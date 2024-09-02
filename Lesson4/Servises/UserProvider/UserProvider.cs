using Lesson4.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Servises.UserProvider
{
    internal class UserProvider : IUserProvider
    {
        private List<IUser> _UsersRepo = [];

        public IUser CreateUser(string name, string hashPassword)
        {
            IUser user = new User(name, hashPassword);
            _UsersRepo.Add(user);
            return user;
        }

        public void DeleteUser(int id)
        {
            foreach (IUser user in _UsersRepo)
            {
                if (user.GetId() == id)
                {
                    _UsersRepo.Remove(user);
                    return;
                }
            }
        }

        public IUser GetUser(int id)
        {
            foreach (IUser user in _UsersRepo)
            {
                if (user.GetId() == id)
                    return user;
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
