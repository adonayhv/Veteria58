using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veteria58.Web.Models;

namespace Veteria58.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }

                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Failed to login.");
            return View(model);
        }


    }
}
