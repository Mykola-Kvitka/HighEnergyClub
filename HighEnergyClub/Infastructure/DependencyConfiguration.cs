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

            //BL configuration
            service.AddTransient<IArticleService, ArticleService>();
            service.AddTransient<IExerciseService, ExerciseService>();
            service.AddTransient<ISeasonTicketService, SeasonTicketService>();
            service.AddTransient<ISeasonTicketTypeService, SeasonTicketTypeService>();
            service.AddTransient<ITrainingProgramService, TrainingProgramService>();
        }

    }
}
