using System.Drawing;

namespace TsMap.Canvas
{
    public class SimpleMapPalette : MapPalette
    {
        public SimpleMapPalette()
        {
            Background = new SolidBrush(Color.FromArgb(27, 27, 27));
            Road = new SolidBrush(Color.FromArgb(90, 90, 90));
            PrefabRoad = new SolidBrush(Color.FromArgb(77, 77, 77));
            PrefabLight = new SolidBrush(Color.FromArgb(120, 120, 120));
            PrefabDark = new SolidBrush(Color.FromArgb(50, 50, 50));
            PrefabGreen = new SolidBrush(Color.FromArgb(75, 90, 67)); // TODO: Check if green has a specific z-index

            CityName = new SolidBrush(Color.FromArgb(210, 210, 210));

            FerryLines = new SolidBrush(Color.FromArgb(30, 255, 255, 255));

            Error = new SolidBrush(Color.FromArgb(90, 0, 0));
        }
    }
}
