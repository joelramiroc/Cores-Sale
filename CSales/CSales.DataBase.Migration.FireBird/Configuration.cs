using CSales.Database.Contexts;
using CSales.DataBase.Migration.Seed;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.CSales.Database.Migration.FireBird
{
    internal class Configuration : DbMigrationsConfiguration<MyContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.SetSqlGenerator("FirebirdSql.Data.FirebirdClient", new SqlServerMigrationSqlGenerator());
        }

        protected override void Seed(MyContext myContext)
        {
            DataProductionSeed.Seed(myContext);
            myContext.SaveChanges();
        }
    }
}
