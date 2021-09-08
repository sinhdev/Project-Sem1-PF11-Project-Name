using System;
using LoginDal;
using Persistance;
namespace LoginBl
{
    public class UserBl
    {
        private UserDal dal = new UserDal();
        public User Login(string userName, string password){
            return dal.Login(userName, password);
        }
    }
}
