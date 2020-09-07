using library.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Interface
{
    public interface ISumDao
    {

        //取某id记录
        Borrows GetBook(long id);
        //取某id记录
        Book GetBookName(long id);
    }
}
