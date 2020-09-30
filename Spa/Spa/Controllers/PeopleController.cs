using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spa.Db;

namespace Spa.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("api/[controller]/[action]")]
    public class PeopleController : ControllerBase
    {
        public PeopleController(EfContext dbContext)
        {
            DbContext = dbContext;
        }

        private EfContext DbContext { get; }

      //  [Route("[controller]/[action]")]
        [HttpGet]
//        [Authorize]
        public List<People> Get()
        {
            var peoples = DbContext.Peoples.AsQueryable();

            var model = new GetModel();

            if (model.Skip != 0)
            {
                peoples = peoples.Skip(model.Skip);
            }

            if (model.Take != 0)
            {
                peoples = peoples.Take(model.Take);
            }

            return peoples.ToList();
        }

        public class GetModel
        {
            public int Take { get; set; } = 0;
            public int Skip { get; set; } = 0;
        }
    }
}
