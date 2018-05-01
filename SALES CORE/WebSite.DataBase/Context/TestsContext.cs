using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using log4net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.DataBase.Model;

namespace WebSite.DataBase.Context
{
    public class TestsContext : DbContext
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TestsContext));

        public TestsContext() : base("TestsDataBase")
        {
        }

        public TestsContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            this.Database.Log += s => Debug.Write(s);            
        }

        public TestsContext(string nameOrConnectionString, DbCompiledModel model)
            : base(nameOrConnectionString, model)
        {
            this.Database.Log += s => Debug.Write(s);            
        }

        public DbSet<Tests> Tests { get; set; }
    }
}
