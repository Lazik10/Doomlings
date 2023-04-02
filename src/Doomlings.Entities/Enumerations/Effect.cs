namespace Doomlings.Entities.Enumerations
{
    [Flags]
    public enum Effect
    {
        None                            = 0,
        FirstAgeCard                    = 1,
        Event                           = 2,
        Catastrophe                     = 3,
        TraitEffect                     = 4,
        ScoringEffect                   = 5,
        Action                          = 6,
        OutOfTurnAction                 = 7,
        WorldsEnd                       = 8,
        Scoring                         = 9,
        PlayerTracker                   = 10,
        EndGameGoals                    = 11,
    }
}
