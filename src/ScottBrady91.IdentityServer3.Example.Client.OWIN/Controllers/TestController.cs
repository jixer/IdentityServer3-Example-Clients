using ScottBrady91.IdentityServer3.Example.Client.OWIN.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScottBrady91.IdentityServer3.Example.Client.OWIN.Controllers
{
    public class TestController : Controller
    {
        [CustomAuthorize(Roles = "SysAdmin")]
        public ActionResult SysAdmin()
        {
            return View();
        }

        [CustomAuthorize(Roles = "PrePassAdmin")]
        public ActionResult PrePassAdmin()
        {
            return View();
        }
    }
}