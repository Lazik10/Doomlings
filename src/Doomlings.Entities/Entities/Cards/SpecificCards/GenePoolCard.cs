using Doomlings.Entities.Entities.Names;
using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Cards.SpecificCards
{
    public class GenePoolCard : BaseCard
    {
        public GenePoolCard(string description)
        {
            Description = description;
        }

        public override string Name  => string.Empty;

        public override CardType Type => CardType.GenePool;

        public override Color Color => Color.None;

        public override Effect Effect => Effect.None;

        public override Expansion Expansion => Expansion.Base;
    }
}
