using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeMatch.Models
{
    public class MemberModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string YearOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AboutMember { get; set; }
        public Enums.Gender Gender { get; set; }
        public Enums.Gender PartnerGender { get; set; }
        public int PartnerAgesStart { get; set; }
        public int PartnerAgesEnd { get; set; }
        public string AboutPartner { get; set; }
        public List<InterestModel> SelectedInterests { get; set; }


        public MemberModel(List<DBDataUnit> memberDataFromDB)
        {
            InitializeWithDBDataUnitsList(memberDataFromDB);
        }


        private void InitializeWithDBDataUnitsList(List<DBDataUnit> memberDataFromDB)
        {
            var idFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "id");
            Id = idFromDb?.Value != null ? Convert.ToInt32(idFromDb.Value) : 0;

            var userNameFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "username");
            UserName = userNameFromDb?.Value != null ? Convert.ToString(userNameFromDb.Value) : "";

            var emailFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "email");
            Email = emailFromDb?.Value != null ? Convert.ToString(emailFromDb.Value) : "";

            var passwordFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "password");
            Password = passwordFromDb?.Value != null ? Convert.ToString(passwordFromDb.Value) : "";

            var createDateFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "date_of_birth");
            CreateDate = createDateFromDb?.Value != null ? Convert.ToDateTime(createDateFromDb.Value) : DateTime.MinValue;

            var countryFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "country");
            Country = countryFromDb?.Value != null ? Convert.ToString(countryFromDb.Value) : "";

            var cityFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "city");
            City = cityFromDb?.Value != null ? Convert.ToString(cityFromDb.Value) : "";

            var aboutMemberFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "about_user");
            AboutMember = aboutMemberFromDb?.Value != null ? Convert.ToString(aboutMemberFromDb.Value) : "";

            var partnerAgesStartFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "partner_age_start");
            PartnerAgesStart = partnerAgesStartFromDb?.Value != null ? Convert.ToInt32(partnerAgesStartFromDb.Value) : 0;

            var partnerAgesEndFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "partner_age_end");
            PartnerAgesEnd = partnerAgesEndFromDb?.Value != null ? Convert.ToInt32(partnerAgesEndFromDb.Value) : 0;

            var aboutPartnerFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "about_user");
            AboutPartner = aboutPartnerFromDb?.Value != null ? Convert.ToString(aboutPartnerFromDb.Value) : "";

            var genderFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "gender");
            Gender = genderFromDb?.Value != null ? (Enums.Gender)Enum.Parse(typeof(Enums.Gender), genderFromDb.Value.ToString()) : Enums.Gender.Male;

            var interstedGenderFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "partner_gender");
            PartnerGender = interstedGenderFromDb?.Value != null ? (Enums.Gender)Enum.Parse(typeof(Enums.Gender), interstedGenderFromDb.Value.ToString()) : Enums.Gender.Female;

            var dateOfBirthFromDb = memberDataFromDB.FirstOrDefault(d => d.ColumnName == "date_of_birth");
            DateOfBirth = dateOfBirthFromDb?.Value != null ? Convert.ToDateTime(dateOfBirthFromDb.Value) : DateTime.MinValue;

            YearOfBirth = DateOfBirth.Year.ToString();
        }
    }
}