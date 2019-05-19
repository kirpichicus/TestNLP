using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class UserQueryProcessor
    {
       public string parameter { get; set; }
       
       public void Parameter(string str)
       {
            var parsed = (new Parser()).TryParse(str);
       } 


    }
}
