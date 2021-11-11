using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketGateVersionTwoImplementationTest.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ticketGate = new TicketGateClientOld
            {
                AuthHeaderValue = new AuthHeader
                {
                    OriginNo = "50",
                    Password = "dis280716play",
                    UserName = "display"
                }
            };

            var x =  ticketGate.GetAvailableTicketsAndConcession(160, 574633, 0,"");

            var xml = new XmlViewModel
            {
                XmlResult = x.OuterXml
            };

            return View(xml);
        }

        public ActionResult About()
        {
            var ticketGate = new TicketGate.New.TicketGateClient
            {
                AuthHeaderValue = new TicketGate.New.AuthHeader
                {
                    OriginNo = "50",
                    Password = "dis280716play",
                    UserName = "display"
                }
            };

            var x = ticketGate.GetAvailableTicketsAndConcession(0, 0, 160, 574633, 0, "", true, 1);

            var xml = new XmlViewModel
            {
                XmlResult = x.OuterXml
            };

            return View(xml);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class XmlViewModel
    {
        public string XmlResult { get; set; }
    }
}