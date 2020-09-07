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
    public class LoseFineController : Controller
    {
        private ILoseFineDao LoseFineDao;

        public LoseFineController(ILoseFineDao loseFineDao)
        {
            LoseFineDao = loseFineDao;
        }

        //丢失书籍上报时进行罚款生成
        [HttpGet("{id}")]
        public ActionResult<bool> Create(long borrow_id)
        {
            List<Violation> violist = new List<Violation>();
            long max = violist.Max(t => t.violation_id);
            var violation = new Violation()
            {
                violation_id = max+1,
                borrow_id = borrow_id,
                type = "lost",
                fine = 100
            };
            var result = LoseFineDao.CreateViolation(violation);
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