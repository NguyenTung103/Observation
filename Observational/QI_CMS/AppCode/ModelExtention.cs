using ES_CapDien.Models;
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
                Area_Id=entity.Area_Id,
                DeviceId=entity.DeviceId,
                TimeZone=entity.TimeZone,
                Address=entity.Address
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
                    Address=source.Address,
                    DeviceId=source.DeviceId,
                    Area_Id=source.Area_Id,
                    TimeZone=source.TimeZone
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
    }



}