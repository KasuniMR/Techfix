using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechFix
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=KASUNI\SQLEXPRESS;Initial Catalog=techfixdb;Integrated Security=True";
            return con;

        }
        
    }
}
