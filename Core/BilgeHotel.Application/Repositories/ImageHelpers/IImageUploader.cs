﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Repositories.ImageHelpers
{
    public interface IImageUploader
    {
         string Upload(string imageName);
    }
}