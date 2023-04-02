using Doomlings.Entities.Entities.Cards;

namespace Doomlings.Entities.Entities.Player
{
    public class Player : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<ICard> CardsInHand { get; set; } = new List<ICard>();
    }
}
