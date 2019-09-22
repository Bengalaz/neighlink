using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Entity;

namespace Data
{
    public class NeighlinkDBContext: DbContext
    {
        public NeighlinkDBContext(): base("neighlinkDBConnection")
        {
            Database.SetInitializer<NeighlinkDBContext>(new DropCreateDatabaseIfModelChanges<NeighlinkDBContext>());
        }

        public DbSet<Plan> Plans { get; set; }
    }
}
