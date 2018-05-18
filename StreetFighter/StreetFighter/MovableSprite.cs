using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MovableSprite : Sprite
{
    const byte TOTAL_MOVEMENTS = 4;
    const byte SPRITE_CHANGE = 4;

    public enum SpriteMovement { LEFT, KICK, PUNCH };
    public SpriteMovement CurrentDirection { get; set; }
    public byte CurrentSprite { get; set; }

    byte currentSpriteChange;

    public int[][] SpriteXCoordinates = new int[TOTAL_MOVEMENTS][];
    public int[][] SpriteYCoordinates = new int[TOTAL_MOVEMENTS][];

    public MovableSprite()
    {
        CurrentSprite = 0;
        CurrentDirection = SpriteMovement.LEFT;
        currentSpriteChange = 0;
    }

    public void Animate(SpriteMovement movement)
    {
        if (movement != CurrentDirection)
        {
            CurrentDirection = movement;
            CurrentSprite = 0;
            currentSpriteChange = 0;
        }
        else
        {
            currentSpriteChange++;
            if (currentSpriteChange >= SPRITE_CHANGE)
            {
                currentSpriteChange = 0;
                CurrentSprite = (byte)((CurrentSprite + 1) % SpriteXCoordinates[(int)CurrentDirection].Length);
            }
        }
        UpdateSpriteCoordinates();
    }

    public void UpdateSpriteCoordinates()
    {
        SpriteX = (short)(SpriteXCoordinates[(int)CurrentDirection][CurrentSprite]);
        SpriteY = (short)(SpriteYCoordinates[(int)CurrentDirection][CurrentSprite]);
    }
}
