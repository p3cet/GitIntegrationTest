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
        Message CurrentMessage = Message.Instance;

        // GET: Message
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewMessage() 
        {
            ViewBag.MessageText = CurrentMessage.MessageText;
            return View();
        }

        public ActionResult EditMessage() => View();

        public ActionResult SetMessage(string text)
        {
            CurrentMessage.MessageText = text;
            ViewBag.MessageText = CurrentMessage.MessageText;
            return View();
        }
    }
}