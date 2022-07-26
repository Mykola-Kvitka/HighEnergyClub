using AutoMapper;
using HighEnergyClub.BL.Helpers;
using HighEnergyClub.BL.Interfaces;
using HighEnergyClub.BL.Models;
using HighEnergyClub.DAL.Interfaces;
using HighEnergyClub.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsync(SaveArticle request)
        {
            var requestEntity = _mapper.Map<SaveArticle, ArticleEntity>(request);

            var result = (await _unitOfWork.Articles.CreateAsync(requestEntity)).Id;

            if (request.Images.Count != 0)
            {
                var results = await ProcessSavePicturesAdding(request);

                await ProcessSaveDependencyAdding(result, results);
            }
        }

        public async Task UpdateAsync(UpdateArticle request)
        {
            var requestEntity = _mapper.Map<UpdateArticle, ArticleEntity>(request);

            if (request.Images.Count != 0)
            {
                var requestSave = _mapper.Map<UpdateArticle, SaveArticle>(request);

                var results = await ProcessSavePicturesAdding(requestSave);

                await ProcessDeletingDependencyRemove(request.Id);
                await ProcessSaveDependencyAdding(request.Id, results);
            }

            await _unitOfWork.Articles.UpdateAsync(requestEntity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _unitOfWork.Articles.DeleteAsync(id);
            await ProcessDeletingDependencyRemove(id);
        }

        public async Task<IEnumerable<Article>> GetAllAsync()
        {
            var result = await _unitOfWork.Articles.GetAllAsync();

            var articles = _mapper.Map<List<ArticleEntity>, List<Article>>(result);

            await ProcessImagesGetting(articles);

            return articles;
        }

        public async Task<Article> GetAsync(Guid id)
        {
            var result = await _unitOfWork.Articles.GetAsync(id);

            var articles = _mapper.Map<ArticleEntity, Article>(result);

            articles.Images =  await ProcessImagesGetting(articles.Id);

            return articles;
        }

        public async Task<int> GetCountAsync()
        {
            return await _unitOfWork.Articles.GetCountAsync();
        }

        public async Task<IEnumerable<Article>> GetPagedAsync(int page = 1, int pageSize = 15)
        {
            var article = await _unitOfWork.Articles.GetPagedAsync(page, pageSize);

            return _mapper.Map<IEnumerable<ArticleEntity>, IEnumerable<Article>>(article);
        }

        private async Task<IEnumerable<Guid>> ProcessSavePicturesAdding(SaveArticle request)
        {
            var idList = new List<Guid>();
            foreach (var item in request.Images)
            {
                idList.Add((await _unitOfWork.Images.CreateAsync(new ImageEntity
                {
                    ImagePath = await ImageSaveHelper.SaveImageAndGeneratePath(item, "Images/")
                })).ImageId);
            }

            return idList;
        }

        private async Task ProcessSaveDependencyAdding(Guid result, IEnumerable<Guid> results)
        {
            foreach (var item in results)
            {
                await _unitOfWork.ArticleImages.CreateAsync(new ArticleImageEntity
                {
                    ImageId = item,
                    ArticleId = result
                });
            }
        }

        private async Task ProcessDeletingDependencyRemove(Guid id)
        {
            var result = await _unitOfWork.ArticleImages.FindAsync(article => article.ArticleId == id);

            foreach (var item in result)
            {
                ImageSaveHelper.DeleteImage((await _unitOfWork.Images
                    .FindAsync(Im => Im.ImageId == item.ImageId))
                    .First().ImagePath);

                await _unitOfWork.ArticleImages.DeleteAsync(item.ArticleId);
            }
        }

        private async Task<IEnumerable<Image>> ProcessImagesGetting(Guid articles)
        {
            var imagesId = await _unitOfWork.ArticleImages.FindAsync(item => item.ArticleId == articles);

            List<ImageEntity> images = new List<ImageEntity>();

            if (imagesId.Any())
            {

                foreach (var id in imagesId)
                {
                    images.AddRange(await _unitOfWork.Images.FindAsync(item => id.ImageId == item.ImageId));
                }
            }

            return _mapper.Map<List<ImageEntity>, List<Image>>(images);

        }
        private async Task ProcessImagesGetting(List<Article> articles)
        {
            foreach (var article in articles)
            {
                var imagesId = await _unitOfWork.ArticleImages.FindAsync(item => item.ArticleId == article.Id);


                if (imagesId.Any())
                {
                    List<ImageEntity> images = new List<ImageEntity>();

                    foreach (var id in imagesId)
                    {
                        images.AddRange(await _unitOfWork.Images.FindAsync(item => id.ImageId == item.ImageId));
                    }
                    article.Images = _mapper.Map<List<ImageEntity>, List<Image>>(images);
                }
            }
        }
    }
}
