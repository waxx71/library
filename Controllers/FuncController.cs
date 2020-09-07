using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library.DataAccess.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncController : Controller
    {
        private IFuncDao FuncDao;

        public FuncController(IFuncDao funcDao)
        {
            FuncDao = funcDao;
        }

        //取某id记录
        [HttpGet("{id}")]
        public ActionResult<bool> Get(long id)
        {
            var time = FuncDao.GetCreditByID(id);
            if (time != null)
            {
                if(time.credit<60)//信誉积分不足，借书功能关闭
                {
                    return true;
                }
                else//信誉积分满足需求，借书功能正常
                {
                    return false;
                }
            }
            return false;//查询失败
        }
    }
}