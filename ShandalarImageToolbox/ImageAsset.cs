﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ShandalarImageToolbox
{
    public class ImageAsset
    {
        public Bitmap texture;
        public ImageAsset(Bitmap texture)
        {

            this.texture = texture;
        }
    }
}