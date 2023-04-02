using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Cards.SpecificCards
{
    public class TraitCard : BaseCard
    {
        public TraitCard(string name, string description, Color color)
        {
            Name = name;
            Description = description;
            Color = color;
        }

        public override CardType Type => CardType.Trait;
    }
}
