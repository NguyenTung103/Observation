//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ES_CapDien
{
    using System;
    using System.Collections.Generic;
    
    public partial class webpages_UsersInRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Description { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
        public virtual webpages_Roles webpages_Roles { get; set; }
    }
}
