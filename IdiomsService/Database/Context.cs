using IdiomsService.Database.Models;
using IdiomsService.ExtensionMethods;
using IdiomsService.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IdiomsService.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Language> Languages { get; set; }
        public DbSet<UserLanguage> UserLanguages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Idiom> Idioms { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Upvote> Upvotes { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<LinkType> LinkTypes { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<RefreshToken> Tokens { get; set; }
        public DbSet<CommentLike> CommentLikes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Idiom>()
                    .HasIndex(x => x.DateAdded)
                    .HasSortOrder(SortOrder.Descending);
            modelBuilder.Entity<Comment>()
                    .HasIndex(x => x.DateAdded)
                    .HasSortOrder(SortOrder.Descending);

            modelBuilder.Entity<Link>()
                    .HasOne(x => x.Root)
                    .WithMany(x => x.Links);

            modelBuilder.Entity<Role>().HasData(typeof(Roles).GetEnumList<Role, Roles, Type>());
            modelBuilder.Entity<LinkType>().HasData(typeof(LinkTypes).GetEnumList<LinkType, LinkTypes, Type>());
            modelBuilder.Entity<Language>().HasData(GetLanguages());
        }

        private List<Language> GetLanguages()
        {
            var finalList = new List<Language>();
            var languages = this.GetService<IOptions<AppSettings>>().Value.Languages;
            foreach (var lang in languages)
            {
                var values = lang.Split("-");
                finalList.Add(new Language 
                { 
                    LanguageId = languages.IndexOf(lang) + 1,
                    Locale = values[0],
                    RegionCode = values[1],
                    Name = values[2],
                    NativeName = values[3] });
            }
            return finalList;
        }
    }
}
