using HighEnergyClub.BL.Interfaces;
using HighEnergyClub.BL.Services;
using HighEnergyClub.DAL;
using HighEnergyClub.DAL.Interfaces;
using HighEnergyClub.DAL.Models;
using HighEnergyClub.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace HighEnergyClub.PL.Infastructure
{
    public static class DependencyConfiguration
    {
        public static void AddDependencies(this IServiceCollection service)
        {
            //DAL configuration
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddTransient<IGenericRepository<ArticleEntity>, GenericRepository<ArticleEntity>>();
            service.AddTransient<IGenericRepository<ExerciseEntity>, GenericRepository<ExerciseEntity>>();
            service.AddTransient<IGenericRepository<ImageEntity>, GenericRepository<ImageEntity>>();
            service.AddTransient<IGenericRepository<LinkEntity>, GenericRepository<LinkEntity>>();
            service.AddTransient<IGenericRepository<SeasonTicketEntity>, GenericRepository<SeasonTicketEntity>>();
            service.AddTransient<IGenericRepository<SeasonTicketTypeEntity>, GenericRepository<SeasonTicketTypeEntity>>();
            service.AddTransient<IGenericRepository<TrainingProgramEntity>, GenericRepository<TrainingProgramEntity>>();
            service.AddTransient<IGenericRepository<TrainingProgramExerciseEntity>, GenericRepository<TrainingProgramExerciseEntity>>();
            service.AddTransient<IGenericRepository<ArticleImageEntity>, GenericRepository<ArticleImageEntity>>();
            service.AddTransient<IGenericRepository<TrainerStudentEntity>, GenericRepository<TrainerStudentEntity>>();

            //BL configuration
            service.AddTransient<IArticleService, ArticleService>();
            service.AddTransient<IExerciseService, ExerciseService>();
            service.AddTransient<ISeasonTicketService, SeasonTicketService>();
            service.AddTransient<ISeasonTicketTypeService, SeasonTicketTypeService>();
            service.AddTransient<ITrainingProgramService, TrainingProgramService>();
        }

    }
}
