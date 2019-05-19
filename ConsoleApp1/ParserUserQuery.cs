using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum Actions
    {
        Add,
        deleteLast,
        readAll,
        clearAll
    }
     //добавить 6 кг лимонов - 
        public class ParsedUserQuery
        {

        public ParsedUserQuery(Actions action, string itemString, double itemCount, Unit unit)
        {
            Action = action;
            ItemString = itemString;
            ItemCount = itemCount;
            Unit = unit;
        }

        public Actions Action { get; set; }
        public string ItemString { get; set; }

        public double ItemCount { get; set; }

            public Unit Unit { get; set; }
        }
    
}
