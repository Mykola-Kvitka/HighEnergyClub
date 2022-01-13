using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Helpers
{
    public static class ImageSaveHelper
    {
        private static int index = 0;
        private static readonly string slash = "/";
        private static readonly string dot = ".";
        private static string Sufix
        {
            get
            {
                return "(" + index.ToString() + ")";
            }
        }

        public static async Task<string> SaveImageAndGeneratePath(IFormFile image, string directory)
        {
            string[] imageName = image.FileName.Split(".");
            var format = imageName[1];
            string name = imageName[0];
            for (int i = 0; i <= imageName.Length-2; i++)
            {
                name += imageName[i];
            }
            var path = directory + slash + name;
            var template = directory + slash + name;

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            while (File.Exists(template))
            {
                index++;
                template = path + Sufix;
            }

            using (var fileStream = new FileStream(directory + slash + template + dot + format, FileMode.Create))
            {
               await image.CopyToAsync(fileStream);
            }

            return template;
        }

        public static void DeleteImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }
    }
}
