using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ChatRoom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HistoricalMessg = JsonConvert.SerializeObject(SocketHandler.historicalMessg);
            return View();          
        }
     
    }
}
