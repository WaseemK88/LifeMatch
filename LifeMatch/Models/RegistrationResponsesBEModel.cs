using System;

namespace LifeMatch.Models
{
    public class RegistrationResponsesBEModel
    {
        public string Name { get; set; }
        public Enums.Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AboutMe { get; set; }
        public Enums.Relation Relation { get; set; }
        public int PartnerAgesStart { get; set; }
        public int PartnerAgesEnd { get; set; }
        public string AboutPartner { get; set; }
    }
}