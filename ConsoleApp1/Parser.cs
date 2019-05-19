using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Parser
    {
        public ParsedUserQuery TryParse(string userText)
        {
            var result = new ParsedUserQuery ( 
                Action = Actions.Add,
                ItemCount = 1, 
                ItemString = "apple", 
                Unit = new Unit() { ShortName = "items" } );
            return result;
        }
    }
}
