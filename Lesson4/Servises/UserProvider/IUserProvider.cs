using Lesson4.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Servises.UserProvider
{
    internal interface IUserProvider
    {
        public IUser CreateUser(string name, string password);
        public void DeleteUser(int id);
        public IUser GetUser(int id);
        public List<IUser> GetUsers();
        public static abstract string CalculateHash(string password);
    }
}
