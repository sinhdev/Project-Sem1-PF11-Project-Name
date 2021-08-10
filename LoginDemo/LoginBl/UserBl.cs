using System;
using LoginDal;

namespace LoginBl
{
    public class UserBl
    {
        private UserDal dal = new UserDal();
        public bool Login(string userName, string password){
            return dal.Login(userName, password) > 0;
        }
    }
}
