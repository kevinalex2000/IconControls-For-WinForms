using IconControlsForWinForms.Entities;

namespace IconControlsForWinForms.Data
{
    class IconData
    {
        private static IconData? _IconData;
        public List<Entities.Icon>? Icons;

        private IconData()
        {
            string dataString = System.Text.Encoding.UTF8.GetString(Resource.IconsCsv);
            Icons = MapIconsCsv(dataString);
        }

        public string? GetIconSvg(IconType type, string name)
        {
            return Icons?
                .FirstOrDefault(x => x.Type == type && x.Name == name)?
                .Svg ?? null;
        }

        public static IconData GetInstance()
        {
            return _IconData ?? new IconData();
        }

        private List<Entities.Icon> MapIconsCsv(string dataString)
        {
            var icons = new List<Entities.Icon>();

            if (string.IsNullOrWhiteSpace(dataString))
                return icons;

            var lines = dataString.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines.Skip(1)) // omitir encabezado
            {
                var parts = line.Split('\t');

                if (parts.Length >= 3 &&
                    Enum.TryParse<IconType>(parts[0].Trim(), ignoreCase: true, out var iconType))
                {
                    icons.Add(new Entities.Icon
                    {
                        Type = iconType,
                        Name = parts[1].Trim(),
                        Svg = parts[2].Trim()
                    });
                }
            }

            return icons;
        }
    }
}
