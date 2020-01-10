using ES_CapDien.Models;
using ES_CapDien.Models.Entity;
using System.Text.RegularExpressions;

namespace ES_CapDien.AppCode
{
    public static class ModelExtention
    {
        #region Gruops
        public static GroupModel ToModel(this Group entity)
        {
            return new GroupModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Contact = entity.Contact,
                Status = entity.Status,
                CreateDay = entity.CreateDay,
                UpdateDay = entity.UpdateDay,
                CreateBy = entity.CreateBy,
                UpdateBy = entity.UpdateBy,
                Mobile = entity.Mobile,
                Email = entity.Email,
                IsActive = entity.IsActive
            };
        }
        public static Group ToEntity(this GroupModel model, Group source = null)
        {
            if (source == null)
            {
                source = new Group
                {
                    Id = source.Id,
                    Name = source.Name,
                    Contact = source.Contact,
                    Status = source.Status,
                    CreateDay = source.CreateDay,
                    UpdateDay = source.UpdateDay,
                    CreateBy = source.CreateBy,
                    UpdateBy = source.UpdateBy,
                    Mobile = source.Mobile,
                    Email = source.Email,
                    IsActive = source.IsActive
                };
            }
            source.Id = model.Id;
            source.Name = model.Name;
            source.Contact = model.Contact;
            source.Status = model.Status;
            source.CreateDay = model.CreateDay;
            source.UpdateDay = model.UpdateDay;
            source.UpdateBy = model.UpdateBy;
            source.CreateBy = model.CreateBy;
            source.Mobile = model.Mobile;
            source.Email = model.Email;
            source.IsActive = model.IsActive;
            return source;
        }
        #endregion

        #region Gruops
        public static AreaModel ToModel(this Area entity)
        {
            return new AreaModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Longtitude = entity.Longtitude,
                Latitude = entity.Latitude,
                CreateDay = entity.CreateDay,
                UpdateDay = entity.UpdateDay,
                CreateBy = entity.CreateBy,
                UpdateBy = entity.UpdateBy,
                Group_Id = entity.Group_Id,
                IsActive = entity.IsActive
            };
        }
        public static Area ToEntity(this AreaModel model, Area source = null)
        {
            if (source == null)
            {
                source = new Area
                {
                    Id = source.Id,
                    Name = source.Name,
                    Longtitude = source.Longtitude,
                    Latitude = source.Latitude,
                    CreateDay = source.CreateDay,
                    UpdateDay = source.UpdateDay,
                    CreateBy = source.CreateBy,
                    UpdateBy = source.UpdateBy,
                    Group_Id = source.Group_Id,
                    IsActive = source.IsActive
                };
            }
            source.Id = model.Id;
            source.Name = model.Name;
            source.Longtitude = model.Longtitude;
            source.Latitude = model.Latitude;
            source.CreateDay = model.CreateDay;
            source.UpdateDay = model.UpdateDay;
            source.UpdateBy = model.UpdateBy;
            source.CreateBy = model.CreateBy;
            source.Group_Id = model.Group_Id;
            source.IsActive = model.IsActive;
            return source;
        }
        #endregion

        #region Sites
        public static SiteModel ToModel(this Site entity)
        {
            return new SiteModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Longtitude = entity.Longtitude,
                Latitude = entity.Latitude,
                CreateDay = entity.CreateDay,
                UpdateDay = entity.UpdateDay,
                CreateBy = entity.CreateBy,
                UpdateBy = entity.UpdateBy,
                Group_Id = entity.Group_Id,
                IsActive = entity.IsActive,
                Area_Id = entity.Area_Id,
                DeviceId = entity.DeviceId,
                TimeZone = entity.TimeZone,
                Address = entity.Address
            };
        }
        public static Site ToEntity(this SiteModel model, Site source = null)
        {
            if (source == null)
            {
                source = new Site
                {
                    Id = source.Id,
                    Name = source.Name,
                    Longtitude = source.Longtitude,
                    Latitude = source.Latitude,
                    CreateDay = source.CreateDay,
                    UpdateDay = source.UpdateDay,
                    CreateBy = source.CreateBy,
                    UpdateBy = source.UpdateBy,
                    Group_Id = source.Group_Id,
                    IsActive = source.IsActive,
                    Address = source.Address,
                    DeviceId = source.DeviceId,
                    Area_Id = source.Area_Id,
                    TimeZone = source.TimeZone,                    
                };
            }
            source.Id = model.Id;
            source.Name = model.Name;
            source.Longtitude = model.Longtitude;
            source.Latitude = model.Latitude;
            source.CreateDay = model.CreateDay;
            source.UpdateDay = model.UpdateDay;
            source.UpdateBy = model.UpdateBy;
            source.CreateBy = model.CreateBy;
            source.Group_Id = model.Group_Id;
            source.IsActive = model.IsActive;
            source.Address = source.Address;
            source.DeviceId = source.DeviceId;
            source.Area_Id = source.Area_Id;
            source.TimeZone = source.TimeZone;
            return source;
        }
        #endregion

        #region Observations
        public static ObservationsModel ToModel(this Observation entity)
        {
            return new ObservationsModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Noti_Alarm = entity.Noti_Alarm,
                Code = entity.Code,
                CreateDay = entity.CreateDay,
                UpdateDay = entity.UpdateDay,
                Low_Value = entity.Low_Value,
                Hight_Value = entity.Code,
                IsBieuDo = entity.IsBieuDo
            };
        }
        public static Observation ToEntity(this ObservationsModel model, Observation source = null)
        {
            if (source == null)
            {
                source = new Observation
                {
                    Id = source.Id,
                    Name = source.Name,
                    Noti_Alarm = source.Noti_Alarm,
                    Code = source.Code,
                    CreateDay = source.CreateDay,
                    UpdateDay = source.UpdateDay,
                    Low_Value = source.Low_Value,
                    Hight_Value = source.Code,
                    IsBieuDo = source.IsBieuDo
                };
            }
            source.Id = model.Id;
            source.Name = model.Name;
            source.Noti_Alarm = model.Noti_Alarm;
            source.Code = model.Code;
            source.CreateDay = model.CreateDay;
            source.UpdateDay = model.UpdateDay;
            source.Low_Value = model.Low_Value;
            source.Hight_Value = model.Code;
            source.IsBieuDo = model.IsBieuDo;
            return source;
        }
        #endregion

        #region Data
        public static DataObservationModel ToModel(this Data entity)
        {
            return new DataObservationModel()
            {
                DateCreate = entity.DateCreate,
                BTI = entity.BTI,
                BTO = entity.BTO,
                BHU = entity.BHU,
                BWS = entity.BWS,
                BAP = entity.BAP,
                BAV = entity.BAV,
                BAF = entity.BAF,
                BAC = entity.BAC,
                BA1= entity.BA1,
                BA2= entity.BA2,
                BA3= entity.BA3,
                BA4= entity.BA4,
                BB1= entity.BB1,
                BB2= entity.BB2,
                BB3= entity.BB3,
                BB4= entity.BB4,
                BC1= entity.BC1,
                BC2= entity.BC2,
                BDR= entity.BDR,
                BFA= entity.BFA,
                BFD= entity.BFD,
                BFL= entity.BFL,
                BFR= entity.BFR,
                BPS= entity.BPS,
                BPW= entity.BPW,
                BSE= entity.BSE,
                BT1= entity.BT1,
                BT2= entity.BT2,
                BV1= entity.BV1,
                BV2= entity.BV2,
                Device_Id= entity.Device_Id,
                IsSEQ= entity.IsSEQ
            };
        }        
        #endregion
    }



}