using ES_CapDien.Helpers;
using HelperLibrary;
using PagedList;
using System;
using System.Collections.Generic;

namespace ES_CapDien.Models
{
    /// <summary>
    /// Hiển thị dữ liệu và phân trang
    /// </summary>
    public class GroupsViewModel
    {
        public StaticPagedList<GroupModel> Groups { get; set; }           
        public PagingInfo PagingInfo { get; set; }
    }
    /// <summary>
    /// Hiển thị dữ liệu và phân trang
    /// </summary>
    public class AreaViewModel
    {
        public StaticPagedList<AreaModel> Areas { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
    public class ObservationsViewModel
    {
        public StaticPagedList<ObservationsModel> Observations { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
    /// <summary>
    /// Hiển thị dữ liệu và phân trang
    /// </summary>
    public class SitesViewModel
    {
        public StaticPagedList<SiteModel> Sites { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
    public class UserProfileViewModel
    {
        public StaticPagedList<UserProfileModel> UsP { get; set; }
        public PagingInfo PagingInfo { get; set; }        
    }
    public class RoleViewModel
    {
        public StaticPagedList<RoleModel> Role { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
    public class DataObservationViewModel
    {
        public StaticPagedList<DataObservationModel> DataO { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }

}