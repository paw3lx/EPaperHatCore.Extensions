using EPaperHatCore;
using EPaperHatCore.GUI;
using SixLabors.ImageSharp;
using Xunit;
using EColor = EPaperHatCore.GUI.Enums.Color;
using static EPaperHatCore.GUI.Enums;

namespace BetaSoft.EPaperHatCore.Extensions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Screen_ToImage_File_Exists()
        {
            var paint = new Screen(264, 176, Rotate.ROTATE_0, EColor.WHITE);
            
            paint.Clear(EColor.WHITE);
            paint.DrawPoint(50, 50, EColor.BLACK, 5, DotStyle.DOT_FILL_AROUND);
            paint.DrawLine(20, 70, 70, 120, EColor.BLACK, LineStyle.LINE_STYLE_SOLID, 1);
            paint.DrawRectangle(20, 70, 70, 120, EColor.BLACK, false, 1);

            var image = paint.GetImage();
            
            image.Save("output.jpeg");

            Assert.True(System.IO.File.Exists("output.jpeg"));
        }
    }
}
