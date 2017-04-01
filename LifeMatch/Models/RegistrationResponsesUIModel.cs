using System.Collections.Generic;

namespace LifeMatch.Models
{
    public class RegistrationResponsesUIModel
    {
        public string Name { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Year { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AboutMe { get; set; }
        public string Relation { get; set; }
        public string PartnerAgesStart { get; set; }
        public string PartnerAgesEnd { get; set; }
        public string AboutPartner { get; set; }
        public List<InterestModel> SelectedInterests { get; set; }
    }
}