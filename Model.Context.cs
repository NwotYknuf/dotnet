﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dotnet
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sysEntities : DbContext
    {
        public sysEntities()
            : base("name=sysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<annee> annee { get; set; }
        public virtual DbSet<categorie> categorie { get; set; }
        public virtual DbSet<cours> cours { get; set; }
        public virtual DbSet<diplome> diplome { get; set; }
        public virtual DbSet<ec> ec { get; set; }
        public virtual DbSet<equivalent_td> equivalent_td { get; set; }
        public virtual DbSet<periode> periode { get; set; }
        public virtual DbSet<personnel> personnel { get; set; }
        public virtual DbSet<type_cours> type_cours { get; set; }
        public virtual DbSet<ue> ue { get; set; }
    }
}
