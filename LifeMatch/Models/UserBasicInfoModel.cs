using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeMatch.Models
{
    public class UserBasicInfoModel
    {
        // user info scheme
        public int UserId;
        public Enums.Gender Gender;
        public int Age;
        public string Name;
        public string LastName;
        public string NickName;
        public string FacebookId;

        public UserBasicInfoModel()
        {
        }

        public UserBasicInfoModel(UserBasicInfoModel user)
        {
            UserId = user.UserId;
            Gender = user.Gender;
            Age = user.Age;
            Name = user.Name;
            LastName = user.LastName;
            NickName = user.NickName;
            FacebookId = user.FacebookId;
        }

        // add queries to get, create, update and delete queries.
    }
}