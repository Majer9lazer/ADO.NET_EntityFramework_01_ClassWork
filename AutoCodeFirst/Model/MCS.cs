namespace AutoCodeFirst.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MCS : DbContext
    {
        public MCS()
            : base("name=MCS")
        {
        }

        public virtual DbSet<TrackEvaluation> TrackEvaluations { get; set; }
        public virtual DbSet<TrackEvaluationComment> TrackEvaluationComments { get; set; }
        public virtual DbSet<TrackEvaluationHistory> TrackEvaluationHistories { get; set; }
        public virtual DbSet<TrackEvaluationPart> TrackEvaluationParts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
