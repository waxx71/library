using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library.DataAccess.Interface;
using library.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumController : Controller
    {
        private ISumDao SumDao;

        public SumController(ISumDao sumDao)
        {
            SumDao = sumDao;
        }

        //取记录
        [HttpGet]
        public ActionResult<Dictionary<int,string>> Get()
        {
            List<string> name = new List<string>();
            List<long> id = new List<long>();
            Dictionary<int, string> sum = new Dictionary<int, string>();
            for (long i = 1; ; i++)
            {
                var book_borrow = SumDao.GetBook(i);
                if (book_borrow != null)
                {
                    var book = SumDao.GetBookName(book_borrow.book_id);
                    name.Add(book.name);
                    id.Add(book.book_id);
                }
                else
                {
                    break;
                }
            }
            List<Borrows> borlist = new List<Borrows>();
            for (int j=0;j<id.ToArray().Length;j++)
            {
                sum.Add(borlist.Count(x => x.book_id == id[j]),name[j]);
            }
            return sum;
        }
    }
}
