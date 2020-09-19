using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParcialSebastianFerrufino.Models
{
    public class DataContext: DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialSebastianFerrufino.Models.Country> Countries { get; set; }
    }
}