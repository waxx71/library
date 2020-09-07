using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Interface
{
    public interface ILoseFineDao
    {
        //插入数据
        bool CreateViolation(Violation violation);
    }
}
