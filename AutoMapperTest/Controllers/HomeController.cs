using AutoMapperTest.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMapperTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var user = new UserInfo()
            {
                ID = 1,
                Name = "张庆广"
            };

            var dto = AutoMapper.Mapper.Map<UserInfo, UserInfoDTO>(user);

            return View(dto);
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
    }
}