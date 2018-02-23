using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CypherMessageDashboard.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Messages
        public ActionResult ViewAll()
        {
            return View();
        }
        public ActionResult Reply()
        {
            return View();
        }
    }
}