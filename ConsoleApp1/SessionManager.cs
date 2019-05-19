using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;

namespace ConsoleApp1
{
    public class SessionManager
    {
        ConcurrentDictionary<string, UserSession> dic;
        UserSession session = new UserSession();
        public UserSession GetSession(string clientId)
        {
            return dic[clientId];
        }
    }
}
