using DataBase.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer
{
    public class InitializerDb : CreateDatabaseIfNotExists<TestContext>
    {

        protected override void Seed(TestContext context)
        {
            base.Seed(context);
        }
    }
}
