using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LifeMatch.LifeMatchModels;

namespace LifeMatch.DBClient
{
    // user module
    public class UserInfoManagement
    {
        public UserInfoManagement() { }

        public UserModel GetUserById(int userId)
        {
            // run get query
            return null;
        }

        public void InsertNewUser(UserModel newUser)
        {
            // run insert query
        }

        public void UpdateUserById(UserModel updatedUserData)
        {
            // run update query
        }
    }
}