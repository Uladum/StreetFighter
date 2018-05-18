/*
 * V0.05 : Sprites of the punch and kick implemented
 */
class Ken : MainCharacter
{
    public Ken()
    {
        Life = 1000;

        SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 0, 59, 112, 160};
        SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 12, 12, 12, 12};

        SpriteXCoordinates[(int)MovableSprite.SpriteMovement.KICK] = new int[] { 120, 176, 225};
        SpriteYCoordinates[(int)MovableSprite.SpriteMovement.KICK] = new int[] { 92, 93, 96};

        SpriteXCoordinates[(int)MovableSprite.SpriteMovement.PUNCH] = new int[] { 10 };
        SpriteYCoordinates[(int)MovableSprite.SpriteMovement.PUNCH] = new int[] { 172 };

        UpdateSpriteCoordinates();
    }
}