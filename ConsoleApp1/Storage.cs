using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Storage
    {
        List<ParsedUserQuery> storage;
        Stack<ParsedUserQuery> history;

        public void Add(ParsedUserQuery query)
        {

        }
        public void DeleteLast()
        {

        }
        public List<ParsedUserQuery> ReadAll()
        {
            return  storage;
        }
        public void ClearAll()
        {
            storage.Clear();
        }

    }
}
