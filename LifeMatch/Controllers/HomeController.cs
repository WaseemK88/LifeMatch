using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LifeMatch.DBConnector;
using LifeMatch.Models;
using Microsoft.Ajax.Utilities;
using ActionResult = System.Web.Mvc.ActionResult;

namespace LifeMatch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("WelcomePage");
        }

        public ActionResult SearchMatch()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public JsonResult GetRegistrationOptions()
        {
            var registrationOptionsModel = new RegistrationOptionsModel(); //TODO - get them from DB (they're hard coded now)
            return Json(registrationOptionsModel, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult RegisterMember(RegistrationResponsesUIModel registrationResponsesUIModel)
        {
            RegistrationManager registrationManager = new RegistrationManager();

            var member = registrationManager.RegisterMember(registrationResponsesUIModel);

            var cookie = new HttpCookie("member")
            {
                ["id"] = member.Id.ToString(),
                Expires = DateTime.Now + TimeSpan.FromDays(30)
            };
            Response.Cookies.Add(cookie);

            return Json(member);
        }

        [HttpGet]
        public JsonResult GetUserInfo()
        {
            var memberId = Request.Cookies?["member"]?.Values?["id"];
            if (!memberId.IsNullOrWhiteSpace())
            {
                MemberManager memberManager = new MemberManager();
                var member = memberManager.GetMemberById(Convert.ToInt32(memberId));
                return Json(member, JsonRequestBehavior.AllowGet);
            }
            return null;
        }

    }
}