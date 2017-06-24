using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProSoft.Services.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("Get")]
        public IHttpActionResult Get(int id, object dto)
        {
            return Ok();
        }
    }
}
