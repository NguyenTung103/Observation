using Administrator;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace ES_CapDien.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        [AuthorizeRoles]
        public ActionResult DangNhap()
        {
            return RedirectToAction("GroupsManagement", "Groups");
        }
        [AllowAnonymous]
        public ActionResult LogOff(string returnUrl)
        {
            WebSecurity.Logout();
            return RedirectToAction("Login");
        }
    }
}
