using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library.DataAccess.Interface;
using library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : Controller
    {
        private IBorrowDao BorrowDao;

        public BorrowController(IBorrowDao borrowDao)
        {
            BorrowDao = borrowDao;
        }

        //取某id记录
        [HttpGet("{name}")]
        public ActionResult<int> Get(string name)
        {
            List<Borrows> borlist = new List<Borrows>();
            var book = BorrowDao.GetID(name);
            return borlist.Count(x => x.book_id == book.book_id);
        }
    }
}
