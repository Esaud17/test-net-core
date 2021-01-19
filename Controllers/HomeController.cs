using AFFILIATES.GB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AFFILIATES.GB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AffiliatesDbContext _context;

        public HomeController(ILogger<HomeController> logger, AffiliatesDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            var contracts = _context.AffiliateContracts.Where(s => (EF.Functions.DateDiffDay(s.ApplicationDate, DateTime.Now) > 30) && s.ContractStatu.Id == 4).ToList();
            foreach (var contract in contracts)
            {
                contract.ContractStatuId = 7;
                _context.Update(contract);
                _context.SaveChanges();
            }

            return RedirectToAction("Index","AffiliateContracts");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
