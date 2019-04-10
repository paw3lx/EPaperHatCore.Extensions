using System;
using BetaSoft.EPaperHatCore.GUI;
using SixLabors.ImageSharp;
using Xunit;
using static BetaSoft.EPaperHatCore.GUI.Enums;

namespace BetaSoft.EPaperHatCore.Extensions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Screen_ToImage_File_Exists()
        {
            var paint = new Screen(264, 176, Rotate.ROTATE_0, Color.WHITE);
            
            paint.Clear(Color.WHITE);
            var font = new Font();
            paint.DrawString(10, 10, "test1", font, Color.WHITE, Color.BLACK);
            paint.DrawString(10, 160, "test2", font, Color.WHITE, Color.BLACK);
            paint.DrawPoint(50, 50, Color.BLACK, 5, DotStyle.DOT_FILL_AROUND);
            paint.DrawLine(20, 70, 70, 120, Color.BLACK, LineStyle.LINE_STYLE_SOLID, 1);
            paint.DrawRectangle(20, 70, 70, 120, Color.BLACK, false, 1);

            var image = paint.GetImage();
            
            image.Save("output.jpeg");

            Assert.True(System.IO.File.Exists("output.jpeg"));
        }
    }
}
