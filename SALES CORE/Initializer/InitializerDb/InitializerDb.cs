using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.DataBase.Context;

namespace Initializer.InitializerDb
{
    public class InitializerDb : CreateDatabaseIfNotExists<TestsContext>
    {

        protected override void Seed(TestsContext context)
        {
            base.Seed(context);
        }
    }
}
