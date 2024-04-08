using BilgeHotel.Application.Repositories.ImageHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.ImageHelpers
{
    public class ImageUploader : IImageUploader
    {
        public string Upload(string imageName)
        {
            string newFileName = "";

            var uniqueName = Guid.NewGuid().ToString();

            var fileArray = imageName.Split('.');

            var extension = fileArray[fileArray.Length - 1];

            if (extension == "png" || extension == "jpg" || extension == "gif" || extension == "jpeg")
            {
                newFileName = uniqueName + "." + extension;

                return newFileName;

            }
            else
            {
                return "0";
            }
        }
    }
}
