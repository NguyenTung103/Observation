﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ObservationsEntities : DbContext
    {
        public ObservationsEntities()
            : base("name=ObservationsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Administrator_Menu> Administrator_Menu { get; set; }
        public virtual DbSet<Administrator_Notifications> Administrator_Notifications { get; set; }
        public virtual DbSet<Administrator_Pages> Administrator_Pages { get; set; }
        public virtual DbSet<Administrator_RoleGroups> Administrator_RoleGroups { get; set; }
        public virtual DbSet<Alarm> Alarms { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Command> Commands { get; set; }
        public virtual DbSet<Datum> Data { get; set; }
        public virtual DbSet<DatumAlarm> DatumAlarms { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Message_noti> Message_noti { get; set; }
        public virtual DbSet<Observation> Observations { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SiteAdminLog> SiteAdminLogs { get; set; }
        public virtual DbSet<SmsServer> SmsServers { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UserWebsite_Category> UserWebsite_Category { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
        public virtual DbSet<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }
        public virtual DbSet<WT_SystemRules> WT_SystemRules { get; set; }
    }
}
