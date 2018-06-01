/*
 * V0.05 : Improved the punch and kick animation 
 */
using System.Threading;
using Tao.Sdl;

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
        bool jump = hardware.IsKeyPressed(Hardware.KEY_SPACE);
        bool high_defense = hardware.IsKeyPressed(Hardware.KEY_E);

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

        if (right)
        {
            character.Animate(MovableSprite.SpriteMovement.LEFT);
            if (jump)
                character.Animate(MovableSprite.SpriteMovement.FLIP_FORWARDS);
        }
            
        if (kick)
            character.Animate(MovableSprite.SpriteMovement.KICK);
        if (punch)
            character.Animate(MovableSprite.SpriteMovement.PUNCH);
        if (jump)
            character.Animate(MovableSprite.SpriteMovement.JUMP);
        if(high_defense)
            character.Animate(MovableSprite.SpriteMovement.PUNCH);
    }


    public override void Show()
    {
        //bool gameOver = false;
        int key;
        character.MoveTo(200, 500);

        do
        {
            short oldX, oldY;
            key = hardware.KeyPressed();

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
        } while (key != Sdl.SDLK_ESCAPE);
     }
}
