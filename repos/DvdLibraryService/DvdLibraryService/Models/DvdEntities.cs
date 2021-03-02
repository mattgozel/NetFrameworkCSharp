using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DvdLibraryService.Models
{
    public class DvdEntities : DbContext
    {
        public DvdEntities()
            : base("Dvds")
        {
        }

        public DbSet<Dvd> Dvd { get; set; }
    }
}