using ES_CapDien.Helpers;
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
   
}