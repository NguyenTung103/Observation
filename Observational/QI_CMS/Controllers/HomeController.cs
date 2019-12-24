using Administrator;
using ES_CapDien.AppCode;
using ES_CapDien.AppCode.Interface;
using ES_CapDien.Helpers;
using ES_CapDien.Models;
using ES_CapDien.MongoDb.Entity;
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
    public class HomeController : BaseController
    {
        //
        // GET: /Data/
        private readonly DataObservationMongoService dataObservationMongoService;
        private readonly DataAlarmMongoService dataAlarmMongoService;
        private readonly AreasService areasService;
        private readonly SitesService sitesService;
        private readonly GroupService groupService;
        private readonly ObservationService observationService;
        private readonly UserProfileService userProfileService;
        public HomeController()
        {
            dataObservationMongoService = new DataObservationMongoService();
            dataAlarmMongoService = new DataAlarmMongoService();
            areasService = new AreasService();
            sitesService = new SitesService();
            groupService = new GroupService();
            observationService = new ObservationService();
            userProfileService = new UserProfileService();
        }
        public ActionResult Index()
        {
            int CurrentUserId = WebMatrix.WebData.WebSecurity.CurrentUserId;
            string userName = WebMatrix.WebData.WebSecurity.CurrentUserName;                        
            int groupId = userProfileService.userProfileResponsitory.Single(CurrentUserId).Group_Id.Value;
            if(userName=="administrator")
            {
                ViewBag.listSite = sitesService.sitesResponsitory.GetAll().ToList();
            }
            else
            {
                ViewBag.listSite = sitesService.sitesResponsitory.GetAll().Where(i=>i.Group_Id==groupId).ToList();
            }
            ViewBag.lstBieuDo = observationService.observationResponsitory.GetAll().ToList() ;
            HomeModel model = new HomeModel();
            List<Site> sitesInGroup = sitesService.sitesResponsitory.GetAll().Where(i => i.Group_Id == groupId).ToList() ;
            model.ThietBiHoatDong = sitesInGroup.Where(i => i.IsActive == true).Count();
            model.ThietBiKhongHoatDong = sitesInGroup.Where(i => i.IsActive == false).Count();
            ViewBag.listArea = areasService.GetAreasByGroupId(groupId).ToList();
            return View(model);
        }
        public ActionResult GetSite(int idArea)
        {
            List<Site> sites = sitesService.GetByAreaId(idArea).ToList();
            return PartialView("_ListSitePartialView", sites);
        }
        //public ActionResult GetDataAlarm(int siteId)
        //{
        //    Site site = sitesService.sitesResponsitory.Single(siteId);
        //    int deviceId = site.DeviceId.Value;
        //    List<ES_CapDien.MongoDb.Entity.DataAlarm> dataAlarms = new List<DataAlarm>();
        //    dataAlarms = dataAlarmMongoService.GetDataByDay(out int total, 300);
        //    return PartialView("_DataAlarmPartialView", dataAlarms);
        //}
        public JsonResult GetInfoSite(int siteId)
        {
            Site site = sitesService.sitesResponsitory.Single(siteId);
            return Json(new { listData = site }, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult GetDataAlarm(int siteId)
        {
            int deviceId = sitesService.sitesResponsitory.Single(siteId).DeviceId.Value;           
            List<DataAlarmMongo> dataAlarms = new List<DataAlarmMongo>() ;
            DateTime from = DateTime.Now;
            DateTime to = DateTime.Today;
            dataAlarms = dataAlarmMongoService.GetDataPaging(from, to, 0, 15,deviceId, out int total).Select(i=> new DataAlarmMongo {
                Id=i._id,
                AMAFR = i.AMAFR==null?"":i.AMAFR,
                AMADR = i.AMADR == null ? "" : i.AMADR,
                AMATI = i.AMATI == null ? "" : i.AMATI,
                AMIAC = i.AMIAC == null ? "" : i.AMIAC,
                TimeSend=i.CreatedTime
            }).ToList();
            return PartialView("_DataAlarmPartialView", dataAlarms);
        }
        public ActionResult GetDataObservation(int deviceId)
        {            
            List<DataObservationModel> data = new List<DataObservationModel>();
            DateTime from = DateTime.Now.AddMonths(-2);
            DateTime to = DateTime.Today;
            data = dataObservationMongoService.GetDataPagingByDeviceId(from, to, deviceId, 0, 15, out int total).Select(i => new DataObservationModel
            {
                NameSite = sitesService.sitesResponsitory.GetAll().Where(j => j.DeviceId == i.Device_Id).FirstOrDefault().Name,
                DateCreate = i.DateCreate,
                BTI = i.BTI ,
                BTO = i.BTO,
                BHU = i.BHU,
                BWS = i.BWS,
                BAP = i.BAP,
                BAV = i.BAV,
                BAF = i.BAF,
                BAC = i.BAC,
            }).ToList();
            return PartialView("_DataObservationParialView", data);
        }
        public ActionResult GetDataObservationBieuDo(int siteId, int take)
        {
            int deviceId = sitesService.sitesResponsitory.Single(siteId).DeviceId.Value;
            List<DataObservationModel> data = new List<DataObservationModel>();
            DateTime from = DateTime.Now.AddMonths(-2);
            DateTime to = DateTime.Today;
            data = dataObservationMongoService.GetDataPagingByDeviceId(from, to, deviceId, 0, take, out int total).Select(i => new DataObservationModel
            {
                NameSite = sitesService.sitesResponsitory.GetAll().Where(j => j.DeviceId == i.Device_Id).FirstOrDefault().Name,
                DateCreate = i.DateCreate,
                BTI = i.BTI,
                BTO = i.BTO,
                BHU = i.BHU,
                BWS = i.BWS,
                BAP = i.BAP,
                BAV = i.BAV,
                BAF = i.BAF,
                BAC = i.BAC,
            }).ToList();
            return Json(new { listData = data }, JsonRequestBehavior.AllowGet);
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
