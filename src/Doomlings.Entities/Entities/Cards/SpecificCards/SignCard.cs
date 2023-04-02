using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Cards.SpecificCards
{
    public class SignCard : BaseCard
    {
        public SignCard(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override Color Color => Color.None;

        public override CardType Type => CardType.Sign;

        public override Effect Effect => Effect.EndGameGoals;

        public override Expansion Expansion => Expansion.TheMeaningOfLife;
    }
}
