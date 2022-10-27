using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Entities;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class DataDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Database connection string - connection bağlantısı
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Database=GameBuddy; Trusted_Connection=True; MultipleActiveResultSets=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<My_Game> My_Games { get; set; }
        public DbSet<AllGame> AllGames { get; set; }
        public DbSet<GameAccount> GameAccounts { get; set; }


        //fluent api

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //////////////////User
            modelBuilder.Entity<User>().HasKey(x => x.id);
            modelBuilder.Entity<User>().Property(x => x.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(x => x.about).HasColumnType("nvarchar").HasMaxLength(600).HasDefaultValue("Hello i am new to this website...");
            modelBuilder.Entity<User>().Property(x => x.password).HasColumnType("nvarchar").HasMaxLength(16).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.username).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.email).HasColumnType("nvarchar").HasMaxLength(254).IsRequired();
            modelBuilder.Entity<User>().HasIndex(x => x.email).IsUnique();
            //////////////////AllGame
            modelBuilder.Entity<AllGame>().HasKey(x => x.id);
            modelBuilder.Entity<AllGame>().Property(x => x.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<AllGame>().Property(x => x.game_name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            //////////////////My_Game
            modelBuilder.Entity<My_Game>().HasKey(x => x.id);
            modelBuilder.Entity<My_Game>().Property(x => x.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<My_Game>().Property(x => x.user_id).IsRequired();
            modelBuilder.Entity<My_Game>().Property(x => x.game_id).IsRequired();

            //////////////////Rank
            modelBuilder.Entity<GameAccount>().HasKey(x => x.id);
            modelBuilder.Entity<GameAccount>().Property(x => x.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<GameAccount>().Property(x => x.my_game_id).IsRequired();
            modelBuilder.Entity<GameAccount>().Property(x => x.rank).HasColumnType("nvarchar").HasMaxLength(50).HasDefaultValue("Unknown");
            modelBuilder.Entity<GameAccount>().Property(x => x.info).HasColumnType("nvarchar").HasMaxLength(200).HasDefaultValue("There is no information");
            modelBuilder.Entity<GameAccount>().Property(x => x.game_nick).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<GameAccount>().Property(x => x.server).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            //////////////////Relationship
            modelBuilder.Entity<User>().HasMany(x => x.My_Game).WithOne(z => z.User).HasForeignKey(x=>x.user_id).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<AllGame>().HasOne(x => x.My_Game).WithOne(z => z.AllGame).HasForeignKey<My_Game>(x => x.game_id).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<My_Game>().HasMany(x => x.GameAccount).WithOne(z => z.My_Game).HasForeignKey(x => x.my_game_id).OnDelete(DeleteBehavior.Cascade);









        }
    }
}
