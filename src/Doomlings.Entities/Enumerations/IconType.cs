namespace Doomlings.Entities.Enumerations
{
    [Flags]
    public enum IconType
    {
        // Base set icons
        None                            = 0,
        Star                            = 1,
        Triangle                        = 2,
        DropOfLife                      = 4,
        Action                          = 8,
        Wings                           = 16,

        // Dinolings expansion icons
        DinoEgg                         = 32,

        // Mythlings expansion icons
        ExoticDragon                    = 64,

        // Techlings expansion icons
        CogAndGears                     = 128,
    }
}
