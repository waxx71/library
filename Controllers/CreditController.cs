using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using library.DataAccess.Implement;
using library.DataAccess.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditController : Controller
    {
        private ICreditDao CreditDao;

        public CreditController(ICreditDao creditDao)
        {
            CreditDao = creditDao;
        }

        //取某id记录
        [HttpGet("{id}")]
        public ActionResult<string> Get(long id)
        {
            var vic = "信誉积分修改成功";
            var fault = "信誉积分修改失败";
            var time = CreditDao.GetTimeByID(id);
            if (time != null)
            {
                long word = time.time_slot_id;
                var iffine = CreditDao.GetByID(word);
                TimeSpan ts = iffine.end_time.Subtract(iffine.start_time);
                if (ts.Days>30)
                {
                    //延期，扣10分
                    CreditDao.Fine(time.reader_id);
                }
                else
                {
                    //按期，加1分
                    CreditDao.Reward(time.reader_id);
                }
                return vic;
            }
            return fault;
        }
    }
}
