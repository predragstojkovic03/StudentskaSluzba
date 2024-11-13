using DAL;
using Domain;
using System.Diagnostics;

namespace BusinessLogic
{
    public class UsersService
    {
        private UsersManager _usersManager;
        public UsersService()
        {
            _usersManager = new UsersManager();
        }

        public User LoginUser(string email, string password)
        {
            try
            {
            // pronadji usera sa emaliom
                var user = _usersManager.FindUserByEmail(email);
                // == password, ako ne -> greska
                if (user.Password != password)
                    throw new UnauthorizedAccessException();

                return user;
            }
            catch
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}
