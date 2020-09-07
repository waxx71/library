using library.DataAccess.Base;
using library.DataAccess.Interface;
using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Implement
{
    public class SumDao : ISumDao
    {
        public LabContext Context;

        public SumDao(LabContext context)
        {
            Context = context;
        }

        //取某id记录
        public Borrows GetBook(long id)
        {
            return Context.Borrows.SingleOrDefault(s => s.borrow_id == id);
        }
        //取某id记录
        public Book GetBookName(long id)
        {
            return Context.Book.SingleOrDefault(s => s.book_id == id);
        }

    }
}
