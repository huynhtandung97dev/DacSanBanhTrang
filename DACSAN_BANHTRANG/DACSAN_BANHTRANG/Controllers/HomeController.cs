using DACSAN_BANHTRANG.Entities;
using DACSAN_BANHTRANG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DACSAN_BANHTRANG.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		readonly BanhTrangManagermentContext db;
		public HomeController(ILogger<HomeController> logger, BanhTrangManagermentContext _db)
		{
			_logger = logger;
			db = _db;
		}

		public async Task<IActionResult> Index()
		{
			var data = await db.Products.ToListAsync();
			ViewBag.Data = data;
			ViewBag.Slider = data.Where(p => p.Status == true).ToList();
			return View();
		}

		public async Task<IActionResult> PhoiSuong()
		{
			var data = await db.Products.ToListAsync();
			ViewBag.Data = data;
			ViewBag.Slider = data.Where(p => p.IdCategory == 1).ToList();
			return View();
		}

		public async Task<IActionResult> KiTrang()
		{
			var data = await db.Products.ToListAsync();
			ViewBag.Data = data;
			ViewBag.Slider = data.Where(p => p.IdCategory == 2).ToList();
			return View();
		}

		public async Task<IActionResult> GiaVi()
		{
			var data = await db.Products.ToListAsync();
			ViewBag.Data = data;
			ViewBag.Slider = data.Where(p => p.IdCategory == 3).ToList();
			return View();
		}

		public async Task<IActionResult> TronSan()
		{
			var data = await db.Products.ToListAsync();
			ViewBag.Data = data;
			ViewBag.Slider = data.Where(p => p.IdCategory == 4).ToList();
			return View();
		}

		public async Task<IActionResult> ThinhHanh()
		{
			var data = await db.Products.ToListAsync();
			ViewBag.Data = data;
			ViewBag.Slider = data.Where(p => p.IdCategory == 5).ToList();
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
