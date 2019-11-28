using Administrator;
using System.Web.Mvc;

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
    }
}
