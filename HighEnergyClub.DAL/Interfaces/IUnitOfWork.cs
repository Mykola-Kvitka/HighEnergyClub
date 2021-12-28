﻿using HighEnergyClub.DAL.Models;
using System;


namespace HighEnergyClub.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<ArticleEntity> Articles { get; }
        IGenericRepository<ExerciseEntity> Exercises { get; }
        IGenericRepository<ImageEntity> Images { get; }
        IGenericRepository<LinkEntity> Links { get; }
        IGenericRepository<SeasonTicketEntity> SeasonTickets { get; }
        IGenericRepository<SeasonTicketTypeEntity> SeasonTicketTypes { get; }
        IGenericRepository<TrainingProgramEntity> TrainingPrograms { get; }
        IGenericRepository<TrainingProgramExerciseEntity> TrainingProgramExercises { get; }
        IGenericRepository<UserEntity> Users { get; }
        IGenericRepository<ArticleImageEntity> ArticleImages { get; }
        IGenericRepository<TrainerStudentEntity> TrainerStudents{ get; }
    }
}
