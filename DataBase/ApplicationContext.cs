﻿using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class ApplicationContext: DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Engagement> engagements { get; set; }
        //public DbSet<ClientAuditors> clientAuditors { get; set; }
        //public DbSet<Country>  countries { get; set; }
        //public DbSet<AuditMaster> auditMasters { get; set; }
        //public DbSet<Attachment> attachments { get; set; }
        //public DbSet<AccountDetails> AccountDetails { get; set; }
        //public DbSet<AuditOutcomeMaster> auditOutcomeMasters { get; set; }
        //public DbSet<User> users { get; set; }
        //public DbSet<ViewEngagements> ViewEngagements { get; set; }
        //public DbSet<CreateEngagements> CreateEngagements { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ViewEngagements>(e =>
        //    {
        //        e.HasNoKey();
        //    });
        //    modelBuilder.Entity<CreateEngagements>(e =>
        //    {
        //        e.HasNoKey();
        //    });
        //}
    }
}