using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using JsonTranslatorSample.Service;

namespace JsonTranslatorSample.Controllers
{
    public class HomeController : Controller
    {
        private IDataService _service;

        public HomeController(IDataService service)
        {
            _service = service;
        }

        public async Task<ActionResult> Index()
        {
            var messages = await _service.GetMessagesAsync();
            return View(messages);
        }
    }
}