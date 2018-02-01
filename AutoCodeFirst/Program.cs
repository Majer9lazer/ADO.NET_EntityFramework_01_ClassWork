using AutoCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MCS db = new MCS();
            //db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));
            //List<TrackEvaluation> evaluation =
            //    db.TrackEvaluations.Include()
            //явная загрузка
            //var evals = db.TrackEvaluations.Select(s => s).Load() ;
        }
    }
}
