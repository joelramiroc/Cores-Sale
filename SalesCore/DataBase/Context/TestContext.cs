using DataBase.Model;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

namespace DataBase.Context
{
    public class TestContext : DbContext
    {        

        public TestContext() : base("TestsDataBase")
        {
        }

        public TestContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            this.Database.Log += s => Debug.Write(s);            
        }

        public TestContext(string nameOrConnectionString, DbCompiledModel model)
            : base(nameOrConnectionString, model)
        {
            this.Database.Log += s => Debug.Write(s);            
        }

        public DbSet<Test> Tests { get; set; }
    }
}
