using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeMatch.Models
{
    public class TablesHelper
    {
        public static string GetTableColumnsToInsert(string tableName)
        {
            if (tableName == TableName.UserInfo)
            {
                return 
                    "(username,email,password,facebook_id,date_of_birth,country,city,about_user,gender,partner_gender,partner_age_start,partner_age_end,about_partner)";
            }

            //TODO - log that there's no such table 
            return string.Empty;
        }

        public static List<DBDataUnit> GetTableDataUnitsTemplates(string tableName)
        {
            if (tableName == TableName.UserInfo)
            {
                return new List<DBDataUnit>
                {
                    new DBDataUnit { ColumnName = "id", Type = Enums.ColumnType.Integer} ,
                    new DBDataUnit { ColumnName = "username", Type = Enums.ColumnType.String} ,
                    new DBDataUnit { ColumnName = "password", Type = Enums.ColumnType.String} ,
                    new DBDataUnit { ColumnName = "email", Type = Enums.ColumnType.String} ,
                    new DBDataUnit { ColumnName = "facebook_id", Type = Enums.ColumnType.Integer} ,
                    new DBDataUnit { ColumnName = "date_of_birth", Type = Enums.ColumnType.Date} ,
                    new DBDataUnit { ColumnName = "country", Type = Enums.ColumnType.String} ,
                    new DBDataUnit { ColumnName = "city", Type = Enums.ColumnType.String} ,
                    new DBDataUnit { ColumnName = "about_user", Type = Enums.ColumnType.String} ,
                    new DBDataUnit { ColumnName = "gender", Type = Enums.ColumnType.Integer} ,
                    new DBDataUnit { ColumnName = "partner_gender", Type = Enums.ColumnType.Integer} ,
                    new DBDataUnit { ColumnName = "partner_age_start", Type = Enums.ColumnType.Integer} ,
                    new DBDataUnit { ColumnName = "partner_age_end", Type = Enums.ColumnType.Integer} ,
                    new DBDataUnit { ColumnName = "about_partner", Type = Enums.ColumnType.String} ,
                    new DBDataUnit { ColumnName = "create_date", Type = Enums.ColumnType.Date} ,
                };
            }

            //TODO - log that there's no such table 
            return null;
        }
    }
}