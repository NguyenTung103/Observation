﻿using ES_CapDien.Helpers;
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
    public partial class DataObservationModel
    {
        public int Device_Id { get; set; }
        public double BTI { get; set; }
        public double BHU { get; set; }
        public double BTO { get; set; }
        public double BDR { get; set; }
        public double BFL { get; set; }
        public double BFR { get; set; }
        public double BPS { get; set; }
        public double BAV { get; set; }
        public double BAP { get; set; }
        public double BAC { get; set; }
        public double BAF { get; set; }
        public double BV1 { get; set; }
        public double BC1 { get; set; }
        public double BT1 { get; set; }
        public double BV2 { get; set; }
        public double BC2 { get; set; }
        public double BT2 { get; set; }
        public double BSE { get; set; }
        public double BA1 { get; set; }
        public double BB1 { get; set; }
        public double BA2 { get; set; }
        public double BB2 { get; set; }
        public double BA3 { get; set; }
        public double BB3 { get; set; }
        public double BA4 { get; set; }
        public double BB4 { get; set; }
        public double BFA { get; set; }
        public double BFD { get; set; }
        public double BPW { get; set; }
        public Nullable<bool> IsSEQ { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public double BWS { get; set; }
        public string NameSite { get; set; }
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
        [Required(ErrorMessage = "Khu vực không được để trống")]
        public int Area_Id { get; set; }
        public int Group_Id { get; set; }
        [Required(ErrorMessage = "Tên trạm không được để trống")]
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
        [Required(ErrorMessage = "Id thiết bị không được để trống")]
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
    public partial class HomeModel
    {
        public int ThietBiKhongHoatDong { get; set; }
        public int ThietBiHoatDong { get; set; }
        public int ThietBiCanhBao { get; set; }        
    }
    public partial class DataAlarmMongo
    {
        public string Id { get; set; }
        public int Device_Id { get; set; }
        public string AMATI { get; set; }
        public string AMIHU { get; set; }
        public string AMADR { get; set; }
        public string AMAFL { get; set; }
        public string AMAFR { get; set; }
        public string AMIPS { get; set; }
        public string AMIAL { get; set; }
        public string AMIAH { get; set; }
        public string AMIAP { get; set; }
        public string AMIAC { get; set; }
        public string AMIGN { get; set; }
        public string AMIAR { get; set; }
        public string AMIL1 { get; set; }
        public string AMIH1 { get; set; }
        public string AMIT1 { get; set; }
        public string AMIL2 { get; set; }
        public string AMIH2 { get; set; }
        public string AMIT2 { get; set; }
        public System.DateTime TimeSend { get; set; }
        public string NameSite { get; set; }
    }
}