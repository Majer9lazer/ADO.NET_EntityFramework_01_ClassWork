using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_EntityFramework_01.Model
{
    public class User
    {

        
        public int UserId { get; set; }
        public string SID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? intLovationId { get; set; }

    }
}
