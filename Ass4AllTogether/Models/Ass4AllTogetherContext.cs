using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Ass4AllTogether.Models
{
    public class Ass4AllTogetherContext:DbContext
    {
        public Ass4AllTogetherContext() : base("name=Ass4AllTogetherContext")
        {
        }

        public System.Data.Entity.DbSet<Ass4AllTogether.Models.Products> Products { get; set; }

        public System.Data.Entity.DbSet<Ass4AllTogether.Models.Orders> Orders { get; set; }

        public System.Data.Entity.DbSet<Ass4AllTogether.Models.OrderDetails> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<Ass4AllTogether.Models.CourseRoster> CourseRosters { get; set; }

        public System.Data.Entity.DbSet<Ass4AllTogether.Models.Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<MenuGroup>().HasOptional(m => m.Menu).WithOptionalDependent().WillCascadeOnDelete(false);

            // modelBuilder.Entity<MenuItem>().HasOptional(m => m.Menu).WithOptionalDependent().WillCascadeOnDelete(false);
            // modelBuilder.Entity<MenuItem>().HasOptional(m => m.MenuGroup).WithOptionalDependent().WillCascadeOnDelete(false);


            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Ass4AllTogether.Models.Course> Courses { get; set; }
    }
}