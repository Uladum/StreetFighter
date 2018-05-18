
class Sprite
{
    public static Image SpriteSheet = new Image("imgs/fighter1.png", 648, 632);

    public const short SPRITE_WIDTH = 48;
    public const short SPRITE_HEIGHT = 63;

    public short X { get; set; }
    public short Y { get; set; }
    public short SpriteX { get; set; }
    public short SpriteY { get; set; }

    public void MoveTo(short x, short y)
    {
        X = x;
        Y = y;
    }
}