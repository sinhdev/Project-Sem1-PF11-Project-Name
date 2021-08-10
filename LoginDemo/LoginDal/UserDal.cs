using System;
using MySql.Data.MySqlClient;

namespace LoginDal
{
    public class UserDal
    {
        public static int USER_ERROR = -1;
        public static int ACCOUNT_WRONG = 0;
        public static int ACCOUNT_EXIST = 1;
        // 0: account wrong
        // 1: ok
        // -1: can't connect to db or error
        public int Login(string userName, string password){
            int loginReturn;
            try{
                MySqlConnection connection = DbHelper.GetConnection();
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "select * from Users where user_account='"+userName+"' and user_pass='"+Md5Algorithms.CreateMD5(password)+"';";
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.Read()){
                    loginReturn = ACCOUNT_EXIST;
                } else {
                    loginReturn = ACCOUNT_WRONG;
                }
                reader.Close();
                connection.Close();
            }catch{
                loginReturn = USER_ERROR;
            }
            return loginReturn;
        }
    }
}
