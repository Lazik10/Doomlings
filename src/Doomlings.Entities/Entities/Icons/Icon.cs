using Doomlings.Entities.Entities.Cards.SpecificCards;
using Doomlings.Entities.Enumerations;

namespace Doomlings.Entities.Entities.Icons
{
    public class Icon : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IconType Type { get; set; }

        public byte[] Image { get; set; } = Array.Empty<byte>();

        public ICollection<AgeCard> AgeCards { get; set; } = new List<AgeCard>();

        public ICollection<BirthCard> BirthCards { get; set; } = new List<BirthCard>();

        public ICollection<GenePoolCard> GenePoolCards { get; set; } = new List<GenePoolCard>();

        public ICollection<PlayerAidCard> PlayerAidCards { get; set; } = new List<PlayerAidCard>();

        public ICollection<SignCard> SignCards { get; set; } = new List<SignCard>();

        public ICollection<TraitCard> TraitCards { get; set; } = new List<TraitCard>();
    }
}
