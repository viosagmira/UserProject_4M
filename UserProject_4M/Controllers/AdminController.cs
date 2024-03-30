using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserProject_4M.Models;

namespace UserProject_4M.Controllers
{
	public class AdminController : Controller
    {
		private UserManager<AppUser> userManager;

		public AdminController(UserManager<AppUser> userManager)
		{
			this.userManager = userManager;
		}

		public IActionResult Index()
		{
			return View(userManager.Users);
		}
    }
}

