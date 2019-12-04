using ES_CapDien.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ES_CapDien.Models
{
    ///Model
    /// 
   
    public partial class GroupModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên nhóm không để trống")]
        public string Name { get; set; }
        public string Contact { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreateDay { get; set; }
        public Nullable<System.DateTime> UpdateDay { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public string Mobile { get; set; }
        public string NguoiTao { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
    public partial class AreaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên khu vực không để trống")]
        public string Name { get; set; }
        public Nullable<System.DateTime> CreateDay { get; set; }
        public Nullable<System.DateTime> UpdateDay { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public int Group_Id { get; set; }
        public bool IsActive { get; set; }
        public string NguoiTao { get; set; }
        public string GroupsName { get; set; }
    }
    public partial class SiteModel
    {
        public int Id { get; set; }
        public int Area_Id { get; set; }
        public int Group_Id { get; set; }       
        public string Name { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string TimeZone { get; set; }
        public System.DateTime CreateDay { get; set; }
        public Nullable<System.DateTime> UpdateDay { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> DeviceId { get; set; }
        public string NameGroups { get; set; }
        public string NameAreas { get; set; }
        public string NguoiTao { get; set; }
        public string GroupsName { get; set; }
        public string AreasName { get; set; }
    }
    public partial class ObservationsModel
    {
        public int Id { get; set; }
        public Nullable<bool> Noti_Alarm { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> CreateDay { get; set; }
        public Nullable<System.DateTime> UpdateDay { get; set; }
        public string Low_Value { get; set; }
        public string Hight_Value { get; set; }
        public Nullable<bool> IsBieuDo { get; set; }
    }

}