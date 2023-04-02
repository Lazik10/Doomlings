using Doomlings.Entities.Entities.Icons;
using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Cards
{
    public interface ICard : IEntity
    {
        string Name { get; }

        string Description { get; }

        CardType Type { get; }

        Color Color { get; }

        Effect Effect { get; }

        Expansion Expansion { get; }

        IconInfo IconInfo { get; }
    }
}
