using Hantverksboden1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hantverksboden1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ICraftRepository _craftRepository;

        public HomeController(ILogger<HomeController> logger, ICraftRepository craftRepository)
        {
            _logger = logger;
            _craftRepository = craftRepository;
        }

        public IActionResult Index()
        {
            return View(_craftRepository.AllCrafts);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult CraftCategory1(string categoryId)
        {
            return View(_craftRepository.GetCraftByCategory(Convert.ToInt32(categoryId), _craftRepository.AllCrafts));
        }

        public IActionResult CraftCategory2(string categoryId)
        {
            return View(_craftRepository.GetCraftByCategory(Convert.ToInt32(categoryId), _craftRepository.AllCrafts));
        }

        public IActionResult CraftCategory3(string categoryId)
        {
            return View(_craftRepository.GetCraftByCategory(Convert.ToInt32(categoryId), _craftRepository.AllCrafts));
        }

        public IActionResult CraftCategory4(string categoryId)
        {
            return View(_craftRepository.GetCraftByCategory(Convert.ToInt32(categoryId), _craftRepository.AllCrafts));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
