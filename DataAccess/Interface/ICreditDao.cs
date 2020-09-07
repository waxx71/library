using library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Interface
{
    public interface ICreditDao
    {
        //通过借书记录ID获取还书时间戳ID
        Returns GetTimeByID(long id);

        //通过还书时间戳ID获取开始结束的时间
        Timeslot GetByID(long id);

        //信誉积分减少
        bool Fine(long id);

        //信誉积分增加
        bool Reward(long id);
    }
}
