using System.Threading;
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
        bool kick = hardware.IsKeyPressed(Hardware.KEY_Q);
        bool punch = hardware.IsKeyPressed(Hardware.KEY_W);

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
        if (kick)
            character.Animate(MovableSprite.SpriteMovement.KICK);
        if (punch)
            character.Animate(MovableSprite.SpriteMovement.PUNCH);
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


            Thread.Sleep(10);
        } while (!gameOver && !hardware.IsKeyPressed(Hardware.KEY_ESC));
    }
}
