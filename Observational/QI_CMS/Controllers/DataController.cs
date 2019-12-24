using Administrator;
using ES_CapDien.AppCode;
using ES_CapDien.AppCode.Interface;
using ES_CapDien.Helpers;
using ES_CapDien.Models;
using ES_CapDien.MongoDb.Service;
using HelperLibrary;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ES_CapDien.Controllers
{
    public class DataController : BaseController
    {
        //
        // GET: /Data/
        private readonly DataObservationMongoService dataObservationMongoService;
        private readonly AreasService areasService;
        private readonly SitesService sitesService;
        private readonly GroupService groupService;
        private readonly UserProfileService userProfileService;
        public DataController()
        {
            dataObservationMongoService = new DataObservationMongoService();
            areasService = new AreasService();
            sitesService = new SitesService();
            groupService = new GroupService();
            userProfileService = new UserProfileService();
        }
        public ActionResult Management(int page = 1, int pageSize = 50, string title = "", int? areaId = null, string fromDate = "")
        {
            ViewBag.Title = "";
            ViewBag.MessageStatus = TempData["MessageStatus"];
            ViewBag.Message = TempData["Message"];
            if (pageSize == 1)
            {
                pageSize = CMSHelper.pageSizes[0];
            }
            @ViewBag.PageSizes = CMSHelper.pageSizes;
            
            int CurrentUserId = WebMatrix.WebData.WebSecurity.CurrentUserId;
            int groupId = userProfileService.userProfileResponsitory.Single(CurrentUserId).Group_Id.Value;
            ViewBag.lstTram = sitesService.sitesResponsitory.GetAll().Where(i => i.Group_Id == groupId).ToList();
            string userName = User.Identity.Name;
            int skip = (page - 1) * pageSize;
            DateTime from = DateTime.Today;
            DateTime to = from.AddDays(1);
            if (fromDate != "")
            {
                try
                {
                    from = Convert.ToDateTime(fromDate);
                    to = from.AddDays(1);
                }
                catch { }
            }
            List<DataObservationModel> list = new List<DataObservationModel>();
            list = dataObservationMongoService.GetDataPaging(from,to, skip, pageSize, out int totalRows).OrderByDescending(i => i.DateCreate).Select(x => new DataObservationModel
            {
                BTI = x.BTI,
                BTO = x.BTO,
                BHU = x.BHU,
                BWS = x.BWS,
                BAP = x.BAP,
                BAV = x.BAV,
                BAC = x.BAC,
                BAF = x.BAF,
                NameSite = sitesService.sitesResponsitory.GetAll().Where(i => i.DeviceId == x.Device_Id).FirstOrDefault().Name,
                DateCreate = x.DateCreate
            }).ToList();


            #region Hiển thị dữ liệu và phân trang
            DataObservationViewModel viewModel = new DataObservationViewModel
            {
                DataO = new StaticPagedList<DataObservationModel>(list, page, pageSize, totalRows),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = totalRows
                },
                From = from,
                To = to,
            };
            #endregion
            return View(viewModel);
        }

    }
}
