using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Icons
{
    public class IconInfo : IEntity
    {
        public int Id { get; set; }

        public IconType CardIcon { get; set; }

        public string CardIconPath { get; set; } = string.Empty;
    }
}
