using Doomlings.Entities.Entities.Cards.SpecificCards;
using Doomlings.Entities.Entities.Icons;

namespace Doomlings.Entities.Entities.JoinEntities
{
    public class TraitCardIcon : IEntity
    {
        public int Id { get; set; }

        public int AgeCardId { get; set; }

        public AgeCard? AgeCard { get; set; }

        public int IconId { get; set; }

        public Icon? Icon { get; set; }
    }
}
