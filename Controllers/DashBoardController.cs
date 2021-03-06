using Microsoft.AspNetCore.Mvc;
using CleverStoreManager.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace CleverStoreManager.Controllers
{
   [Authorize]
   public class DashBoardController : Controller
   {
      private readonly CleverStoreManagerContext _db;
      private readonly UserManager<CleverStoreManagerUser> _userManager;

      public DashBoardController(UserManager<CleverStoreManagerUser> userManager, CleverStoreManagerContext db)
      {
         _db = db;
         _userManager = userManager;
      }

      public async Task<IActionResult> Index()
      {
         var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
         if(userId == null)
         {
            return View();
         }
         var currentUser = await _userManager.FindByIdAsync(userId);
         ViewBag.Company = _db.CleverStoreManagerBusinesses.Where(entry => entry.Agent.Id == currentUser.Id).ToList();
         ViewBag.Agent = _db.Users.Where(entry => entry.Id == currentUser.Id).ToList();
         foreach(CleverStoreManagerUser user in ViewBag.Agent) 
         {
            ViewBag.FullName = user.FullName;
         }
         foreach(CleverStoreManagerBusiness business in ViewBag.Company)
         {
            ViewBag.Name = business.CompanyName;
         }
         var userProducts = _db.CleverStoreManagerProducts.Where(entry => entry.Agent.Id == currentUser.Id).ToList();
         return View(userProducts);
      }
   }
}