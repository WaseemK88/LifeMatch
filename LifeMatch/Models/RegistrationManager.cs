using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace LifeMatch.Models
{
    public class RegistrationManager
    {
        public DBConnector.DBConnector DBConnector { get; set; }

        public RegistrationManager()
        {
            //TODO - fucking namespace crap, need to fix this shit somehow -
            DBConnector = LifeMatch.DBConnector.DBConnector.Instance();
        }

        public MemberModel RegisterMember(RegistrationResponsesUIModel registrationResponsesUIModel)
        {
            List<string> memberDataToInsert = new List<string>();
            memberDataToInsert.Add(registrationResponsesUIModel.Name);
            memberDataToInsert.Add(registrationResponsesUIModel.Email);
            memberDataToInsert.Add(registrationResponsesUIModel.Password);
            memberDataToInsert.Add(null); // TODO - facebook id - I'll deal with this later
            DateTime dob = new DateTime(
                registrationResponsesUIModel.Year, (int)registrationResponsesUIModel.Month, registrationResponsesUIModel.Day);
            memberDataToInsert.Add($"STR_TO_DATE('{dob.ToString(CultureInfo.InvariantCulture).Split(' ')[0]}', '%d/%m/%Y')");
            memberDataToInsert.Add(registrationResponsesUIModel.Country);
            memberDataToInsert.Add(registrationResponsesUIModel.City);
            memberDataToInsert.Add(registrationResponsesUIModel.AboutMe);

            if (registrationResponsesUIModel.Relation == "Man looking for a woman")
            {
                memberDataToInsert.Add("Male");
                memberDataToInsert.Add("Female");
            }
            else if (registrationResponsesUIModel.Relation == "Woman looking for a man")
            {
                memberDataToInsert.Add("Female");
                memberDataToInsert.Add("Male");
            }
            else if (registrationResponsesUIModel.Relation == "Man looking for a man")
            {
                memberDataToInsert.Add("Male");
                memberDataToInsert.Add("Male");
            }
            else if (registrationResponsesUIModel.Relation == "Woman looking for a woman")
            {
                memberDataToInsert.Add("Female");
                memberDataToInsert.Add("Female");
            }
            else
            {
                //TODO - log defect  
            }
            memberDataToInsert.Add(registrationResponsesUIModel.PartnerAgesStart.ToString());
            memberDataToInsert.Add(registrationResponsesUIModel.PartnerAgesEnd.ToString());
            memberDataToInsert.Add(registrationResponsesUIModel.AboutPartner);

            if (DBConnector.Insert(TableName.UserInfo, memberDataToInsert))
            {
                var result = DBConnector.Select(TableName.UserInfo, 
                    filter : $"username='{registrationResponsesUIModel.Name}'").FirstOrDefault();

                if (result != null)
                {
                    return new MemberModel(result);
                }

                //TODO - log defect
                return null;
            }

            //TODO - log defect
            return null;
        }
    }
}