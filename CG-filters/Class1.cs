using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CG_filters
{
  abstract class Filter
  {
    public Bitmap processImage(Bitmap sourceImage)
    {
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

      return resultImage;
    }
  }
}
