using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TSupport.Models;

namespace TSupport
{
    public class appContext : DbContext
    {
        public DbSet<Proba> Proba { get; set; }

        public appContext() : base("ConnString")
        {

        }

    }
}