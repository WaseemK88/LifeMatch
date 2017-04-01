using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeMatch.Models.ObjectMappers
{
    public class RegistrationResponsesMapper
    {
        public static RegistrationResponsesBEModel MapRegistrationResponses(RegistrationResponsesUIModel registrationResponsesUIModel)
        {
            Enums.Relation relation = MapRelation(registrationResponsesUIModel.Relation);

            int day;
            if (!int.TryParse(registrationResponsesUIModel.Day, out day))
            {
                //TODO: Log defect
                day = 1;
            }
            Enums.Month monthEnum;
            int month;
            if (!Enum.TryParse(registrationResponsesUIModel.Month, out monthEnum))
            {
                //TODO: Log defect
                month = 1;
            }
            month = (int)monthEnum;
            int year;
            if (!int.TryParse(registrationResponsesUIModel.Year, out year))
            {
                //TODO: Log defect
                year = 1980;
            }
            DateTime dateOfBirth = new DateTime(year, month, day);

            int partnerAgesStart;
            if (!int.TryParse(registrationResponsesUIModel.PartnerAgesStart, out partnerAgesStart))
            {
                //TODO: Log defect
                partnerAgesStart = 20;
            }
            int partnerAgesEnd;
            if (!int.TryParse(registrationResponsesUIModel.PartnerAgesEnd, out partnerAgesEnd))
            {
                //TODO: Log defect
                year = 30;
            }

            return new RegistrationResponsesBEModel
            {
                Name = registrationResponsesUIModel.Name,
                DateOfBirth = dateOfBirth,
                Country = registrationResponsesUIModel.Country,
                City = registrationResponsesUIModel.City,
                AboutMe = registrationResponsesUIModel.AboutMe,
                Relation = relation,
                PartnerAgesStart = partnerAgesStart,
                PartnerAgesEnd = partnerAgesEnd
            };
        }


        private static Enums.Relation MapRelation(string relationStr)
        {
            switch (relationStr)
            {
                case "Man looking for a woman":
                    return Enums.Relation.ManLookingForWoman;
                case "Woman looking for a man":
                    return Enums.Relation.WomanLookingForMan;
                case "Man looking for a man":
                    return Enums.Relation.ManLookingForWoman;
                case "Woman looking for a woman":
                    return Enums.Relation.WomanLookingForWoman;
                default:
                    //TODO - Log defect
                    return Enums.Relation.ManLookingForWoman;
            }
        }
    }
}