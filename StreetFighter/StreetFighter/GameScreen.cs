

class GameScreen : Screen
{
    Image imgBackgroud;
    MainCharacter character = new Ken();


    public GameScreen(Hardware hardware) : base(hardware)
    {
        imgBackgroud = new Image("imgs/background2.png",932,600);
    }

    private void moveCharacter()
    {
        bool left = hardware.IsKeyPressed(Hardware.KEY_LEFT);
        bool right = hardware.IsKeyPressed(Hardware.KEY_RIGHT);

        if (left)
        {
            if (character.X > 0)
            {
                character.X -= MainCharacter.STEP_LENGTH;
            }
        }
        if (right)
        {
                character.X += MainCharacter.STEP_LENGTH;
        }

        if (left)
            character.Animate(MovableSprite.SpriteMovement.LEFT);
        if(right)
            character.Animate(MovableSprite.SpriteMovement.LEFT);
    }


    public override void Show()
    {
        bool gameOver = false;

        character.MoveTo(200, 500);

        do
        {
            short oldX, oldY;

            
            //Draw everything
            hardware.ClearScreen();
            hardware.DrawImage(imgBackgroud);
            hardware.DrawSprite(Sprite.SpriteSheet, (short)(character.X), (short)(character.Y),
                    character.SpriteX, character.SpriteY, Sprite.SPRITE_WIDTH, Sprite.SPRITE_HEIGHT);
            hardware.UpdateScreen();

            oldX = character.X;
            oldY = character.Y;
            moveCharacter();

        } while (!gameOver && !hardware.IsKeyPressed(Hardware.KEY_ESC));
    }
}
