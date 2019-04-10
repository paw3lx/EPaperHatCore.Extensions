using System;
using BetaSoft.EPaperHatCore.GUI;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace BetaSoft.EPaperHatCore.Extensions
{
    public static class ScreenExtensions
    {
        public static Image<Rgba32> GetImage(this Screen screen)
        {
            if (screen?.Image == null)
                throw new ArgumentNullException(nameof(screen));
            
            Image<Rgba32> image = new Image<Rgba32>((int)screen.Width, (int)screen.Height);        
            var _widthByte = (image.Width % 8 == 0) ? (image.Width / 8) : (image.Width / 8 + 1);
            for(int y = 0; y < image.Height; y++)
            {
                for(int x = 0; x < image.Width; x++)
                {
                    int address = (int)(x / 8 + y * _widthByte);
                    var value = screen.Image[address];
                    var item = value & (0x80 >> (int)(x % 8));
                    if (item == 0){
                        image[x, y] = Rgba32.White;
                    }
                }
            }
            return image;
        }
    }
}
