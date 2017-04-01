using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using LifeMatch.Models;
using LifeMatch.Models.ObjectMappers;
using Microsoft.AspNetCore.Mvc;
using ActionResult = System.Web.Mvc.ActionResult;

namespace LifeMatch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [System.Web.Mvc.HttpPost]
        public JsonResult RegisterMember(RegistrationResponsesUIModel registrationResponsesUIModel)
        {
            var registrationResponsesBEModel = RegistrationResponsesMapper.MapRegistrationResponses(registrationResponsesUIModel);

            //TODO - create member in DB based on the registrationResponsesBEModel

            return Json(registrationResponsesBEModel, JsonRequestBehavior.AllowGet);
        }
    }
}