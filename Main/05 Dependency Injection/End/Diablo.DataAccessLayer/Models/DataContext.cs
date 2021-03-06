﻿using System.Data.Entity;
using System.Data.Entity.Infrastructure;
//using System.Data.Objects;
//using System.Data.Objects.DataClasses;
using System.Linq;

using Diablo.DataAccessLayer.Repo;

namespace Diablo.DataAccessLayer.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {

        }

        public DataContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.DatabaseGeneratedAttributeConvention>();
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<People> People { get; set; }
     
    }
}
