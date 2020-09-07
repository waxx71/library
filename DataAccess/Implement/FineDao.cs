using library.DataAccess.Base;
using library.DataAccess.Interface;
using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Implement
{
    public class FineDao : IFineDao
    {
        public LabContext Context;

        public FineDao(LabContext context)
        {
            Context = context;
        }

        //插入数据
        public bool CreateViolation (Violation violation)
        {
            Context.Violation.Add(violation);
            return Context.SaveChanges() > 0;
        }

        //通过借书记录ID获取还书时间戳ID
        public Returns GetReturnByID(long id)
        {
            return Context.Returns.SingleOrDefault(s => s.borrow_id == id);
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
