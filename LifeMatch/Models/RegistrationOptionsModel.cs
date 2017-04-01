using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeMatch.Models
{
    public class RegistrationOptionsModel
    {
        public List<string> Interests { get; set; }
        public List<string> Relations { get; set; }
        public List<string> Days { get; set; }
        public List<string> Months { get; set; }
        public List<string> Years { get; set; }
        public List<string> Ages { get; set; }

        public RegistrationOptionsModel()
        {
            Ages = new List<string>
            {
                "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70"
            };

            Days = new List<string>
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"
            };

            Months = new List<string>
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };

            Years = new List<string>
            {
                "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997"
            };

            Relations = new List<string>
            {
                "Man looking for a woman", "Woman looking for a man", "Man looking for a man", "Woman looking for a woman"
            };

            Interests = new List<string>
            {
                "Aircraft Spotting",
                "Airbrushing",
                "Acting",
                "Airsofting",
                "Aeromodeling",
                "Amateur Astronomy",
                "Amateur Radio",
                "Animals/pets/dogs",
                "Archery",
                "Arts",
                "Aquarium",
                "Astrology",
                "Astronomy",
                "Backgammon",
                "Badminton",
                "Baseball",
                "Base Jumping",
                "Basketball",
                "Beach/Sun tanning",
                "Beachcombing",
                "Beadwork",
                "Beatboxing",
                "Bicycling",
                "Bird watching",
                "Birding",
                "BMX",
                "Blacksmithing",
                "Blogging",
                "BoardGames",
                "Boating",
                "Body Building",
                "Bonsai Tree",
                "Bookbinding",
                "Bowling",
                "Brewing Beer",
                "Bridge Building",
                "Cake Decorating",
                "Cartooning",
                "Casino Gambling",
                "Cave Diving",
                "Cheerleading",
                "Chess",
                "Church/church activities",
                "Cigar Smoking",
                "Collecting",
                "Coin Collecting",
                "Computer activities",
                "Conworlding",
                "Dancing",
                "Dolls",
                "Fishing",
                "Games",
                "Golf",
                "Gun Collecting",
                "Home Repair",
                "Hunting",
                "Internet",
                "Inventing",
                "Jewelry Making",
                "Kites",
                "Magic",
                "Martial Arts",
                "Models"
            };
        }
    }
}