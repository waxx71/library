using library.DataAccess.Base;
using library.DataAccess.Interface;
using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Implement
{
    public class LoseFineDao : ILoseFineDao
    {
        public LabContext Context;

        public LoseFineDao(LabContext context)
        {
            Context = context;
        }

        //插入数据
        public bool CreateViolation(Violation violation)
        {
            Context.Violation.Add(violation);
            return Context.SaveChanges() > 0;
        }
    }
}
