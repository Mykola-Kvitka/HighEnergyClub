﻿using HighEnergyClub.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HighEnergyClub.DAL.DataAccses
{
    public class DataAccsess : IdentityDbContext<UserEntity, RoleEntity, Guid>
    {
        public DataAccsess(DbContextOptions<DataAccsess> options) : base(options) { Database.EnsureCreated(); }

        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<ArticleImageEntity> ArticleImages { get; set; }
        public DbSet<ExerciseEntity> Exercises { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
        public DbSet<LinkEntity> Links { get; set; }
        public DbSet<SeasonTicketEntity> SeasonTickets { get; set; }
        public DbSet<SeasonTicketTypeEntity> SeasonTicketTypes { get; set; }
        public DbSet<TrainerStudentEntity> TrainerStudents { get; set; }
        public DbSet<TrainingProgramEntity> TrainingPrograms { get; set; }
        public DbSet<TrainingProgramExerciseEntity> TrainingProgramExercises { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ArticleImageEntity>()
                    .HasKey(x => new { x.ArticleId, x.ImageId });

            builder.Entity<TrainerStudentEntity>()
                    .HasKey(x => new { x.StudentId, x.TrainerId });
        }
    }
}
