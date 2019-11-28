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

}