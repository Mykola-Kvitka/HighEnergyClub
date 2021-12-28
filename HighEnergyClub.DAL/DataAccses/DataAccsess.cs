using HighEnergyClub.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HighEnergyClub.DAL.DataAccses
{
    public class DataAccsess : IdentityDbContext<UserEntity<Guid>>
    {
        public DataAccsess(DbContextOptions<DataAccsess> options) : base(options) { Database.EnsureCreated(); }

        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<ExerciseEntity> Exercises { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
        public DbSet<LinkEntity> Links { get; set; }
        public DbSet<SeasonTicketEntity> SeasonTickets { get; set; }
        public DbSet<SeasonTicketTypeEntity> SeasonTicketTypes { get; set; }
        public DbSet<TrainingProgramEntity> TrainingPrograms { get; set; }
        public DbSet<TrainingProgramExerciseEntity> TrainingProgramExercises { get; set; }
    }
}
