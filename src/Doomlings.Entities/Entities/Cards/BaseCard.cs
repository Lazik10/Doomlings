using Doomlings.Entities.Entities.Icons;
using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Cards
{
    public abstract class BaseCard : ICard
    {
        public int Id { get; set; }

        public virtual string Name { get; set; } = string.Empty;

        public virtual string Description { get; set; } = string.Empty;

        public virtual CardType Type { get; set; }

        public virtual Color Color { get; set; }

        public virtual Effect Effect { get; set; }

        public virtual Expansion Expansion { get; set; }

        public virtual IconInfo IconInfo { get; set; } = new IconInfo();
    }
}
