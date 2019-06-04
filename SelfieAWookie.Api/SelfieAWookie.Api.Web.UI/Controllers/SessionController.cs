using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.Api.Core.Models;

namespace SelfieAWookie.Api.Web.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        #region Public methods
        [HttpGet]
        public ActionResult<WookieResult> Get()
        {
            return new WookieResult()
            {
                Status = "OK",
                Item = new Wookie() { Id = 1, Surname = "Chewie", Size = 300 }
            };
        }
        #endregion
    }
}
