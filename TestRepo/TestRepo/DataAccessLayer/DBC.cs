using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestRepo.Models;

namespace TestRepo.DataAccessLayer
{
    public class DBC : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }

        public DBC() : base("TestDatabase123")
        {

        }
    }
}