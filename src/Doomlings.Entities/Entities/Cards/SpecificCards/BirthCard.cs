using Doomlings.Entities.Entities.Names;
using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Cards.SpecificCards
{
    public class BirthCard : BaseCard
    {
        public BirthCard(string description)
        {
            Description = description;
        }

        public override string Name => CardNames.BirthCardName;

        public override CardType Type => CardType.Birth;

        public override Color Color => Color.Various;

        public override Effect Effect => Effect.FirstAgeCard;

        public override Expansion Expansion => Expansion.Base;
    }
}
