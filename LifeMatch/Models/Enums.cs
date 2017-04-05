﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeMatch.Models
{
    public class Enums
    {
        public enum Gender
        {
            Male,
            Female
        }

        public enum ColumnType
        {
            String,
            Integer,
            Date,
            Enum
        }

        public enum MySqlOperation
        {
            SELECT, INSERT, UPDATE, DELETE
        }

        public enum Relation
        {
            ManLookingForWoman, WomanLookingForMan, ManLookingForMan, WomanLookingForWoman
        }

        public enum Month : int
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

    }
}