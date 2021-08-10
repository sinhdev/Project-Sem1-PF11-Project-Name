using System;
using Xunit;
using LoginDal;

namespace LoginDalTest
{
    public class UserDalTest
    {
        [Fact]
        public void LoginTest1()
        {
            UserDal dal = new UserDal();
            string userName = "pf11";
            string password = "pf11VTCAcademy";
            
            int expected = UserDal.ACCOUNT_EXIST;
            int result = dal.Login(userName, password);
            Assert.True(expected == result, "Login successfuly!");
        }
    }
}
