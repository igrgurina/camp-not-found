﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampNotFound.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CampModelContainer : DbContext
    {
        public CampModelContainer()
            : base("name=CampModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Event> EventSet { get; set; }
        public virtual DbSet<Vote> VoteSet { get; set; }
        public virtual DbSet<Message> MessageSet { get; set; }
        public virtual DbSet<Photo> PhotoSet { get; set; }
        public virtual DbSet<Board> BoardSet { get; set; }
        public virtual DbSet<Camp> CampSet { get; set; }
        public virtual DbSet<Category> CategorySet { get; set; }
        public virtual DbSet<MemoryAlbum> MemoryAlbumSet { get; set; }
        public virtual DbSet<Currency> CurrencySet { get; set; }
    }
}
