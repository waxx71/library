using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library.DataAccess.Base;
using library.DataAccess.Interface;
using library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FineController : ControllerBase
    {
        private IFineDao FineDao;

        public FineController(IFineDao fineDao)
        {
            FineDao = fineDao;
        }

        //还书时进行罚款生成
        [HttpGet("{id}")]
        public ActionResult<bool> Create(long borrow_id)
        {
            List<Violation> violist = new List<Violation>();
            long max = violist.Max(t => t.violation_id);
            var borrowtime = FineDao.GetBorrowByID(borrow_id);
            var returntime= FineDao.GetReturnByID(borrow_id);
            long borrowtime_id = borrowtime.time_slot_id;
            long returntime_id = returntime.time_slot_id;
            var _borrow = FineDao.GetByID(borrowtime_id);
            var _return = FineDao.GetByID(returntime_id);
            TimeSpan ts = _return.end_time.Subtract(_borrow.end_time);
            int fine = ts.Days;
            var violation = new Violation()
            {
                violation_id = max,
                borrow_id = borrow_id,
                type = "delay",
                fine = fine
            };
            var result = FineDao.CreateViolation(violation);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
