using library.DataAccess.Base;
using library.DataAccess.Interface;
using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Implement
{
    public class CreditDao : ICreditDao
    {
        public LabContext Context;

        public CreditDao(LabContext context)
        {
            Context = context;
        }

        //通过借书记录ID获取还书时间戳ID
        public Returns GetTimeByID(long id)
        {
            return Context.Returns.SingleOrDefault(s => s.borrow_id == id);
        }

        //通过还书时间戳ID获取开始结束的时间
        public Timeslot GetByID(long id)
        {
            return Context.Timeslot.SingleOrDefault(s => s.time_slot_id == id);
        }

        //根据id减少信誉积分
        public bool Fine(long id)
        {
                var state = false;
                var student = Context.Reader.SingleOrDefault(s => s.reader_id  == id);

                if (student != null)
                {
                    student.credit -= 10;
                    state = Context.SaveChanges() > 0;
                }
                return state;
        }

        //根据id增加信誉积分
        public bool Reward(long id)
        {
            var state = false;
            var student = Context.Reader.SingleOrDefault(s => s.reader_id == id);

            if (student != null)
            {
                student.credit ++;
                state = Context.SaveChanges() > 0;
            }
            return state;
        }

    }
}
