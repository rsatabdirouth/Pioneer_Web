using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace ProjectOnPioneerWeb_publish.Models
{
    
    public class PioneerContext : DbContext
    {
         public PioneerContext() 
            :base("name = DBConnectionString")
            //base(@"Data Source=USER-PC\SQL2014;Initial Catalog=PioneerDatabase;trusted_connection=true")
           // public PioneerContext() : base("name="connectionString")
       
        {

        }
       
        public DbSet<PioneerData> PioneerDatas { get; set; }
    }
}
