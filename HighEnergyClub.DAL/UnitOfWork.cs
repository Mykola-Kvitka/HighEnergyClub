using HighEnergyClub.DAL.DataAccses;
using HighEnergyClub.DAL.Interfaces;
using HighEnergyClub.DAL.Models;
using HighEnergyClub.DAL.Repositories;
using System;

namespace HighEnergyClub.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataAccsess _appData;

        private GenericRepository<ArticleEntity> _articles;
        private GenericRepository<ExerciseEntity> _exercises;
        private GenericRepository<ImageEntity> _images;
        private GenericRepository<LinkEntity> _links;
        private GenericRepository<SeasonTicketEntity> _seasonTikets;
        private GenericRepository<SeasonTicketTypeEntity> _seasonTiketTypes;
        private GenericRepository<TrainingProgramEntity> _trainingPrograms;
        private GenericRepository<TrainingProgramExerciseEntity> _trainingProgramExercises;
        private GenericRepository<TrainerStudentEntity> _trainerStudents;
        private GenericRepository<ArticleImageEntity> _articleImages;

        public UnitOfWork(DataAccsess appData)
        {
            _appData = appData;
        }

        public IGenericRepository<ArticleEntity> Articles => _articles ??= new GenericRepository<ArticleEntity>(_appData);

        public IGenericRepository<ExerciseEntity> Exercises => _exercises ??= new GenericRepository<ExerciseEntity>(_appData);

        public IGenericRepository<ImageEntity> Images => _images ??= new GenericRepository<ImageEntity>(_appData);

        public IGenericRepository<LinkEntity> Links => _links ??= new GenericRepository<LinkEntity>(_appData);

        public IGenericRepository<SeasonTicketEntity> SeasonTickets => _seasonTikets ??= new GenericRepository<SeasonTicketEntity>(_appData);

        public IGenericRepository<SeasonTicketTypeEntity> SeasonTicketTypes => _seasonTiketTypes ??= new GenericRepository<SeasonTicketTypeEntity>(_appData);

        public IGenericRepository<TrainingProgramEntity> TrainingPrograms => _trainingPrograms ??= new GenericRepository<TrainingProgramEntity>(_appData);

        public IGenericRepository<TrainingProgramExerciseEntity> TrainingProgramExercises => _trainingProgramExercises ??= new GenericRepository<TrainingProgramExerciseEntity>(_appData);

        public IGenericRepository<ArticleImageEntity> ArticleImages => _articleImages ??= new GenericRepository<ArticleImageEntity>(_appData);

        public IGenericRepository<TrainerStudentEntity> TrainerStudents => _trainerStudents ??= new GenericRepository<TrainerStudentEntity>(_appData);


    }
}
