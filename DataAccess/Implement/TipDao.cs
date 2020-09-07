using library.DataAccess.Base;
using library.DataAccess.Interface;
using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Implement
{
    public class TipDao : ITipDao
    {
        public LabContext Context;

        public TipDao(LabContext context)
        {
            Context = context;
        }

        //通过借书记录ID获取借书时间戳ID
        public Borrows GetBorrowByID(long id)
        {
            return Context.Borrows.SingleOrDefault(s => s.borrow_id == id);
        }

        //通过还书时间戳ID获取开始结束的时间
        public Timeslot GetByID(long id)
        {
            return Context.Timeslot.SingleOrDefault(s => s.time_slot_id == id);
        }
    }
}
