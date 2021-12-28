using HighEnergyClub.BL.Helpers;
using HighEnergyClub.BL.Models;
using HighEnergyClub.DAL.Interfaces;
using HighEnergyClub.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Services
{
    public class ArticleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = _unitOfWork;
        }

        public async Task CreateAsync(SaveArticle requst)
        {
            var requstEntity = new ArticleEntity();
            var requst1Entity = new ImageEntity();
            if (requst.Images.Count != 0)
            {
                foreach (var item in requst.Images)
                {
                    requst1Entity.ImagePathId = ImageSaveHelper.SaveImageAndGeneratePath(item, "wwwroot/Images");
                }
            }
            await _unitOfWork.Images.CreateAsync(requst1Entity);
        }
    }
}
