namespace Doomlings.Entities.Enumerations
{
    [Flags] 
    public enum Color
    {
        None                            = 0,
        Blue                            = 1,
        Green                           = 2,
        Gray                            = 4,
        Purple                          = 8,
        Red                             = 16,
        Yellow                          = 32,
        Black                           = 64,
        WithoutColor                    = 128,
        Various                         = 256,
        GreenPurple                     = Green | Purple,
        BlueGreen                       = Blue | Green,
        GreenRed                        = Green | Red,
        RedBlue                         = Red | Blue,
        PurpleRed                       = Purple | Red,
        PurpleBlue                      = Purple | Blue,
    }
}
