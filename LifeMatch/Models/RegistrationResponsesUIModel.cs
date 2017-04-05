using System.Collections.Generic;

namespace LifeMatch.Models
{
    public class RegistrationResponsesUIModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Enums.Month Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AboutMe { get; set; }
        public string Relation { get; set; }
        public int PartnerAgesStart { get; set; }
        public int PartnerAgesEnd { get; set; }
        public string AboutPartner { get; set; }
        public List<InterestModel> SelectedInterests { get; set; }
    }
}