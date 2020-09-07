using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Interface
{
    public interface IBorrowDao
    {
        //取某id记录
        Book GetID(string name);
    }
}
