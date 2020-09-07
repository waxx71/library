using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Interface
{
    public interface ITipDao
    {
        //通过借书ID获取借书时间戳ID
        Borrows GetBorrowByID(long id);
        //通过还书时间戳ID获取开始结束的时间
        Timeslot GetByID(long id);

    }
}
