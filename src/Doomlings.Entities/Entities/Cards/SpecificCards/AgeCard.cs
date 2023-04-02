using Doomlings.Entities.Entities.Icons;
using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Cards.SpecificCards
{
    public class AgeCard : BaseCard
    {
        public AgeCard(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override CardType Type => CardType.Age;

        public override Color Color => Color.None;

        public override Effect Effect => Effect.Event;

        public override Expansion Expansion => Expansion.Base;
    }
}
