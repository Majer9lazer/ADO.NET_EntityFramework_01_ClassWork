using DBFirstApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            hMalServerEntities db = new hMalServerEntities();
            SE_Laboratories lab = new SE_Laboratories();
            lab.lab_adress = "dsfcdsfd";
            lab.lab_name = "SomeabName";
            lab.lab_timings = "";
            db.SE_Laboratories.Add(lab);
            db.SaveChanges();
       
            foreach (SE_Laboratories item in db.SE_Laboratories)
            {
                Console.WriteLine("{0} , {1}", item.cityid, item.lab_name);
            }
        }
    }
}
