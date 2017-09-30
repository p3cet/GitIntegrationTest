using SingletonTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingletonTest.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            Message CurrentMessage = Message.Instance;
            return View();
        }

        public ActionResult ViewMessage() 
        {
            ViewBag.MessageText = Message.MessageText;
            return View();
        }

        public ActionResult EditMessage() => View();

        public ActionResult SetMessage(string text)
        {
            Message.MessageText = text;
            ViewBag.MessageText = Message.MessageText;
            return View();
        }
    }
}