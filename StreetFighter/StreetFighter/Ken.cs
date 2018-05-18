class Ken : MainCharacter
{
    public Ken()
    {
        Life = 1000;

        SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 0, 59, 112, 160};
        SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 12, 12, 12, 12};

        UpdateSpriteCoordinates();
    }
}