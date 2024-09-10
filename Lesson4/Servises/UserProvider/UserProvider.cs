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

        public static string CalculateHash(string password)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in password)
            {
                stringBuilder.Append(c ^ 0x0fa5e);
            }
            return stringBuilder.ToString();
        }

        public IUser CreateUser(string name, string password)
        {
            IUser user = new User(name, CalculateHash(password));
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

        public List<IUser> GetUsers()=>_UsersRepo.ToList();
    }
}
