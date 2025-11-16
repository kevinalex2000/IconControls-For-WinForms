using IconControlsForWinForms.Data;
using IconControlsForWinForms.Entities;
using System.Drawing;
using Svg;

namespace IconControlsForWinForms.Logic
{
    class IconLogic
    {
        public static Bitmap? GetImage(IconType type, string name, Color color, int? width = null, int? height = null)
        {
            IconData objIconData = IconData.GetInstance();

            string? svgCode = objIconData.GetIconSvg(type, name);

            if (svgCode == null)
            {
                return null;
            }

            SvgDocument svg = SvgDocument.FromSvg<SvgDocument>(svgCode);

            svg.Fill = new SvgColourServer(color);

            // Default size
            if (!width.HasValue && !height.HasValue)
            {
                width = height = 50;
            }

            // Calculate missing dimension to keep aspect ratio
            if (!width.HasValue || !height.HasValue)
            {
                Image image = svg.Draw(); 
                float aspectRatio = (float)image.Width / image.Height;

                if (!width.HasValue)
                {
                    width = (int?) (height * aspectRatio);
                }
                else // height is null
                {
                    height = (int?) (width / aspectRatio);
                }
            }

            return svg.Draw(width.Value, height.Value);
        }
    }
}
