
class PlayerSelectScreen : Screen
{
    Image imgBackground, imgChosenPlayer;
    int chosenPlayer = 1;

    public PlayerSelectScreen(Hardware hardware) : base(hardware)
    {
        imgBackground = new Image("imgs/player_select.png", 800, 603);
    }

    public override void Show()
    {
        bool spacePressed = false;
        do
        {
            hardware.ClearScreen();
            hardware.DrawImage(imgBackground);
            //hardware.DrawImage(imgChosenPlayer);
            hardware.UpdateScreen();

            int keyPressed = hardware.KeyPressed();
            if (keyPressed == Hardware.KEY_UP && chosenPlayer > 1)
            {
                //TODO
            }
            else if (keyPressed == Hardware.KEY_DOWN && chosenPlayer < 4)
            {
                //TODO
            }
            else if (keyPressed == Hardware.KEY_RIGHT && chosenPlayer < 2)
            {
                //TODO
            }
            else if (keyPressed == Hardware.KEY_LEFT && chosenPlayer > 0)
            {
                //TODO
            }
            else if (keyPressed == Hardware.KEY_SPACE)
            {
                spacePressed = true;
            }
        }
        while (!spacePressed);
    }

    public int GetChosenPlayer()
    {
        return chosenPlayer;
    }

}