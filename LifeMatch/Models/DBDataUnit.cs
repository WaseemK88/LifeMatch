using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeMatch.Models
{
    public class DBDataUnit
    {
        public string ColumnName { get; set; }
        public object Value { get; set; }
        public Enums.ColumnType Type { get; set; }
    }
}