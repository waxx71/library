using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Interface
{
    public interface IFineDao
    {
        //插入数据
        bool CreateViolation(Violation violation);
        //通过借书ID获取借书时间戳ID
        Borrows GetBorrowByID(long id);
        //通过借书ID获取还书时间戳ID
        Returns GetReturnByID(long id);
        //通过还书时间戳ID获取开始结束的时间
        Timeslot GetByID(long id);
    }
}
