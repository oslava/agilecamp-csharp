using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using AgileCamp.Habitator.Models;
using Microsoft.AspNet.Identity.Owin;

namespace AgileCamp.Habitator.Controllers
{
    public class HabitController : Controller
    {

        public ActionResult AddNew()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<ActionResult> AddNew(string name, string description, TimeSpan time, string returnUrl, DateTime createDate)
        //{
        //    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || (time == TimeSpan.FromTicks(0))
        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return View(model);
        //    //}

        //    // This doesn't count login failures towards account lockout
        //    // To enable password failures to trigger account lockout, change to shouldLockout: true
        //    //var result = await SignInManager<,>.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);
        //    //switch (result)
        //    //{
        //    //    case SignInStatus.Success:
        //    //        return RedirectToLocal(returnUrl);
        //    //    case SignInStatus.LockedOut:
        //    //        return View("Lockout");
        //    //    case SignInStatus.RequiresVerification:
        //    //        return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
        //    //    case SignInStatus.Failure:
        //    //    default:
        //    //        ModelState.AddModelError("", "Invalid login attempt.");
        //    //        return View(model);
        //    //}
        //}

        public void Create()
        {
            var applicationDbContext = new ApplicationDbContext();
            var habit = new Habit
            {
                Name = "h1",
                Description = "none",
                Time = TimeSpan.FromHours(8)

            };

            applicationDbContext.Habits.Add(
                habit);
            applicationDbContext.SaveChanges();
        }
    }

}
