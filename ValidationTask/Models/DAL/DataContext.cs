using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ValidationTask.Models.DAL
{
    public class DataContext:DbContext
    {
        public DataContext():base ("VTASK")
        {

        }

        public DbSet<UserData> UserData { get; set; }
    }
}