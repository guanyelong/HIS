using SHM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHM.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            OperContext oc = new OperContext();
            List<SYS_USERINFO> isRoles = oc.BllSession.ISYS_USERINFOBLL.GetListBy(r => r.LoginName != "").Select(r => r.MiniItem()).ToList();

            return Content(isRoles.Count.ToString());
        }
	}
}