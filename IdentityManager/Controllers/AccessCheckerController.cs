using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Controllers
{
    [Authorize]
    public class AccessCheckerController : Controller
    {
        [AllowAnonymous]
        public IActionResult AllAccess()
        {
            return View();
        }

        [Authorize]
        public IActionResult AuthorizedAccess()
        {
            return View();
        }

        [Authorize(Roles ="User")]
        public IActionResult UserAccess()
        {
            return View();
        }

        [Authorize(Roles = "User,Admin")]
        public IActionResult UserORAdminAccess()
        {
            return View();
        }

        [Authorize(Policy = "UserAndAdmin")]
        public IActionResult UserANDAdminAccess()
        {
            return View();
        }

        [Authorize(Policy ="Admin")]
        public IActionResult AdminAccess()
        {
            return View();
        }

        [Authorize(Policy = "Admin_CreateAccess")]
        //Accessible by Admin user with claim of create to be true
        public IActionResult Admin_CreateAccess()
        {
            return View();
        }

        [Authorize(Policy = "Admin_Create_Edit_DeleteAccess")]
        //Accessible by Admin user with claim of create edit and delete (and not or)
        public IActionResult Admin_Create_Edit_DeleteAccess()
        {
            return View();
        }

        [Authorize(Policy = "Admin_Create_Edit_DeleteAccess_OR_SuperAdmin")]
        //Accessible by Admin user with claim of create edit and delete (and not or) Or if the user is SuperAdmin
        public IActionResult Admin_Create_Edit_DeleteAccess_OR_SuperAdmin()
        {
            return View();
        }

        [Authorize(Policy = "AdminWithOver1000Days")]
        public IActionResult OnlyBhrugen()
        {
            return View();
        }

        [Authorize(Policy = "FirstNameAuth")]
        public IActionResult FirstNameAuth()
        {
            return View();
        }
    }
}
