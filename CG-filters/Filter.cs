using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CG_filters
{
  abstract class Filter
  {
    protected abstract Color calculateNewPixelColor(Bitmap img, int i, int j);

    public Bitmap processImage(Bitmap sourceImage)
    {
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

      for (int i = 0; i < sourceImage.Width; ++i)
      {
        for (int j = 0; j < sourceImage.Height; ++j)
        {
          resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
        }
      }

      return resultImage;
    }
      
    public int Clamp(int val, int min, int max)
    {
      if(val < min)
        return min;
      if(val > max)
        return max;

      return val;
    }
  }
}
