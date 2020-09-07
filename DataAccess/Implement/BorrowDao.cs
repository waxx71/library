using library.DataAccess.Base;
using library.DataAccess.Interface;
using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Implement
{
    public class BorrowDao : IBorrowDao
    {
        public LabContext Context;

        public BorrowDao(LabContext context)
        {
            Context = context;
        }

        //取某id记录
        public Book GetID(string name)
        {
            return Context.Book.SingleOrDefault(s => s.name == name);
        }
    }
}
