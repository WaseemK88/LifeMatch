using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LifeMatch.Models;
using LifeMatch.Models.ObjectMappers;
using Microsoft.AspNetCore.Http;
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
            var registrationResponsesBEModel = RegistrationResponsesMapper.MapRegistrationResponses(registrationResponsesUIModel);

            //TODO - create member in DB based on the registrationResponsesBEModel
            //TODO - Give some unique ID for the member 
            var cookie = new HttpCookie("member") {["id"] = "12345"};
            Response.Cookies.Add(cookie);

            return Json(registrationResponsesBEModel, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetUserInfo()
        {
            return Json("User 5", JsonRequestBehavior.AllowGet);
        }

    }
}