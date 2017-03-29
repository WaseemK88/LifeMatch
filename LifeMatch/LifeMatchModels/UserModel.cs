using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LifeMatch.Models;

namespace LifeMatch.LifeMatchModels
{
    // user info scheme
    public class UserModel
    {
        public int UserId;
        public Enums.Gender Gender;
        public int Age; 
        public string Name;
        public string LastName;
        public string NickName;
        public string FacebookId;

        public UserModel() { }

        public UserModel(UserModel user)
        {
            UserId = user.UserId;
            Gender = user.Gender;
            Age = user.Age;
            Name = user.Name;
            LastName = user.LastName;
            NickName = user.NickName;
            FacebookId = user.FacebookId;
        }
    }
}