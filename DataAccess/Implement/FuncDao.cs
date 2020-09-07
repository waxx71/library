using library.DataAccess.Base;
using library.DataAccess.Interface;
using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Implement
{
    public class FuncDao : IFuncDao
    {
        public LabContext Context;

        public FuncDao(LabContext context)
        {
            Context = context;
        }

        //取某id记录
        public Reader GetCreditByID(long id)
        {
            return Context.Reader.SingleOrDefault(s => s.reader_id == id);
        }
    }
}
