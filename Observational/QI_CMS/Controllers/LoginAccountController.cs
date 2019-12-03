using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using Administrator.Library.Filters;
using ES_CapDien.Models;
using CaptchaMvc.HtmlHelpers;
using ES_CapDien.AppCode;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;

namespace ES_CapDien.Controllers
{
    [Authorize]
    [InitializeAdministrator]
    public class LoginAccountController : Controller
    {                     
        [AllowAnonymous]
        public ActionResult LogOff(string returnUrl)
        {
            WebSecurity.Logout();
            return Redirect("/Administrator/Account/Login");
        }         
    }
}
