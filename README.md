# EPaperHatCore.Extensions

Extensions for EPaperHatCore library providing additional functionality for e-paper display operations.

## Features

- **Screen to Image Conversion**: Convert EPaperHatCore Screen objects to ImageSharp images
- **Image Export**: Export screen content to various image formats (JPEG, PNG, etc.)

## Requirements

- .NET 8.0
- EPaperHatCore 0.3.0
- SixLabors.ImageSharp 3.1.11

## Usage

### Converting Screen to Image

```csharp
using EPaperHatCore;
using EPaperHatCore.GUI;
using BetaSoft.EPaperHatCore.Extensions;
using static EPaperHatCore.GUI.Enums;

// Create a screen
var screen = new Screen(264, 176, Rotate.ROTATE_0, Color.WHITE);

// Draw some content
screen.Clear(Color.WHITE);
screen.DrawPoint(50, 50, Color.BLACK, 5, DotStyle.DOT_FILL_AROUND);
screen.DrawLine(20, 70, 70, 120, Color.BLACK, LineStyle.LINE_STYLE_SOLID, 1);
screen.DrawRectangle(20, 70, 70, 120, Color.BLACK, false, 1);

// Convert to ImageSharp image
var image = screen.GetImage();

// Save to file
image.Save("output.jpeg");
```

## Contributing

Contributions are welcome! Please feel free to submit issues and pull requests.

## License

This project is open source. Please check the repository for license details.