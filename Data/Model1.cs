namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Domain;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<benefice> benefice { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<communication> communication { get; set; }
        public virtual DbSet<competence> competence { get; set; }
        public virtual DbSet<demande> demande { get; set; }
        public virtual DbSet<evaluation> evaluation { get; set; }
        public virtual DbSet<projet> projet { get; set; }
        public virtual DbSet<responsable> responsable { get; set; }
        public virtual DbSet<ressource> ressource { get; set; }
        public virtual DbSet<solution> solution { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>()
                .Property(e => e.addresse)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.solution)
                .WithOptional(e => e.client)
                .HasForeignKey(e => e.solutionclient_id);

            modelBuilder.Entity<client>()
                .HasMany(e => e.communication)
                .WithOptional(e => e.client)
                .HasForeignKey(e => e.idclient_id);

            modelBuilder.Entity<communication>()
                .Property(e => e.datetime)
                .IsUnicode(false);

            modelBuilder.Entity<communication>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<communication>()
                .Property(e => e.sujet)
                .IsUnicode(false);

            modelBuilder.Entity<communication>()
                .HasMany(e => e.solution)
                .WithOptional(e => e.communication)
                .HasForeignKey(e => e.comunication_id);

            modelBuilder.Entity<competence>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<competence>()
                .Property(e => e.categorie)
                .IsUnicode(false);

            modelBuilder.Entity<competence>()
                .HasMany(e => e.evaluation)
                .WithRequired(e => e.competence)
                .HasForeignKey(e => e.idCompetence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.comptences)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.cv)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.diplome)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.nationalite)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.nomD)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.poste)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.prenomD)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .HasMany(e => e.benefice)
                .WithOptional(e => e.projet)
                .HasForeignKey(e => e.projet_id);

            modelBuilder.Entity<responsable>()
                .Property(e => e.addresse)
                .IsUnicode(false);

            modelBuilder.Entity<responsable>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<responsable>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<responsable>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.CV)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.addresse)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .HasMany(e => e.evaluation)
                .WithRequired(e => e.ressource)
                .HasForeignKey(e => e.idRessource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<solution>()
                .Property(e => e.datetime)
                .IsUnicode(false);

            modelBuilder.Entity<solution>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.addresse)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.adresseMail)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.demande)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.demandeur_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.projet)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.client_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.projet1)
                .WithOptional(e => e.user1)
                .HasForeignKey(e => e.responsable_id);
        }
    }
}
