using ModelFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            HmailServerContainer db = new HmailServerContainer();
            MfUsers user = new MfUsers();
            for (int i = 1; i > 0; i++)
            {
                user.DOB = DateTime.Now.AddDays(9);
                user.MFUserName = "EGORBEST_" + i;
                db.MfUsersSet.Add(user);
                db.SaveChanges();
                Console.WriteLine("{0} , {1}", user.Id, user.MFUserName);
            }
            //Parallel.For(0, 1000000, i => 
            //{
            //    user.DOB = DateTime.Now.AddDays(9);
            //    user.MFUserName = "EGORBEST_" + i;
            //    db.MfUsersSet.Add(user);
            //    db.SaveChanges();
            //});
        
            //foreach (var item in db.MfUsersSet)
            //{
            //    Console.WriteLine("{0}, {1}",item.DOB,item.MFUserName);
            //}
        }
    }
}
