using ADO.NET_EntityFramework_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_EntityFramework_01
{
    class Program
    {
      // private static mcsEntity Db = new mcsEntity();
        static void Main(string[] args)
        {
            try
            {
                using (mcsEntity Db = new mcsEntity())
                {
                    foreach (User user in Db.Users.OrderBy(o=>o.UserId).ToList())
                    {
                        Console.WriteLine("{0}.{1} {2}",user.UserId,user.FirstName,user.LastName);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("{Message --> {0}\nStackTrace -->{1}}",ex.Message,ex.StackTrace);
            }
        }
    }
}
