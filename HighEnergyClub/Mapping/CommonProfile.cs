using AutoMapper;
using HighEnergyClub.BL.Models;
using HighEnergyClub.PL.ViewModels;
using HighEnergyClub.DAL.Models;

namespace HighEnergyClub.PL.Mapping
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {
            AddBusinessMapping();
            AddWebMapping();
        }

        public void AddWebMapping()
        {
            CreateMap<ArticleEntity, Article>().ReverseMap();
            CreateMap<ArticleImageEntity, ArticleImage>().ReverseMap();
            CreateMap<ExerciseEntity, Exercise>().ReverseMap();
            CreateMap<LinkEntity, Link>().ReverseMap();
            CreateMap<ImageEntity, Image>().ReverseMap();
            CreateMap<SeasonTicketEntity, SeasonTicket>().ReverseMap();
            CreateMap<SeasonTicketTypeEntity, SeasonTicketType>().ReverseMap();
            CreateMap<TrainerStudentEntity, TrainerStudent>().ReverseMap();
            CreateMap<TrainingProgramEntity, TrainingProgram>().ReverseMap();
            CreateMap<TrainingProgramExerciseEntity, TrainingProgramExercise>().ReverseMap();
            CreateMap<UserEntity, User>().ReverseMap();
            CreateMap<RoleEntity, Role>().ReverseMap();
        }

        public void AddBusinessMapping()
        {
            CreateMap<Article, ArticleViewModel>().ReverseMap();
            CreateMap<ArticleImage, ArticleImageViewModel>().ReverseMap();
            CreateMap<Exercise, ExerciseViewModel>().ReverseMap();
            CreateMap<Link, LinkViewModel>().ReverseMap();
            CreateMap<Image, ImageViewModel>().ReverseMap();
            CreateMap<SeasonTicket, SeasonTicketViewModel>().ReverseMap();
            CreateMap<SeasonTicketType, SeasonTicketTypeViewModel>().ReverseMap();
            CreateMap<TrainerStudent, TrainerStudentViewModel>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramViewModel>().ReverseMap();
            CreateMap<TrainingProgramExercise, TrainingProgramExerciseViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<Role, RoleViewModel>().ReverseMap();
        }
    }
}
