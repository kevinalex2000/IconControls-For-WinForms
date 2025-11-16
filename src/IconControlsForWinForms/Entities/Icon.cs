using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconControlsForWinForms.Entities
{
    public enum IconType
    {
        Solid,
        Brands,
        Regular,
        Light,
        Duotone
    }

    class Icon
    {
        // Valores del Csv
        public IconType? Type { get; set; }
        public string? Name { get; set; }
        public string? Svg { get; set; }
    }
}
