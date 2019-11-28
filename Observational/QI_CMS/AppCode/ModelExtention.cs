using ES_CapDien.Models;
using System.Text.RegularExpressions;

namespace ES_CapDien.AppCode
{
    public static class ModelExtention
    {
        #region Point
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
                IsActive=entity.IsActive
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
    }
    #endregion
}