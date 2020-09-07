using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library.DataAccess.Interface;
using library.Models;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipController : Controller
    {
        private ITipDao TipDao;

        public TipController(ITipDao tipDao)
        {
            TipDao = tipDao;
        }

        //如果有超期图书，进行提示
        [HttpGet("{id}")]
        public ActionResult<bool> Create(long reader_id)
        {
            List<Borrows> borlist = new List<Borrows>();
            long max = borlist.Max(t => t.borrow_id);
            var borrowtime = TipDao.GetBorrowByID(reader_id);
            long borrowtime_id = borrowtime.time_slot_id;
            var _borrow = TipDao.GetByID(borrowtime_id);
            if(_borrow.end_time.Year<DateTime.Now.Year)
            {
                return true;//已超期
            }
            else if(_borrow.end_time.Year == DateTime.Now.Year)
             {
                 if(_borrow.end_time.Month < DateTime.Now.Month)
                 {
                    return true;//已超期
                 }
                 else if(_borrow.end_time.Month == DateTime.Now.Month)
                {
                    if(_borrow.end_time.Day < DateTime.Now.Day)
                    {
                        return true;//已超期
                    }
                }
             }
            return false;//无超期图书
        }
    }
}
