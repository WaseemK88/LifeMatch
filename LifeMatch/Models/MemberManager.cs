using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeMatch.Models
{
    public class MemberManager
    {
        public DBConnector.DBConnector DBConnector { get; set; }

        public MemberManager()
        {
            //TODO - fucking namespace crap, need to fix this shit somehow -
            DBConnector = LifeMatch.DBConnector.DBConnector.Instance();
        }

        public MemberModel GetMemberById(int memberId)
        {
            var result = DBConnector.Select(TableName.UserInfo,
                    filter: $"id={memberId}").FirstOrDefault();

            if (result != null)
            {
                return new MemberModel(result);
            }

            //TODO - log defect
            return null;
        }
    }
}