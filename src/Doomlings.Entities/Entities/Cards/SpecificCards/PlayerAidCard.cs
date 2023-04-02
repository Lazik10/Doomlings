using Doomlings.Entities.Entities.Names;
using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Cards.SpecificCards
{
    public class PlayerAidCard : BaseCard
    {
        public override string Name => CardNames.PlayerAidName;

        public override CardType Type => CardType.PlayerAid;

        public override Color Color => Color.Various;

        public override Effect Effect => Effect.None;

        public override Expansion Expansion => Expansion.Base;
    }
}
